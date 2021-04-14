using AutoMapper;
using Empr.CoreServicesApi.Controllers;
using Empr.CoreServicesApi.Data.Models;
using Empr.CoreServicesApi.Data.Repositories.Interfaces;
using Empr.CoreServicesApi.Models;
using Empr.CoreServicesApi.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Empr.CoreServicesApi.Data.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly ReVyvvDataContext context;
        private readonly IMapper mapper;

        private readonly IConfiguration configuration;

        public AuthRepository(ReVyvvDataContext context, IMapper mapper, IConfiguration configuration)
        {
            this.context = context;
            this.mapper = mapper;
            this.configuration = configuration;
        }

        public async Task<ServiceResponse<TokenDto>> Login(string username, string password)
        {
            var response = new ServiceResponse<TokenDto>();

            //find existing user if any
            var user = await context.PersonAsUser
                .Include(x => x.PersonFkNavigation)
                .Include(x => x.PlatformParticipantTypeFkNavigation)
                .Include(x => x.MobileBusinessFkNavigation).ThenInclude(x=> x.MobileBusinessNavigation).ThenInclude(x => x.BusinessOrganizationNavigation)
                .FirstOrDefaultAsync(x => x.PersonFkNavigation.PlatformUserName.ToLower().Equals(username.ToLower()));

            if (user == null || !VerifyPasswordHash(password, user.PasswordBin, user.PasswordSalt))
            {
                //want to send the same error message so they don't know whether the user exists!!
                response.Success = false;
                response.Message = "Invalid login.";
            }
            else
            {
                var refreshToken = GenerateRefreshToken();

                response.Data = new TokenDto()
                {
                    Token = CreateToken(user),
                    RefreshToken = refreshToken,
                };

                SaveRefreshToken(username, refreshToken);
            }

            return response;
        }

        public async Task<ServiceResponse<string>> Register(UserRegisterDto user)
        {
            var response = new ServiceResponse<string>();

            try
            {
                if (await UserExists(user.Username))
                {
                    response.Success = false;
                    response.Message = "User already exists.";
                    return response;
                }

                CreatePasswordHash(user.Password, out byte[] passwordHash, out byte[] passwordSalt);

                //create new party
                var party = new Party
                {
                    //create new guid
                    Uuid = Guid.NewGuid().ToString().ToUpper(),
                    CreateDate = DateTime.UtcNow,
                    LastUpdateTimestamp = DateTime.UtcNow
                };

                await context.Party.AddAsync(party);

                //save to get the party id
                await context.SaveChangesAsync();

                //create person
                var person = new Person
                {
                    PersonId = party.PartyId,
                    FullName = user.FullName,
                    PlatformUserName = user.Username,
                    LastUpdateTimestamp = DateTime.UtcNow
                };

                await context.Person.AddAsync(person);

                //save to get the person id
                await context.SaveChangesAsync();

                //create person as user
                var actorType = ActorType.Owner;

                var participantType = await context.PlatformParticipantType
                    .Where(x => x.ParticipantTypeIndicator == actorType.GetDescription()).FirstOrDefaultAsync();

                var personAsUser = new PersonAsUser
                {
                    PersonFk = person.PersonId,
                    Uuid = Guid.NewGuid().ToString().ToUpper(),
                    MobileBusinessFk = null,
                    PasswordBin = passwordHash,
                    PasswordSalt = passwordSalt,
                    PlatformParticipantTypeFk = participantType.PlatformParticipantTypeId,
                    LastUpdateTimestamp = DateTime.UtcNow
                };

                await context.PersonAsUser.AddAsync(personAsUser);

                //save to get the person as user id
                await context.SaveChangesAsync();

                //save the person id
                var personId = (int)person.PersonId;

                //create new contact mechanism uuid
                var cm = new ContactMechanism()
                {
                    Uuid = Guid.NewGuid().ToString(),
                    LastUpdateTimestamp = DateTime.UtcNow
                };

                await context.ContactMechanism.AddAsync(cm);

                //need to save here to get the contact mechanism id!!
                await context.SaveChangesAsync();

                //create Email Address
                var email = new EmailAddress()
                {
                    EmailAddressId = cm.ContactMechanismId,
                    Email = user.Username,
                    EmailTypeCode = user.EmailTypeCode ?? "P",
                    LastUpdateTimestamp = DateTime.UtcNow
                };

                await context.EmailAddress.AddAsync(email);

                await context.SaveChangesAsync();

                response.Data = $"User {person.PlatformUserName} created.";

            }
            catch (Exception ex)
            {
                //create user friendly exception
                response.Success = false;
                response.Message = ex.Message;
                response.Exception = new PlatformScreenException(ex);
            }

            return response;
        }

        private async Task<PersonAsUser> GetPersonAsUser(string username)
        {
            //get the person username
            var user = await context.PersonAsUser.Include(x=> x.PersonFkNavigation)
                .FirstOrDefaultAsync(x => x.PersonFkNavigation.PlatformUserName == username);

            return user;
        }

        public async Task<bool> UserExists(string username)
        {
            if (await context.PersonAsUser
                .Include(x=> x.PersonFkNavigation)
                .AnyAsync(x => x.PersonFkNavigation.PlatformUserName.ToLower() == username.ToLower()))
            {
                return true;
            }

            return false;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using var hmac = new HMACSHA512();
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                //calculate hash given the password
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

                //verify bytes are the same
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        private string CreateToken(PersonAsUser user, IEnumerable<Claim> claims = null)
        {
            var newClaims = new List<Claim>();
            if (claims == null)
            {
                newClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Uuid.ToString()),
                    new Claim(ClaimTypes.Name, user.PersonFkNavigation.PlatformUserName),
                    new Claim(ClaimTypes.Role, user.PlatformParticipantTypeFkNavigation.ParticipantTypeIndicator),
                };

                if (user.MobileBusinessFkNavigation?.MobileBusinessNavigation.BusinessOrganizationNavigation.Uuid != null)
                {
                    newClaims.Add(
                        new Claim("PartyId", user.MobileBusinessFkNavigation.MobileBusinessNavigation.BusinessOrganizationNavigation.Uuid)
                        );
                }
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims??newClaims),
                //set expiration date from appsettings
                Expires = DateTime.UtcNow.AddMinutes(int.Parse(configuration.GetSection("AppSettings:TokenExpirationInMinutes").Value)),
                SigningCredentials = creds,
                Issuer = configuration.GetSection("AppSettings:IssuerUrl").Value,
                Audience = configuration.GetSection("AppSettings:AppServiceBaseUrl").Value,
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

        public string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }

        private ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = false,
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration.GetSection("AppSettings:Token").Value)),
                //we don't care about the expiration date, since we're generating a new refresh token
                ValidateLifetime = false
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken);
            var jwtSecurityToken = securityToken as JwtSecurityToken;

            if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha512, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new SecurityTokenException("Invalid token");
            }

            return principal;
        }

        public async Task<ServiceResponse<TokenDto>> Refresh(TokenDto tokenDto)
        {
            var response = new ServiceResponse<TokenDto>();

            try
            {
                var principal = GetPrincipalFromExpiredToken(tokenDto.Token);
                var username = principal.Identity.Name;
                var savedRefreshToken = GetRefreshToken(username); //retrieve the refresh token from a data store

                if (savedRefreshToken != tokenDto.RefreshToken)
                {
                    throw new SecurityTokenException("Invalid refresh token");
                }

                var userid = principal.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value;

                //get user from principal
                var user = context.PersonAsUser.FirstOrDefault(x => x.Uuid == userid);

                var newJwtToken = CreateToken(user, principal.Claims);
                var newRefreshToken = GenerateRefreshToken();
                DeleteRefreshToken(username);
                SaveRefreshToken(username, newRefreshToken);

                response.Data = new TokenDto()
                {
                    Token = newJwtToken,
                    RefreshToken = newRefreshToken
                };
                
                response.Success = true;
                response.Exception = null;
                response.Message = "Token refreshed.";

                await Task.CompletedTask;
            }
            catch (Exception ex)
            {
                //create user friendly exception
                response.Success = false;
                response.Message = ex.Message;
                response.Exception = new PlatformScreenException(ex);
            }

            return response;
        }

        private string GetRefreshToken(string username)
        {
            return context.Person.FirstOrDefault(x => x.PlatformUserName == username).RefreshToken;
        }

        private void SaveRefreshToken(string username, string newRefreshToken)
        {
            var person = context.Person.FirstOrDefault(x => x.PlatformUserName == username);
            person.RefreshToken = newRefreshToken;

            context.Person.Update(person);
            context.SaveChanges();
        }

        private void DeleteRefreshToken(string username)
        {
            var person = context.Person.FirstOrDefault(x => x.PlatformUserName == username);

            person.RefreshToken = null;

            context.Person.Update(person);
            context.SaveChanges();
        }

        public async Task Logout(TokenDto token)
        {
            var principal = GetPrincipalFromExpiredToken(token.Token);
            var username = principal.Identity.Name;
            var savedRefreshToken = GetRefreshToken(username); //retrieve the refresh token from a data store

            if (savedRefreshToken != token.RefreshToken)
            {
                throw new SecurityTokenException("Invalid refresh token");
            }

            DeleteRefreshToken(username);

            await Task.CompletedTask;
        }
    }
}
