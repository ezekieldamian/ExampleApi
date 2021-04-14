using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Empr.CoreServicesApi.Data;
using Empr.CoreServicesApi.Data.Repositories;
using Empr.CoreServicesApi.Data.Repositories.Interfaces;
using Empr.CoreServicesApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Empr.CoreServicesApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //add the database context using the connection string from the appsettings
            services.AddDbContext<ReVyvvDataContext>(x =>
               {
                   x.EnableSensitiveDataLogging();
                   x.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
               });

            //add health check with db context
            services.AddHealthChecks()
                .AddDbContextCheck<ReVyvvDataContext>()
                //.AddUrlGroup(new Uri(Configuration.GetSection("AppSettings").GetSection("AppServiceUrl").Value), "App Service")
                //.AddUrlGroup(new Uri(Configuration.GetSection("AppSettings").GetSection("DocumentCdnUrl").Value), "Document CDN")
                //.AddUrlGroup(new Uri(Configuration.GetSection("AppSettings").GetSection("DataLakeUrl").Value), "Data Lake")
                //.AddUrlGroup(new Uri(Configuration.GetSection("AppSettings").GetSection("ImageCdnUrl").Value), "Image CDN")
                ;

            //need to add mvc for json settings
            //once I figure out how to do this in net core, this should go away
            services.AddMvc()                
                .AddNewtonsoftJson(options =>
                {
                    //ignore self-reference loop references
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;

                    //configure JSON output to default Pascal case
                    options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                });

            //dependency injection
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IMobileBusinessRepository, MobileBusinessRepository>();
            services.AddScoped<IAuthRepository, AuthRepository>();
            //todo: add all dependency-injected classes here

            //add auto mapper profile
            services.AddAutoMapper(typeof(Startup));

            //Authentication using JWT Bearer token
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII
                            .GetBytes(Configuration.GetSection("AppSettings:Token").Value)),
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero, //default is five minutes
                        ValidAudience = Configuration.GetSection("AppSettings:AppServiceBaseUrl").Value,
                        ValidIssuer = Configuration.GetSection("AppSettings:IssuerUrl").Value
                    };
                    options.Events = new JwtBearerEvents
                    {
                        OnAuthenticationFailed = context =>
                        {
                            if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
                            {
                                context.Response.Headers.Add("Token-Expired", "true");
                                throw new SecurityTokenException("Token expired.");
                            }
                            return Task.CompletedTask;
                        }
                    };
                });

            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new OpenApiInfo { Title = "Core Services Api", Version = "v1" });

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            //this needs to run after Authentication
            app.UseAuthorization();

            app.UseSwagger();

            app.UseSwaggerUI(x =>
            {
                x.SwaggerEndpoint("/swagger/v1/swagger.json", "CoreServicesApiV1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                
                //add a more robust health check endpoint that ensures db can be reached
                endpoints.MapHealthChecks("health", new HealthCheckOptions
                {
                    ResponseWriter = async (context, report) =>
                    {
                        context.Response.ContentType = "application/json";
                        var response = new HealthCheckResponse
                        {
                            Status = report.Status.ToString(),
                            HealthChecks = report.Entries.Select(x => new IndividualHealthCheckResponse
                            {
                                Component = x.Key,
                                Status = x.Value.Status.ToString(),
                                Description = x.Value.Description
                            }),
                            Description = report.Entries.Where(x => x.Value.Status.ToString() != "Healthy").Any() ? "Epic Fail :(" : "God's in His heaven- All's right with the world!",
                            HealthCheckDuration = report.TotalDuration
                        };
                        await context.Response.WriteAsync(JsonConvert.SerializeObject(response));
                    }
                });
            });
        }
    }
}
