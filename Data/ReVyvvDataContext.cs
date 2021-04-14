using Microsoft.EntityFrameworkCore;
using Empr.CoreServicesApi.Models;
using Empr.CoreServicesApi.Data.Models;

namespace Empr.CoreServicesApi.Data
{
    public partial class ReVyvvDataContext : DbContext
    {
        public ReVyvvDataContext(DbContextOptions<ReVyvvDataContext> options) : base(options) { }

        public virtual DbSet<Asset> Asset { get; set; }
        public virtual DbSet<AssetClass> AssetClass { get; set; }
        public virtual DbSet<AssetCollection> AssetCollection { get; set; }
        public virtual DbSet<AssetCollectionAsset> AssetCollectionAsset { get; set; }
        public virtual DbSet<AssetDealStructure> AssetDealStructure { get; set; }
        public virtual DbSet<Auction> Auction { get; set; }
        public virtual DbSet<AuctionInvitedMobileBusiness> AuctionInvitedMobileBusiness { get; set; }
        public virtual DbSet<AuctionItem> AuctionItem { get; set; }
        public virtual DbSet<AuctionProductSugestion> AuctionProductSugestion { get; set; }
        public virtual DbSet<AuditTrailDetail> AuditTrailDetail { get; set; }
        public virtual DbSet<AuditTrailMaster> AuditTrailMaster { get; set; }
        public virtual DbSet<BidHistory> BidHistory { get; set; }
        public virtual DbSet<Build> Build { get; set; }
        public virtual DbSet<BusinessCategory> BusinessCategory { get; set; }
        public virtual DbSet<BusinessLocation> BusinessLocation { get; set; }
        public virtual DbSet<BusinessLocationContactMechanism> BusinessLocationContactMechanism { get; set; }
        public virtual DbSet<BusinessLocationHoursOfOperation> BusinessLocationHoursOfOperation { get; set; }
        public virtual DbSet<BusinessLocationInventory> BusinessLocationInventory { get; set; }
        public virtual DbSet<BusinessLocationInventoryDimensionValue> BusinessLocationInventoryDimensionValue { get; set; }
        public virtual DbSet<BusinessLocationManager> BusinessLocationManager { get; set; }
        public virtual DbSet<BusinessLocationService> BusinessLocationService { get; set; }
        public virtual DbSet<BusinessLocationServiceBay> BusinessLocationServiceBay { get; set; }
        public virtual DbSet<BusinessLocationServiceBayCalendar> BusinessLocationServiceBayCalendar { get; set; }
        public virtual DbSet<BusinessLocationServiceBayService> BusinessLocationServiceBayService { get; set; }
        public virtual DbSet<BusinessLocationStaff> BusinessLocationStaff { get; set; }
        public virtual DbSet<BusinessOrganization> BusinessOrganization { get; set; }
        public virtual DbSet<BusinessPopUpLocation> BusinessPopUpLocation { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<CartAccountReceivable> CartAccountReceivable { get; set; }
        public virtual DbSet<CartCheckOutCharity> CartCheckOutCharity { get; set; }
        public virtual DbSet<CartPayment> CartPayment { get; set; }
        public virtual DbSet<CartPointsAwarded> CartPointsAwarded { get; set; }
        public virtual DbSet<CartProduct> CartProduct { get; set; }
        public virtual DbSet<CartProductCustomization> CartProductCustomization { get; set; }
        public virtual DbSet<CartProductServiceDetail> CartProductServiceDetail { get; set; }
        public virtual DbSet<CartTrustedTradePrompt> CartTrustedTradePrompt { get; set; }
        public virtual DbSet<Charity> Charity { get; set; }
        public virtual DbSet<CleansedAddress> CleansedAddress { get; set; }
        public virtual DbSet<ContactMechanism> ContactMechanism { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Device> Device { get; set; }
        public virtual DbSet<Dimension> Dimension { get; set; }
        public virtual DbSet<DimensionCreatorManufacturer> DimensionCreatorManufacturer { get; set; }
        public virtual DbSet<DimensionDependentInventoryRecord> DimensionDependentInventoryRecord { get; set; }
        public virtual DbSet<DimensionDependentInventoryRecordDimensionValue> DimensionDependentInventoryRecordDimensionValue { get; set; }
        public virtual DbSet<DimensionSourceBusinessCategory> DimensionSourceBusinessCategory { get; set; }
        public virtual DbSet<DimensionSourceMobileBusiness> DimensionSourceMobileBusiness { get; set; }
        public virtual DbSet<DimensionValue> DimensionValue { get; set; }
        public virtual DbSet<EmailAddress> EmailAddress { get; set; }
        public virtual DbSet<Good> Good { get; set; }
        public virtual DbSet<GoodVendorOrder> GoodVendorOrder { get; set; }
        public virtual DbSet<GradedHighLevelFeature> GradedHighLevelFeature { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<Kpi> Kpi { get; set; }
        public virtual DbSet<LiveChat> LiveChat { get; set; }
        public virtual DbSet<LiveChatMessage> LiveChatMessage { get; set; }
        public virtual DbSet<MessageCategoryRoleBasedRecipient> MessageCategoryRoleBasedRecipient { get; set; }
        public virtual DbSet<MissedOrIncompleteWorkShift> MissedOrIncompleteWorkShift { get; set; }
        public virtual DbSet<MobileBusiness> MobileBusiness { get; set; }
        public virtual DbSet<MobileBusinessAggregator> MobileBusinessAggregator { get; set; }
        public virtual DbSet<MobileBusinessAggregatorMobileBusiness> MobileBusinessAggregatorMobileBusiness { get; set; }
        public virtual DbSet<MobileBusinessBusinessCategory> MobileBusinessBusinessCategory { get; set; }
        public virtual DbSet<MobileBusinessCharity> MobileBusinessCharity { get; set; }
        public virtual DbSet<MobileBusinessEmployee> MobileBusinessEmployee { get; set; }
        public virtual DbSet<MobileBusinessEmployeeAuthorizationGroup> MobileBusinessEmployeeAuthorizationGroup { get; set; }
        public virtual DbSet<MobileBusinessEmployeeAuthorizationGroupMembership> MobileBusinessEmployeeAuthorizationGroupMembership { get; set; }
        public virtual DbSet<MobileBusinessEmployeeAuthorizationGroupRole> MobileBusinessEmployeeAuthorizationGroupRole { get; set; }
        public virtual DbSet<MobileBusinessEmployeeAvailability> MobileBusinessEmployeeAvailability { get; set; }
        public virtual DbSet<MobileBusinessEmployeeBreakPreference> MobileBusinessEmployeeBreakPreference { get; set; }
        public virtual DbSet<MobileBusinessEmployeeConcreteSchedule> MobileBusinessEmployeeConcreteSchedule { get; set; }
        public virtual DbSet<MobileBusinessEmployeeLocationFillin> MobileBusinessEmployeeLocationFillin { get; set; }
        public virtual DbSet<MobileBusinessEmployeeOperatingParameters> MobileBusinessEmployeeOperatingParameters { get; set; }
        public virtual DbSet<MobileBusinessEmployeeScheduledWorkdayBreaks> MobileBusinessEmployeeScheduledWorkdayBreaks { get; set; }
        public virtual DbSet<MobileBusinessEmployeeServiceQualification> MobileBusinessEmployeeServiceQualification { get; set; }
        public virtual DbSet<MobileBusinessHighLevelFeatureThresoldScore> MobileBusinessHighLevelFeatureThresoldScore { get; set; }
        public virtual DbSet<MobileBusinessHoliday> MobileBusinessHoliday { get; set; }
        public virtual DbSet<MobileBusinessHoursOfOperation> MobileBusinessHoursOfOperation { get; set; }
        public virtual DbSet<MobileBusinessKeyword> MobileBusinessKeyword { get; set; }
        public virtual DbSet<MobileBusinessKpi> MobileBusinessKpi { get; set; }
        public virtual DbSet<MobileBusinessPlatformSupportedFormOfPayment> MobileBusinessPlatformSupportedFormOfPayment { get; set; }
        public virtual DbSet<MobileBusinessRecruitmentMessage> MobileBusinessRecruitmentMessage { get; set; }
        public virtual DbSet<MobileBusinessServiceOperatingParameters> MobileBusinessServiceOperatingParameters { get; set; }
        public virtual DbSet<MobileBusinessVirtueRanking> MobileBusinessVirtueRanking { get; set; }
        public virtual DbSet<MobileBusinessVirtueScore> MobileBusinessVirtueScore { get; set; }
        public virtual DbSet<Mytest> Mytest { get; set; }
        public virtual DbSet<NotificationEmail> NotificationEmail { get; set; }
        public virtual DbSet<OrderProcessingQueue> OrderProcessingQueue { get; set; }
        public virtual DbSet<Party> Party { get; set; }
        public virtual DbSet<PartyBankAccount> PartyBankAccount { get; set; }
        public virtual DbSet<PartyContactMechanism> PartyContactMechanism { get; set; }
        public virtual DbSet<PartyImage> PartyImage { get; set; }
        public virtual DbSet<PartyLanguagePreference> PartyLanguagePreference { get; set; }
        public virtual DbSet<PartyPlatformObjectivePriority> PartyPlatformObjectivePriority { get; set; }
        public virtual DbSet<PartyPreference> PartyPreference { get; set; }
        public virtual DbSet<PartySavedCreditCard> PartySavedCreditCard { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<PaymentApplication> PaymentApplication { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PersonAsUser> PersonAsUser { get; set; }
        public virtual DbSet<PlatformAssetClass> PlatformAssetClass { get; set; }
        public virtual DbSet<PlatformCustomerSurvey> PlatformCustomerSurvey { get; set; }
        public virtual DbSet<PlatformEmployee> PlatformEmployee { get; set; }
        public virtual DbSet<PlatformError> PlatformError { get; set; }
        public virtual DbSet<PlatformMessage> PlatformMessage { get; set; }
        public virtual DbSet<PlatformMessageCategory> PlatformMessageCategory { get; set; }
        public virtual DbSet<PlatformObjective> PlatformObjective { get; set; }
        public virtual DbSet<PlatformOperationalFunction> PlatformOperationalFunction { get; set; }
        public virtual DbSet<PlatformParticipantType> PlatformParticipantType { get; set; }
        public virtual DbSet<PlatformPersonToPersonFollow> PlatformPersonToPersonFollow { get; set; }
        public virtual DbSet<PlatformRecruitementMessage> PlatformRecruitementMessage { get; set; }
        public virtual DbSet<PlatformRole> PlatformRole { get; set; }
        public virtual DbSet<PlatformScreensMainColor> PlatformScreensMainColor { get; set; }
        public virtual DbSet<PlatformStoreTheme> PlatformStoreTheme { get; set; }
        public virtual DbSet<PlatformSupportedFormOfPayment> PlatformSupportedFormOfPayment { get; set; }
        public virtual DbSet<PlatformSupportedLanguage> PlatformSupportedLanguage { get; set; }
        public virtual DbSet<PostOfficeAddress> PostOfficeAddress { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductApplicableDimension> ProductApplicableDimension { get; set; }
        public virtual DbSet<ProductCustomerReview> ProductCustomerReview { get; set; }
        public virtual DbSet<ProductImage> ProductImage { get; set; }
        public virtual DbSet<ProductQuantityDiscount> ProductQuantityDiscount { get; set; }
        public virtual DbSet<ProductRetailCategory> ProductRetailCategory { get; set; }
        public virtual DbSet<ProductRetailCategoryApplicableDimension> ProductRetailCategoryApplicableDimension { get; set; }
        public virtual DbSet<ProductRetailCategoryTag> ProductRetailCategoryTag { get; set; }
        public virtual DbSet<ProductSubscription> ProductSubscription { get; set; }
        public virtual DbSet<ProductTag> ProductTag { get; set; }
        public virtual DbSet<ProductTerms> ProductTerms { get; set; }
        public virtual DbSet<ProductVirtuePointCredit> ProductVirtuePointCredit { get; set; }
        public virtual DbSet<ProfessionalService> ProfessionalService { get; set; }
        public virtual DbSet<Prospect> Prospect { get; set; }
        public virtual DbSet<Recommendation> Recommendation { get; set; }
        public virtual DbSet<RentableGood> RentableGood { get; set; }
        public virtual DbSet<RentableGoodCalendar> RentableGoodCalendar { get; set; }
        public virtual DbSet<RestockAlert> RestockAlert { get; set; }
        public virtual DbSet<RestockEvent> RestockEvent { get; set; }
        public virtual DbSet<RestockRequirement> RestockRequirement { get; set; }
        public virtual DbSet<RetailCustomer> RetailCustomer { get; set; }
        public virtual DbSet<RetailCustomerBadge> RetailCustomerBadge { get; set; }
        public virtual DbSet<RetailCustomerBusinessRelationship> RetailCustomerBusinessRelationship { get; set; }
        public virtual DbSet<RetailCustomerCharibleContribution> RetailCustomerCharibleContribution { get; set; }
        public virtual DbSet<RetailCustomerCurrentCarharitiesAvailable> RetailCustomerCurrentCarharitiesAvailable { get; set; }
        public virtual DbSet<RetailCustomerMobileBusinessAffinity> RetailCustomerMobileBusinessAffinity { get; set; }
        public virtual DbSet<RetailCustomerPrepaidCard> RetailCustomerPrepaidCard { get; set; }
        public virtual DbSet<RetailCustomerPushCommunication> RetailCustomerPushCommunication { get; set; }
        public virtual DbSet<RetailCustomerServiceCalendarPreference> RetailCustomerServiceCalendarPreference { get; set; }
        public virtual DbSet<RetailCustomerServiceLocationPreference> RetailCustomerServiceLocationPreference { get; set; }
        public virtual DbSet<RetailCustomerServiceSpecialDuration> RetailCustomerServiceSpecialDuration { get; set; }
        public virtual DbSet<RetailCustomerServicerPreference> RetailCustomerServicerPreference { get; set; }
        public virtual DbSet<RetailCustomerTrustedTradePrompt> RetailCustomerTrustedTradePrompt { get; set; }
        public virtual DbSet<RetailCustomerVirtuePoints> RetailCustomerVirtuePoints { get; set; }
        public virtual DbSet<ReverseAuction> ReverseAuction { get; set; }
        public virtual DbSet<ReverseAuctionItem> ReverseAuctionItem { get; set; }
        public virtual DbSet<RoleOperationalFunction> RoleOperationalFunction { get; set; }
        public virtual DbSet<Shipment> Shipment { get; set; }
        public virtual DbSet<Smartphone> Smartphone { get; set; }
        public virtual DbSet<StateOrProvince> StateOrProvince { get; set; }
        public virtual DbSet<SubsriptionModification> SubsriptionModification { get; set; }
        public virtual DbSet<Survey> Survey { get; set; }
        public virtual DbSet<SurveyQuestion> SurveyQuestion { get; set; }
        public virtual DbSet<SurveyQuestionPredefinedReponse> SurveyQuestionPredefinedReponse { get; set; }
        public virtual DbSet<SurveyResponse> SurveyResponse { get; set; }
        public virtual DbSet<Tablet> Tablet { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<TaxItemType> TaxItemType { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<TestSql> TestSql { get; set; }
        public virtual DbSet<ThirdPartyServiceProvider> ThirdPartyServiceProvider { get; set; }
        public virtual DbSet<TokenExchangeRate> TokenExchangeRate { get; set; }
        public virtual DbSet<TrustedTradePrompt> TrustedTradePrompt { get; set; }
        public virtual DbSet<TrustedTradePromptProduct> TrustedTradePromptProduct { get; set; }
        public virtual DbSet<TrustedTradePromptProductRetailCategory> TrustedTradePromptProductRetailCategory { get; set; }
        public virtual DbSet<TrustedTradeType> TrustedTradeType { get; set; }
        public virtual DbSet<UniversalBadge> UniversalBadge { get; set; }
        public virtual DbSet<UniversalItem> UniversalItem { get; set; }
        public virtual DbSet<UniversalItemSource> UniversalItemSource { get; set; }
        public virtual DbSet<UniversalVirtueGrade> UniversalVirtueGrade { get; set; }
        public virtual DbSet<VendorProgram> VendorProgram { get; set; }
        public virtual DbSet<VendorProgramContractTemplate> VendorProgramContractTemplate { get; set; }
        public virtual DbSet<VendorProgramExecutedContract> VendorProgramExecutedContract { get; set; }
        public virtual DbSet<VendorProgramServiceFeedback> VendorProgramServiceFeedback { get; set; }
        public virtual DbSet<VendorProgramServiceProvider> VendorProgramServiceProvider { get; set; }
        public virtual DbSet<Virtue> Virtue { get; set; }
        public virtual DbSet<VwCartDetail> VwCartDetail { get; set; }
        public virtual DbSet<VwGoods> VwGoods { get; set; }
        public virtual DbSet<VwGoods1> VwGoods1 { get; set; }
        public virtual DbSet<VwMobileBusiness> VwMobileBusiness { get; set; }
        public virtual DbSet<VwMobileBusinessEmpoloyee> VwMobileBusinessEmpoloyee { get; set; }
        public virtual DbSet<VwMobileBusinessOfferingCategories> VwMobileBusinessOfferingCategories { get; set; }
        public virtual DbSet<VwServiceSlots> VwServiceSlots { get; set; }
        public virtual DbSet<VwServices> VwServices { get; set; }
        public virtual DbSet<VwServices1> VwServices1 { get; set; }
        public virtual DbSet<VwUserDevice> VwUserDevice { get; set; }
        public virtual DbSet<WeeklySchedule> WeeklySchedule { get; set; }
        public virtual DbSet<Wishlist> Wishlist { get; set; }
        public virtual DbSet<WorkBreakCategory> WorkBreakCategory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "ods");

            modelBuilder.Entity<Asset>(entity =>
            {
                entity.ToTable("asset");

                entity.HasComment("A kind of a product that can be of an asset class.");

                entity.HasIndex(e => e.AssetDealStructureFk)
                    .HasName("Unq_asset_asset_deal_structure_fk")
                    .IsUnique();

                entity.HasIndex(e => e.AssetName)
                    .HasName("ux_asset")
                    .IsUnique();

                entity.Property(e => e.AssetId)
                    .HasColumnName("asset_id")
                    .HasComment("System generated suurogate primary key.")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AssetClassFk)
                    .HasColumnName("asset_class_fk")
                    .HasComment("Foriegn key to associated asset class. NOTE: thids field is nullable since a mobile business is not required to setup asset classes to have assets.");

                entity.Property(e => e.AssetDealStructureFk)
                    .HasColumnName("asset_deal_structure_fk")
                    .HasComment("System generated surrogate primar key.");

                entity.Property(e => e.AssetName)
                    .IsRequired()
                    .HasColumnName("asset_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Human readable text name of asset.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.AssetClassFkNavigation)
                    .WithMany(p => p.Asset)
                    .HasForeignKey(d => d.AssetClassFk)
                    .HasConstraintName("fk_asset_asset_class");

                entity.HasOne(d => d.AssetDealStructureFkNavigation)
                    .WithOne(p => p.Asset)
                    .HasForeignKey<Asset>(d => d.AssetDealStructureFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_asset_asset_deal_struction");

                entity.HasOne(d => d.AssetNavigation)
                    .WithOne(p => p.Asset)
                    .HasForeignKey<Asset>(d => d.AssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_asset_product");
            });

            modelBuilder.Entity<AssetClass>(entity =>
            {
                entity.ToTable("asset_class");

                entity.HasComment("A category of assets - self referencing so that we canhave a hierarchy.");

                entity.HasIndex(e => e.AssetDealStructureFk)
                    .HasName("Unq_asset_class_asset_deal_structure_id")
                    .IsUnique();

                entity.HasIndex(e => new { e.MobileBusinessFk, e.ClassName })
                    .HasName("ux_asset_class")
                    .IsUnique();

                entity.Property(e => e.AssetClassId)
                    .HasColumnName("asset_class_id")
                    .HasComment("System genreated surrogate primary key.");

                entity.Property(e => e.AssetDealStructureFk)
                    .HasColumnName("asset_deal_structure_fk")
                    .HasComment("System generated surrogate primar key.");

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasColumnName("class_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("human readable text name of asset class.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foreign key to mobile business.");

                entity.Property(e => e.ParentAssetClassFk)
                    .HasColumnName("parent_asset_class_fk")
                    .HasComment("Foreign key to parent asset class. Obviously, this field is nullable since it is possible to be at the top of the hierarchy.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.AssetDealStructureFkNavigation)
                    .WithOne(p => p.AssetClass)
                    .HasForeignKey<AssetClass>(d => d.AssetDealStructureFk)
                    .HasConstraintName("fk_asset_class_asset_deal_structure");

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.AssetClass)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_asset_class_mobile_business");

                entity.HasOne(d => d.ParentAssetClassFkNavigation)
                    .WithMany(p => p.InverseParentAssetClassFkNavigation)
                    .HasForeignKey(d => d.ParentAssetClassFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_asset_class_parent_asset_class");
            });

            modelBuilder.Entity<AssetCollection>(entity =>
            {
                entity.ToTable("asset_collection");

                entity.HasComment("A group of assets that are managed together. For example, a set of retail spaces at a shopping mall. The shopping mall itself is the asset collection.");

                entity.Property(e => e.AssetCollectionId)
                    .HasColumnName("asset_collection_id")
                    .HasComment("System generated surrogate key.");

                entity.Property(e => e.CollectionName)
                    .IsRequired()
                    .HasColumnName("collection_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Human readable text name of collection.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<AssetCollectionAsset>(entity =>
            {
                entity.HasKey(e => e.AssetCollectioniAsset)
                    .HasName("pk_asset_collectioni_asset_asset_collectioni_asset");

                entity.ToTable("asset_collection_asset");

                entity.HasComment("Intersection between the asset collection and asset tables. The existence of a record indicates that the associated asset is a mmember of the parent asset collection.");

                entity.Property(e => e.AssetCollectioniAsset)
                    .HasColumnName("asset_collectioni_asset")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.AssetCollectionFk)
                    .HasColumnName("asset_collection_fk")
                    .HasComment("Foreign key to parent asset collection.");

                entity.Property(e => e.AssetFk)
                    .HasColumnName("asset_fk")
                    .HasComment("Foreign key to associated (member) asset.");

                entity.Property(e => e.LastUpdateTimeStamp)
                    .HasColumnName("last_update_time_stamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.AssetCollectionFkNavigation)
                    .WithMany(p => p.AssetCollectionAsset)
                    .HasForeignKey(d => d.AssetCollectionFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_asset_collectioni_asset_collection");

                entity.HasOne(d => d.AssetFkNavigation)
                    .WithMany(p => p.AssetCollectionAsset)
                    .HasForeignKey(d => d.AssetFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_asset_collectioni_asset_asset");
            });

            modelBuilder.Entity<AssetDealStructure>(entity =>
            {
                entity.ToTable("asset_deal_structure");

                entity.HasComment("The manner in which the asset is to be monitized; such as retail customer or business makes me an offer as a percentage of their business.");

                entity.Property(e => e.AssetDealStructureId)
                    .HasColumnName("asset_deal_structure_id")
                    .HasComment("System generated surrogate primar key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TextDescription)
                    .IsRequired()
                    .HasColumnName("text_description")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Human readable deal structure.");
            });

            modelBuilder.Entity<Auction>(entity =>
            {
                entity.ToTable("auction");

                entity.HasComment("A stream of pre-selected items and bundles for sale in pre-set quanities available to buyers who bid on these items as eacch item or bundle approaches it's specified closing time.");

                entity.HasIndex(e => e.AuctionName)
                    .HasName("ux_auction")
                    .IsUnique();

                entity.Property(e => e.AuctionId)
                    .HasColumnName("auction_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.AuctionName)
                    .HasColumnName("auction_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Promotional name of an auction.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foreign key to sponsoring mobile business. NOTE: this field is nullable since the platform may well be sponsiring the auction. NOTE 2: it could be argued that this field is redundant since you can infer the single mobile business for such simpe auction by looking at the products on offer - the lots.");

                entity.Property(e => e.PlatformSponsorFlag)
                    .IsRequired()
                    .HasColumnName("platform_sponsor_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')")
                    .HasComment("'Y' means the platform itself is the sponsor of the auction and will be inviting vendors and suggestions particular products.\\n'N' means the auction is mobile business spscific.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ScheduledStartTimestamp)
                    .HasColumnName("scheduled_start_timestamp")
                    .HasColumnType("datetime")
                    .HasComment("The timestamp (date and time of day) the auction is scheduled to be opened up for bids. NOTE: timestamps are always expressed in terms of Greenich standard time.");

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.Auction)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .HasConstraintName("fk_auction_mobile_bsuiness");
            });

            modelBuilder.Entity<AuctionInvitedMobileBusiness>(entity =>
            {
                entity.ToTable("auction_invited_mobile_business");

                entity.HasComment("An intersection table between the auction and mobile business tables. For a platform sponsored auction a record indicates that the aoosicated mobile business has been invited to particupate in the associated auction.");

                entity.HasIndex(e => new { e.AuctionFk, e.MobileBusinessFk })
                    .HasName("ux_auction_invited_mobile_business")
                    .IsUnique();

                entity.Property(e => e.AuctionInvitedMobileBusinessId)
                    .HasColumnName("auction_invited_mobile_business_id")
                    .HasComment("System generated surrogate primary key.")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AuctionFk)
                    .HasColumnName("auction_fk")
                    .HasComment("Foreign key to parent auction.");

                entity.Property(e => e.InvationDate)
                    .HasColumnName("invation_date")
                    .HasColumnType("date")
                    .HasComment("Date the mobile business was invoted to participate in the auction.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foreign key to participating, or at least invited, mobile business.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.AuctionFkNavigation)
                    .WithMany(p => p.AuctionInvitedMobileBusiness)
                    .HasForeignKey(d => d.AuctionFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_auction_invited_mobile_business_auction");

                entity.HasOne(d => d.AuctionInvitedMobileBusinessNavigation)
                    .WithOne(p => p.AuctionInvitedMobileBusiness)
                    .HasPrincipalKey<AuctionProductSugestion>(p => p.MobileBusinessFk)
                    .HasForeignKey<AuctionInvitedMobileBusiness>(d => d.AuctionInvitedMobileBusinessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_auction_product_sugestion_auction_invited_business");

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.AuctionInvitedMobileBusiness)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_auction_invited_mobile_business_mobile_business");
            });

            modelBuilder.Entity<AuctionItem>(entity =>
            {
                entity.ToTable("auction_item");

                entity.HasComment("A product bundle or product available for sale in the parent auction.");

                entity.HasIndex(e => new { e.AuctionFk, e.ProductFk, e.LotNumber })
                    .HasName("ux_auction_item")
                    .IsUnique();

                entity.Property(e => e.AuctionItemId)
                    .HasColumnName("auction_item_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.AuctionCloseTimestamp)
                    .HasColumnName("auction_close_timestamp")
                    .HasColumnType("datetime")
                    .HasComment("The moment at which the auction system stops taking bids on a item up for auction. NOTE: this time could be soft to imitate human auctioneers. THat is when we reach the end the auction closes as soon as there have been no bids for 5 seconds (going once, going twice, sold for $$$).");

                entity.Property(e => e.AuctionFk)
                    .HasColumnName("auction_fk")
                    .HasComment("Foreign key to parent auction.");

                entity.Property(e => e.AuctionOpenTimestamp)
                    .HasColumnName("auction_open_timestamp")
                    .HasColumnType("datetime")
                    .HasComment("The moment at which the system will start taking bids on an auction item.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.LotNumber)
                    .HasColumnName("lot_number")
                    .HasComment("The order of appearnace of the product in the auction (if we are doing the low tech thing) and in any case an identification number for the particular instance of the product in an auction that might have more than one of the same item.");

                entity.Property(e => e.MinimumPrice)
                    .HasColumnName("minimum_price")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("The price the mobile business sets as the minimum they will accept as the result of ay auction.");

                entity.Property(e => e.ProductFk)
                    .HasColumnName("product_fk")
                    .HasComment("Foreign key to associated product up for auction. Note: this field is nullable since it may represent a bundle.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.WinningBid)
                    .HasColumnName("winning_bid")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("Dollar amount of the winning bid.");

                entity.Property(e => e.WinningBidderFk)
                    .HasColumnName("winning _bidder_fk")
                    .HasComment("Foreign key to retail customer who won the bid. NOTE: this field is nullable since an action item has no winning bidder during the auction and since an item may fail to see any qualifying bid (any bid at or above the minimum price).");

                entity.HasOne(d => d.AuctionFkNavigation)
                    .WithMany(p => p.AuctionItem)
                    .HasForeignKey(d => d.AuctionFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_auction_item_auction");

                entity.HasOne(d => d.ProductFkNavigation)
                    .WithMany(p => p.AuctionItem)
                    .HasForeignKey(d => d.ProductFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_auction_item_product");

                entity.HasOne(d => d.WinningBidderFkNavigation)
                    .WithMany(p => p.AuctionItem)
                    .HasForeignKey(d => d.WinningBidderFk)
                    .HasConstraintName("fk_auction_item_retail_customer");
            });

            modelBuilder.Entity<AuctionProductSugestion>(entity =>
            {
                entity.ToTable("auction_product_sugestion");

                entity.HasComment("For platform sponsored auctions, for particular invited mobile businesses, the platform (based on customer segmentation) will suggest particular products that we feel would do well in an auction. This table holds those suggestions.");

                entity.HasIndex(e => e.LastUpdateTimestamp)
                    .HasName("unq_auction_product_sugestion_last_update_timestamp")
                    .IsUnique();

                entity.HasIndex(e => e.MobileBusinessFk)
                    .HasName("unq_auction_product_sugestion_auction_invited_mobile_business_id")
                    .IsUnique();

                entity.Property(e => e.AuctionProductSugestionId)
                    .HasColumnName("auction_product_sugestion_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foreign key to associated mobile business.");

                entity.Property(e => e.ProductFk)
                    .HasColumnName("product_fk")
                    .HasComment("Foreign key to suggested product,");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SuggestedQuantity)
                    .HasColumnName("suggested_quantity")
                    .HasComment("The number of goods or occurances of service that we suggest the mobile business pt up for auction - as a maximum. NOTE: we can see a low interest and pull back lots.");

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithOne(p => p.AuctionProductSugestion)
                    .HasForeignKey<AuctionProductSugestion>(d => d.MobileBusinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_auction_product_sugestion_mobile_business");

                entity.HasOne(d => d.ProductFkNavigation)
                    .WithMany(p => p.AuctionProductSugestion)
                    .HasForeignKey(d => d.ProductFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_auction_product_sugestion_product");
            });

            modelBuilder.Entity<AuditTrailDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("audit_trail_detail");

                entity.HasComment("For a given instance of a platform actor changing a record (audit trail master) this table holds all the old and new field values where those are different. NOTE: this one table does not have a autoincrment surrogate key, because this is the one table that does not need one. The audit trail does not itself get audited.");

                entity.Property(e => e.AuditTrailMasterFk)
                    .HasColumnName("audit_trail_master_fk")
                    .HasComment("Foreign key to parent audit trail master record.");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasComment("Text name of the field that changed by being inserted updated or deleted.");

                entity.Property(e => e.NewValue)
                    .HasColumnName("new_value")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("The new value of the given field after making the specified change. NOTE: the field can be null to account for deletes.");

                entity.Property(e => e.OldValue)
                    .HasColumnName("old_value")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("The old value of the given field prior to making the specified change. NOTE: the field can be null to account for inserts.");

                entity.HasOne(d => d.AuditTrailMasterFkNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.AuditTrailMasterFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_audit_trail_detail_audit_trail_master");
            });

            modelBuilder.Entity<AuditTrailMaster>(entity =>
            {
                entity.ToTable("audit_trail_master");

                entity.HasComment("A master record of which rows got insert updated or deleted by who and when.");

                entity.HasIndex(e => e.AuditTrailMasterId)
                    .HasName("unq_audit_trail_master_audit_trail_master_id")
                    .IsUnique();

                entity.Property(e => e.AuditTrailMasterId)
                    .HasColumnName("audit_trail_master_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnName("action")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("'I' means insert\\n'U' means update\\n'D' means delete");

                entity.Property(e => e.ActionTimestamp)
                    .HasColumnName("action_timestamp")
                    .HasColumnType("datetime")
                    .HasComment("The time this action was taken on the record. NOTE: the last update timestamp on the record gets over-written from change to cange. To know timing it must be tracked at the audit trail master level.");

                entity.Property(e => e.OdsTableName)
                    .IsRequired()
                    .HasColumnName("ods_table_name")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasComment("Low level table name in the ODS schema.");

                entity.Property(e => e.PartyFk)
                    .HasColumnName("party_fk")
                    .HasComment("The platform actor who made / is taking responsibility for the change to the data. NOTE: this field is nullable to allow for SQL prompt modifications or batch cases where we wish to allow data changes without demanding a platform user take responsibility.");

                entity.Property(e => e.SurrogateId)
                    .HasColumnName("surrogate_id")
                    .HasComment("The key for the row - works for every table since every table has a bigint surrogate key.");

                entity.HasOne(d => d.PartyFkNavigation)
                    .WithMany(p => p.AuditTrailMaster)
                    .HasForeignKey(d => d.PartyFk)
                    .HasConstraintName("fk_audit_trail_master_party");
            });

            modelBuilder.Entity<BidHistory>(entity =>
            {
                entity.ToTable("bid_history");

                entity.HasComment("Auction itme registry of bids. NOTE: this table does not need a last_update_timestamp since it is a historical registry and not subject to updates or deletes.");

                entity.HasIndex(e => new { e.AuctionItemFk, e.BidEventTimestamp })
                    .HasName("ux_bid_history")
                    .IsUnique();

                entity.Property(e => e.BidHistoryId)
                    .HasColumnName("bid_history_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.AuctionItemFk)
                    .HasColumnName("auction_item_fk")
                    .HasComment("Foreign key to parent auction item.");

                entity.Property(e => e.BidAmount)
                    .HasColumnName("bid_amount")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("Dollar amount the bidder - bid.");

                entity.Property(e => e.BidEventTimestamp)
                    .HasColumnName("bid_event_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Time stamp of when we recorded the bid.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RetailCustomerFk)
                    .HasColumnName("retail_customer_fk")
                    .HasComment("Foreign key to bidder.");

                entity.HasOne(d => d.AuctionItemFkNavigation)
                    .WithMany(p => p.BidHistory)
                    .HasForeignKey(d => d.AuctionItemFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_bid_history_auction_item");

                entity.HasOne(d => d.RetailCustomerFkNavigation)
                    .WithMany(p => p.BidHistory)
                    .HasForeignKey(d => d.RetailCustomerFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_bid_history_retail_customer");
            });

            modelBuilder.Entity<Build>(entity =>
            {
                entity.HasKey(e => e.BuildNumber)
                    .HasName("Primary");

                entity.ToTable("build");

                entity.HasComment("Build hold the release number for the entire platform. Also the table will hold, as they arrise any platform wide configuration variables. NOTE: the vision is that this table only ever has 1 row. NOTE 2: the vision is that upon connecting the database, as a first task, reads the build number and makes sure it matches the sdmart phone application expectation - before going further. If they match then the smart phone ap can expect the DB services layer to behaave as has been agreed for this version of the platform.");

                entity.Property(e => e.BuildNumber)
                    .HasColumnName("build_number")
                    .HasComment("Build number increments by 1 with every release.")
                    .ValueGeneratedNever();

                entity.Property(e => e.DbServicesRegressionTestStatus)
                    .HasColumnName("db _services_regression_test_status")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("'P' means pass\\n'F' means fail");

                entity.Property(e => e.LastUpdateTimeStamp)
                    .HasColumnName("last_update_time_stamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<BusinessCategory>(entity =>
            {
                entity.ToTable("business_category");

                entity.HasComment("A classification of mobile businesses that directly compete and which may use the same set of vendors. For example, two garage door companies would use the same garage door manufacturers (Clopay and Amar) since they are the only garage door manufacturers in the United States. NOTE: business cat3gories can be N layers deep. When a");

                entity.HasIndex(e => e.CategoryName)
                    .HasName("ux_business_category")
                    .IsUnique();

                entity.Property(e => e.BusinessCategoryId)
                    .HasColumnName("business_category_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("category_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Text name of category within which mobile businesses compete, such as salon or garage doors.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ServiceProviderTrustRatio)
                    .HasColumnName("service_provider_trust_ratio")
                    .HasColumnType("decimal(5, 4)")
                    .HasComment("A measure of the degree to which shoipping with a given mobile business reflects trust in the mobile business itself as in the case of installing a garage door or fixing a transmission (trust accrues to the mobile business) or hair dressor or lawyer (trust accrues to the service provider not the firm. 0 means none for the service provider and all to the mobile business and 1 means all to the service provider and none to the mobile business. NOTE: .50 or greater and the servicer provider's picture appears when scheduling service appointments and in similar contexts.");
            });

            modelBuilder.Entity<BusinessLocation>(entity =>
            {
                entity.ToTable("business_location");

                entity.HasComment("The Business Location table describes the physical locations used by the Mobile Business.\\nIt can contain transient locations as well as fixed locations.  It \\\"should\\\" contain a service area dimension - To be finished.");

                entity.HasIndex(e => new { e.MobileBusinessFk, e.LocationName })
                    .HasName("ux_business_location")
                    .IsUnique();

                entity.HasIndex(e => new { e.MobileBusinessFk, e.AddressFk, e.LocationStartDate })
                    .HasName("ux2_business_location")
                    .IsUnique();

                entity.Property(e => e.BusinessLocationId)
                    .HasColumnName("business_location_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.AddressFk)
                    .HasColumnName("address_fk")
                    .HasComment("Foreign key to address for physical location. NOTE: initial location can be entred without a physical address so this field is nullable.");

                entity.Property(e => e.GreenwichOffset)
                    .HasColumnName("greenwich_offset")
                    .HasDefaultValueSql("((0))")
                    .HasComment("The number of hours the size rises later at this location as compred to grenage - in effect the time zone to use for all display of associated calenders.");

                entity.Property(e => e.HeadquartersFlag)
                    .IsRequired()
                    .HasColumnName("headquarters_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .HasComment("Flag to indicate that this location is the corporate headquarters (first one entered with out an address).");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.LocationEndDate)
                    .HasColumnName("location_end_date")
                    .HasColumnType("date")
                    .HasComment("Date the business stopped operating at this location.");

                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasColumnName("location_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Text name that the business calls this location.");

                entity.Property(e => e.LocationStartDate)
                    .HasColumnName("location_start_date")
                    .HasColumnType("date")
                    .HasComment("Date the mobile business began operating at this location.");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foreign key to parent mobile business.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RetailWarehouseIndicator)
                    .HasColumnName("retail_warehouse_indicator")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('R')")
                    .HasComment("\"R\" means retail location\\n\"W\" means warehouse location");

                entity.Property(e => e.ServiceCapacity)
                    .HasColumnName("service_capacity")
                    .HasComment("For the case of a salon retail location that has 8 charis the service capacity of that business locaiton is 8.");

                entity.Property(e => e.ServiceCapacityTreatmentIndicator)
                    .HasColumnName("service_capacity_treatment_indicator")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("For example, if a salon location has 8 chairs then the service capacity is 8. However, here is still the question of wheather these service bays (the chairs) are treated as a pooled capacity and the chairs are handed out arbitrarily to customer who merely schedule time at the salon or are they assigned to sparticular barbers and customers schedule particular sub-locations / barbers which amounts to the same thing.\\n'N' - not applicable\\n'P' - means service capacity is treated as a pooled resource\\n'S' - means the service capacity is partitioned into sub-locations");

                entity.Property(e => e.TradeRadiusInMiles)
                    .HasColumnName("trade_radius_in_miles")
                    .HasColumnType("decimal(5, 2)")
                    .HasComment("The radius of a circle around the store where 80% of the customers come from.");

                entity.HasOne(d => d.AddressFkNavigation)
                    .WithMany(p => p.BusinessLocation)
                    .HasForeignKey(d => d.AddressFk)
                    .HasConstraintName("Fk_business_location_post_office_address");

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.BusinessLocation)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .HasConstraintName("fk_business_location_mobile_business");
            });

            modelBuilder.Entity<BusinessLocationContactMechanism>(entity =>
            {
                entity.ToTable("business_location_contact_mechanism");

                entity.HasComment("A contact mechanism for a mobile business location as such vs a employee contact mechanism.");

                entity.HasIndex(e => new { e.BusinessLocationFk, e.ContactMechanismFk })
                    .HasName("ux_location_contact_mechanism")
                    .IsUnique();

                entity.Property(e => e.BusinessLocationContactMechanismId)
                    .HasColumnName("business_location_contact_mechanism_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.BusinessLocationFk)
                    .HasColumnName("business_location_fk")
                    .HasComment("Foreign key to parent business location.");

                entity.Property(e => e.ContactMechanismFk)
                    .HasColumnName("contact_mechanism_fk")
                    .HasComment("Foreign key to applicable contact mechanism.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.BusinessLocationFkNavigation)
                    .WithMany(p => p.BusinessLocationContactMechanism)
                    .HasForeignKey(d => d.BusinessLocationFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_location_contact_mechanism_business_location");

                entity.HasOne(d => d.ContactMechanismFkNavigation)
                    .WithMany(p => p.BusinessLocationContactMechanism)
                    .HasForeignKey(d => d.ContactMechanismFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_location_contact_mechanism_contact_mechanism");
            });

            modelBuilder.Entity<BusinessLocationHoursOfOperation>(entity =>
            {
                entity.ToTable("business_location_hours_of_operation");

                entity.HasComment("The hours of operations of a given business retail location. NOTE: general hours can be set for the enterprise in which case the business locations need not have rows in the business location hours of operation table. In such a case where a hours of work schedule has been set at the mobile business level and rows here at the business lcation evel would constitute an over-ride to those general hours of operations settings. NOTE 2: htis is a one yo one table with business location. It is held separately just for clarity and since some mobile businesses do not have any brick and motor locations in the first place.");

                entity.HasIndex(e => e.BusinessLocationFk)
                    .HasName("ux_business_location_hours_of_operation")
                    .IsUnique();

                entity.Property(e => e.BusinessLocationHoursOfOperationId)
                    .HasColumnName("business_location_hours_of_operation_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.BusinessLocationFk)
                    .HasColumnName("business_location_fk")
                    .HasComment("Foreign key to parent business location.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.WeeklyScheduleFk)
                    .HasColumnName("weekly_schedule_fk")
                    .HasComment("Foreign key to associated weekly schedule.");

                entity.HasOne(d => d.BusinessLocationFkNavigation)
                    .WithOne(p => p.BusinessLocationHoursOfOperation)
                    .HasForeignKey<BusinessLocationHoursOfOperation>(d => d.BusinessLocationFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_business_loation_hours_of_operation_business_location");

                entity.HasOne(d => d.WeeklyScheduleFkNavigation)
                    .WithMany(p => p.BusinessLocationHoursOfOperation)
                    .HasForeignKey(d => d.WeeklyScheduleFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_business_location_hours_of_operation_weekly_schedule");
            });

            modelBuilder.Entity<BusinessLocationInventory>(entity =>
            {
                entity.ToTable("business_location_inventory");

                entity.HasComment("A list of physical goods that are stored at a warehouse. NOTE: since a business can have more than 1 warehouse the invetory level at a warehouse can be less than the product's on hand amount.");

                entity.HasIndex(e => new { e.BusinessLocationFk, e.GoodFk, e.ChildDimensionValues })
                    .HasName("ux_business_location_inventory")
                    .IsUnique();

                entity.Property(e => e.BusinessLocationInventoryId)
                    .HasColumnName("business_location_inventory_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.BusinessLocationFk)
                    .HasColumnName("business_location_fk")
                    .HasComment("foreign key to business location.");

                entity.Property(e => e.ChildDimensionValues)
                    .IsRequired()
                    .HasColumnName("child_dimension_values")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('NA')")
                    .HasComment("A list of the dimension values for the inventory record. For example, for a a record that says 75 t-shirts we would see the list RedSmall - really as a list of surrogate keys 71,88. This field must be maintained by triggers on the business_location_inventory_dimension_value tables and exists in this table to make it possible to enforce a meaningful uniqueness constraint.");

                entity.Property(e => e.DefinitionCompleteFlag)
                    .HasColumnName("definition_complete_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')")
                    .HasComment("\"Y' means yes, the location inventory record has a complete set of assocaited dimension values down in the business_location_inventory_dimension_value table to properly define what we are talking about (NOTE: this is frequently none).\\n'N' means no, we do not have an adequate set of deimension values down in the business_location_inventory_dimension_value table. NOTE2: this field is maintained by triggers down at the business_location_inventory_dimension_value table level.");

                entity.Property(e => e.GoodFk)
                    .HasColumnName("good_fk")
                    .HasComment("Foreign key to a particular physical good.");

                entity.Property(e => e.InventoryLevel)
                    .HasColumnName("inventory_level")
                    .HasComment("Quantity of the physical good on hand at the parent business warehouse. NOTE: this field is allowed to be null to account for the situation where a business owner first notes what items are at the warehouse and at a later date notes the inventory level.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.BusinessLocationFkNavigation)
                    .WithMany(p => p.BusinessLocationInventory)
                    .HasForeignKey(d => d.BusinessLocationFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_business_location_inventory_business_location");

                entity.HasOne(d => d.GoodFkNavigation)
                    .WithMany(p => p.BusinessLocationInventory)
                    .HasForeignKey(d => d.GoodFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_business_location_inventory_good");
            });

            modelBuilder.Entity<BusinessLocationInventoryDimensionValue>(entity =>
            {
                entity.ToTable("business_location_inventory_dimension_value");

                entity.HasComment("An intersection between the business location inventory record (for a given good) and the dimension value table. The idea is that the associated dimension applies to the indirectly associated good.  For example, a pile of 110 garage doors at a whare house need to be identified as white, almond or chocolate brown as their color (an applicable dimension.");

                entity.HasIndex(e => new { e.BusinessLocationInventoryFk, e.DimensionValueFk })
                    .HasName("ux_business_location_inventory_dimension_value")
                    .IsUnique();

                entity.Property(e => e.BusinessLocationInventoryDimensionValueId)
                    .HasColumnName("business_location_inventory_dimension_value_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.BusinessLocationInventoryFk)
                    .HasColumnName("business_location_inventory_fk")
                    .HasComment("Foreign key to parent business loation inventory record.");

                entity.Property(e => e.DimensionValueFk)
                    .HasColumnName("dimension_value_fk")
                    .HasComment("Foreign key to associated dimension value.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.BusinessLocationInventoryFkNavigation)
                    .WithMany(p => p.BusinessLocationInventoryDimensionValue)
                    .HasForeignKey(d => d.BusinessLocationInventoryFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_business_location_inventory_dimension_value_loc_inventory");

                entity.HasOne(d => d.DimensionValueFkNavigation)
                    .WithMany(p => p.BusinessLocationInventoryDimensionValue)
                    .HasForeignKey(d => d.DimensionValueFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_business_location_inventory_dimension_value_dimension_value");
            });

            modelBuilder.Entity<BusinessLocationManager>(entity =>
            {
                entity.ToTable("business_location_manager");

                entity.HasComment("An intersection between the business location and mobile_business_employee tables. The existence of a record indicates that the associated mobile business employee works as a manager of the associated business location. Although the expectation is that this will almost always be a single person, it is possible that the business owner wishes to specify more than one person as the manager for a given business location; perhaps a day and night manager. Therefore, we have a separate intersection table.");

                entity.HasIndex(e => new { e.BusinessLocationFk, e.MobileBusinessEmployeeFk, e.StartDate })
                    .HasName("ux_business_location_manager")
                    .IsUnique();

                entity.Property(e => e.BusinessLocationManagerId)
                    .HasColumnName("business_location_manager_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.BusinessLocationFk)
                    .HasColumnName("business_location _fk")
                    .HasComment("Foreign key to associated business location.");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("date")
                    .HasComment("The date the associated employee was removed from the position of manager at the associated business location. NOTE: obviously the field is nullable since an employee may be the current manager of a given location.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessEmployeeFk)
                    .HasColumnName("mobile_business_employee_fk")
                    .HasComment("Foriegn key to associated mobile bueinss employee who is thus identified as a manager.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("date")
                    .HasComment("The date the associated employee became the manager of the assocaited locations.");

                entity.HasOne(d => d.BusinessLocationFkNavigation)
                    .WithMany(p => p.BusinessLocationManager)
                    .HasForeignKey(d => d.BusinessLocationFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_business_location_manager_business_location");

                entity.HasOne(d => d.MobileBusinessEmployeeFkNavigation)
                    .WithMany(p => p.BusinessLocationManager)
                    .HasForeignKey(d => d.MobileBusinessEmployeeFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_business_location_manager_mobile_business_employee");
            });

            modelBuilder.Entity<BusinessLocationService>(entity =>
            {
                entity.ToTable("business_location_service");

                entity.HasComment("An intersection table between the business location and service tables. Usually this information is inferred from whicih mobile business employees are capable of which service. However, it is possible that a service is available at a location as such and employee qualification and availability are not serious questions or the service could be a class in which case we need this table to record class capacity.");

                entity.HasIndex(e => new { e.BusinessLocationFk, e.ProfessionalServiceFk })
                    .HasName("ux_business_location_service")
                    .IsUnique();

                entity.Property(e => e.BusinessLocationServiceId)
                    .HasColumnName("business_location_service_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.BusinessLocationFk)
                    .HasColumnName("business_location_fk")
                    .HasComment("Foreign key to associated business location.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.ProfessionalServiceFk)
                    .HasColumnName("professional_service_fk")
                    .HasComment("Foreign key to associated professional service.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ServiceCapacity)
                    .HasColumnName("service_capacity")
                    .HasComment("The capacity of the location to provide the associated service. For example, for a cooking class the maximum class size of the class is taught at the associate location.");

                entity.HasOne(d => d.BusinessLocationFkNavigation)
                    .WithMany(p => p.BusinessLocationService)
                    .HasForeignKey(d => d.BusinessLocationFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_business_location_service_business_location");

                entity.HasOne(d => d.ProfessionalServiceFkNavigation)
                    .WithMany(p => p.BusinessLocationService)
                    .HasForeignKey(d => d.ProfessionalServiceFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_business_location_service_service");
            });

            modelBuilder.Entity<BusinessLocationServiceBay>(entity =>
            {
                entity.ToTable("business_location_service_bay");

                entity.HasComment("For a given business location the set of servce bays / work spaces available for the provision of service. For example, a salon chair.");

                entity.HasIndex(e => new { e.BusinessLocationFk, e.ServiceBayLabel })
                    .HasName("ux_sub_location")
                    .IsUnique();

                entity.Property(e => e.BusinessLocationServiceBayId)
                    .HasColumnName("business_location_service_bay_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.AssignedEmployeeFk)
                    .HasColumnName("assigned_employee_fk")
                    .HasComment("Foreign key to mobile business employee assigned to this sub-location such as a barber's chair. NOTE: this field is nullable since a sub-location vertainly does not neccesarily have an assigned individual employee that covers it.");

                entity.Property(e => e.BusinessLocationFk)
                    .HasColumnName("business_location_fk")
                    .HasComment("Foreign key to parent business location.");

                entity.Property(e => e.Capacity)
                    .HasColumnName("capacity")
                    .HasComment("Where applicable the number f customers that canbe served there. One for a barber chair perhaps one hundred for a hotel conference room.");

                entity.Property(e => e.EndDt)
                    .HasColumnName("end_dt")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ServiceBayLabel)
                    .HasColumnName("service_bay_label")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("Text label for service bay such as chair 1 (for a barber) or table B (for a resturant).");

                entity.Property(e => e.StartDt)
                    .HasColumnName("start_dt")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("Date te work space came into service. NOTE: likely the date the business location came on line.");

                entity.HasOne(d => d.AssignedEmployeeFkNavigation)
                    .WithMany(p => p.BusinessLocationServiceBay)
                    .HasForeignKey(d => d.AssignedEmployeeFk)
                    .HasConstraintName("fk_sub_location_mobile_business_employee");

                entity.HasOne(d => d.BusinessLocationFkNavigation)
                    .WithMany(p => p.BusinessLocationServiceBay)
                    .HasForeignKey(d => d.BusinessLocationFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_business_sub_location_business_location");
            });

            modelBuilder.Entity<BusinessLocationServiceBayCalendar>(entity =>
            {
                entity.ToTable("business_location_service_bay_calendar");

                entity.HasComment("A work schedule / resource allocation schedule for a given business work space. NOTE: there are no utilization type and utilization quantity fields since, if you are reserving a work space, you are presumed to be reserving the whole thing.");

                entity.HasIndex(e => e.RetailCustomerFk)
                    .HasName("idx_business_location_work_space_calendar_retail_customer");

                entity.HasIndex(e => new { e.BusinessLocationServiceBayFk, e.AppointmentStartTimestamp })
                    .HasName("idx_business_location_work_space_calendar_work_space");

                entity.HasIndex(e => new { e.BusinessLocationServiceBayFk, e.RetailCustomerFk, e.AppointmentStartTimestamp })
                    .HasName("ux_business_location_work_space_calendar")
                    .IsUnique();

                entity.Property(e => e.BusinessLocationServiceBayCalendarId)
                    .HasColumnName("business_location_service_bay_calendar_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.AppointmentDate)
                    .HasColumnName("appointment_date")
                    .HasColumnType("date")
                    .HasComment("The date the appointment is set for.");

                entity.Property(e => e.AppointmentSetupTimestamp)
                    .HasColumnName("appointment_setup_timestamp")
                    .HasColumnType("datetime")
                    .HasComment("The moment the appointment was set - the time the associated work space was reserved for the associated retail customer.");

                entity.Property(e => e.AppointmentStartTimestamp)
                    .HasColumnName("appointment_start_timestamp")
                    .HasColumnType("datetime")
                    .HasComment("Moment the retail customer is to begin receiving their service, such as a hair cut.");

                entity.Property(e => e.AppointmentStatus)
                    .HasColumnName("appointment_status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("'S' mean scheduled\\n'C' means cancelled\\n'R' means rescheduled\\n'F' fulfillment complete");

                entity.Property(e => e.AppointmentTime)
                    .HasColumnName("appointment_time")
                    .HasComment("The number of minutes after midnight, grenage time, that the appointment is set for.");

                entity.Property(e => e.BusinessLocationServiceBayFk)
                    .HasColumnName("business_location_service_bay_fk")
                    .HasComment("Foreign key to parent business location work space.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RetailCustomerFk)
                    .HasColumnName("retail_customer_fk")
                    .HasComment("Foreign key to the retail customer who has reserved the associated business sub location.");

                entity.Property(e => e.ScheduledDurationOfServiceInMinutes)
                    .HasColumnName("scheduled_duration_of_service_in_minutes")
                    .HasComment("The number of minutes reatil customer is to use this sub-location - either in whoe or in part.");

                entity.HasOne(d => d.BusinessLocationServiceBayFkNavigation)
                    .WithMany(p => p.BusinessLocationServiceBayCalendar)
                    .HasForeignKey(d => d.BusinessLocationServiceBayFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_business_sub_location_calendar_sub_location");

                entity.HasOne(d => d.RetailCustomerFkNavigation)
                    .WithMany(p => p.BusinessLocationServiceBayCalendar)
                    .HasForeignKey(d => d.RetailCustomerFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_business_location_calendar_retail_customer_0");
            });

            modelBuilder.Entity<BusinessLocationServiceBayService>(entity =>
            {
                entity.ToTable("business_location_service_bay_service");

                entity.HasComment("An intersection table between the business locationwork space and service tables. The existence of a record indicates that the given service can be performed at the given business location work space. NOTE: this is not a given. For example, at a salon one chair may lean all the way back and have a sink in position for washing hair, whereas most of the chairs do not.");

                entity.HasIndex(e => new { e.BusinessLocationServiceBayFk, e.ProfessionalServiceFk })
                    .HasName("ux_businss_location_work_space_service")
                    .IsUnique();

                entity.Property(e => e.BusinessLocationServiceBayServiceId)
                    .HasColumnName("business_location_service_bay_service_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.BusinessLocationServiceBayFk)
                    .HasColumnName("business_location_service_bay_fk")
                    .HasComment("Foreign key to parent service bay.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.ProfessionalServiceFk)
                    .HasColumnName("professional_service_fk")
                    .HasComment("Foreign key to associated professional service.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.BusinessLocationServiceBayFkNavigation)
                    .WithMany(p => p.BusinessLocationServiceBayService)
                    .HasForeignKey(d => d.BusinessLocationServiceBayFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_businss_location_work_space_service_work_space");

                entity.HasOne(d => d.ProfessionalServiceFkNavigation)
                    .WithMany(p => p.BusinessLocationServiceBayService)
                    .HasForeignKey(d => d.ProfessionalServiceFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_businss_location_work_space_service");
            });

            modelBuilder.Entity<BusinessLocationStaff>(entity =>
            {
                entity.ToTable("business_location_staff");

                entity.HasComment("An intersection between the business location and mobile business employee tables. The existence of a record indicates that the associated mobile business employee works at the associated business lcoation. This is important because we may wish to grant managers of locations access to data that would not be visible to managers of other locations. NOTE: this represents data for rather permanent location assignments that are not affected by the normal bsuiness operation of setting the work schedule. If setting a location is part of setting a schedule that is handled in a different table.");

                entity.HasIndex(e => new { e.BusinessLocationFk, e.MobileBusinessEmployeeFk })
                    .HasName("ux_business_location_staff")
                    .IsUnique();

                entity.Property(e => e.BusinessLocationStaffId)
                    .HasColumnName("business_location_staff_id")
                    .HasComment("System generated surrogate primry key.");

                entity.Property(e => e.BusinessLocationFk)
                    .HasColumnName("business_location_fk")
                    .HasComment("Forein key to parent business lcation.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.LocationStatus)
                    .IsRequired()
                    .HasColumnName("location_status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("'L' mean line worker\\n'M' means manager\\nNOTE: managers are permitted access to employee data, but not the other way aroud; and, managers can not view data concerning each others employees.");

                entity.Property(e => e.MobileBusinessEmployeeFk)
                    .HasColumnName("mobile_business_employee_fk")
                    .HasComment("Foreign key to associated mobile business employee who works at the associated business lcoation.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.BusinessLocationFkNavigation)
                    .WithMany(p => p.BusinessLocationStaff)
                    .HasForeignKey(d => d.BusinessLocationFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_business_location_staff_business_location");

                entity.HasOne(d => d.MobileBusinessEmployeeFkNavigation)
                    .WithMany(p => p.BusinessLocationStaff)
                    .HasForeignKey(d => d.MobileBusinessEmployeeFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_business_location_staff_mobile_business_employee");
            });

            modelBuilder.Entity<BusinessOrganization>(entity =>
            {
                entity.ToTable("business_organization");

                entity.HasComment("Organization represents SMBs and non-profit. NOTE: organization is a reserved word in MySQL. NOTE 2: this table does not have a niqueness constraint because its uniqueness comes from it's hierarchical parent party.");

                entity.HasIndex(e => e.OrganizationName)
                    .HasName("ux_organization")
                    .IsUnique();

                entity.Property(e => e.BusinessOrganizationId)
                    .HasColumnName("business_organization_id")
                    .HasComment("Primary Key for Organization Table")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dba)
                    .HasColumnName("DBA")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("Doing Business As");

                entity.Property(e => e.Ein)
                    .HasColumnName("EIN")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("Employer Identification Number");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.NonProfitFlag)
                    .IsRequired()
                    .HasColumnName("non_profit_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')")
                    .HasComment("Non profit indicator - 'Y' mean yes, 'N' means no.");

                entity.Property(e => e.OrganizationName)
                    .HasColumnName("organization_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Full human readable name of organization. NOTE: must be unique.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.BusinessOrganizationNavigation)
                    .WithOne(p => p.BusinessOrganization)
                    .HasForeignKey<BusinessOrganization>(d => d.BusinessOrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_organization_party");
            });

            modelBuilder.Entity<BusinessPopUpLocation>(entity =>
            {
                entity.ToTable("business_pop_up_location");

                entity.HasComment("A mobile location, such as a food truck, which a business operates at or out of.");

                entity.HasIndex(e => new { e.BusinessPopUpLocationId, e.DynamicLatitude, e.DynamicLongitude, e.StartTimestamp })
                    .HasName("ux_business_pop_up_location")
                    .IsUnique();

                entity.Property(e => e.BusinessPopUpLocationId)
                    .HasColumnName("business_pop_up_location_id")
                    .HasComment("System generated surrogate primary key - and a foreign key to he parent business location.")
                    .ValueGeneratedNever();

                entity.Property(e => e.DynamicLatitude)
                    .HasColumnName("dynamic_latitude")
                    .HasColumnType("decimal(9, 6)")
                    .HasComment("Transient business location latitude.");

                entity.Property(e => e.DynamicLongitude)
                    .HasColumnName("dynamic_longitude")
                    .HasColumnType("decimal(9, 6)")
                    .HasComment("Transient business location longitude.");

                entity.Property(e => e.EndTimestamp)
                    .HasColumnName("end_timestamp")
                    .HasColumnType("datetime")
                    .HasComment("Moment the mobile business stopped operating from this dynamic location.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foreign key to parent business location.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.StartTimestamp)
                    .HasColumnName("start_timestamp")
                    .HasColumnType("datetime")
                    .HasComment("Moment the mobile business starting operating from this dynamic location.");

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.BusinessPopUpLocation)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_business_pop_up_location_bsuiness_location");
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.ToTable("cart");

                entity.HasComment("This table represents the items selected, tax and shipping costs for the product.\\n");

                entity.HasIndex(e => new { e.MobileBusinessFk, e.RetailCustomerFk, e.StartTimestamp })
                    .HasName("ux_cart")
                    .IsUnique();

                entity.Property(e => e.CartId)
                    .HasColumnName("cart_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.BusinessLocationFk)
                    .HasColumnName("business_location_fk")
                    .HasComment("Foreign key to mobile business retail location (vs a warehouse). NOTE: tis field is nullable since some mobile business' don't even have retail locations. NOTE2: in the event that this order is to be picked up this field means the location that has been specified as the desired retail business location.");

                entity.Property(e => e.CartStatusIndicator)
                    .IsRequired()
                    .HasColumnName("cart_status_indicator")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("A code to indicate the status of a cart. Legal values:\\n\\n'E' - Empty\\n'S' - Shopping\\n'A' - Abandoned\\n'O' - Checked out\\n'P' - Partially Shipped\\n'D' - Fully Shipped");

                entity.Property(e => e.CharitibleContribution)
                    .HasColumnName("charitible_contribution")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("Dollar amount retail customer is contributing to charity.");

                entity.Property(e => e.FreightCharge)
                    .HasColumnName("freight_charge")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("The dollar amount the customer is to pay for freight.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MeetupPlaceFk)
                    .HasColumnName("meetup_place_fk")
                    .HasComment("The place the customer and mobile business service provider have agreed to meetup for the customer to receive the service. NOTE: this is commonly the customer address as, for example, in the case of one or another kind of home repair.");

                entity.Property(e => e.MeetupTime)
                    .HasColumnName("meetup_time")
                    .HasColumnType("datetime")
                    .HasComment("A time the mobile business service provider or delivery person and the customer have agreed to meet up, whether on-line or in-person.");

                entity.Property(e => e.MerchandiseTotal)
                    .HasColumnName("merchandise_total")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("The total amonut due from the customer for the selected products (goods and services).");

                entity.Property(e => e.MobileBusinessCharityMatch)
                    .HasColumnName("mobile_business_charity_match")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("The amounf of money the mobile business is contributing to charity. NOTE: in principal this can be a sum since a retail customer can contribute to more than one charity as part of closing out a cart.");

                entity.Property(e => e.MobileBusinessEmployeeFk)
                    .HasColumnName("mobile_business_employee_fk")
                    .HasComment("Foreign key to mobile business employee who helped the customer. This mobile business employee may receive comissions.");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foreign key to assocaited mobile business.");

                entity.Property(e => e.PlatformCharityMatch)
                    .HasColumnName("platform_charity_match")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("The amount of money we are contributing to charity. NOTE: in principal this can be a sum since a retail customer can contribute to more than one charity as part of closing out a cart.");

                entity.Property(e => e.PurchaseModeIndicator)
                    .HasColumnName("purchase_mode_indicator")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("'P' means pick up \\n'D' means delivery\\n'S' means ship\\nNOTE: this is important for payments since a cart when closed out requires pimmediatee payment (or at least terms) for pick up and delivered items like pet snakes and pizzas; but settlement for items to be shipped only takes place upon shipment - before then we only reserve room on creedit cards our our own gift card \"accounts\".");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RetailCustomerFk)
                    .HasColumnName("retail_customer_fk")
                    .HasComment("Foreign key to the retail customer pushing this cart around.");

                entity.Property(e => e.ShippingAddressFk)
                    .HasColumnName("shipping_address_fk")
                    .HasComment("Foreign key to shipping address for thisd order for cases where the order is for goods that are to be shipped.");

                entity.Property(e => e.SpecifiedShippingMethod)
                    .HasColumnName("specified_shipping_method")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("The customers instruction about how to ship, especially how fast and thus how expensive.");

                entity.Property(e => e.StartTimestamp)
                    .HasColumnName("start_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("When the cart was pulled from the rack of carts (metaphorically); when the retail customer started the process of filling their cart.");

                entity.Property(e => e.Tax)
                    .HasColumnName("tax")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("The dollar amount of tax owed on the items in the cart.");

                entity.Property(e => e.TotalAmountDue)
                    .HasColumnName("total_amount_due")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("Sum of all goods and services in the cart plus applicable freight charges and taxes. NOTE: this field is nullable since when a cart is created we do not know the total amount due.");

                entity.Property(e => e.TotalDiscountAmount)
                    .HasColumnName("total_discount_amount")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("The sum of all the discounts from all the applicable trusted trade prompts as against the standard brick and mortar prices.");

                entity.HasOne(d => d.BusinessLocationFkNavigation)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.BusinessLocationFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cart_business_location");

                entity.HasOne(d => d.MeetupPlaceFkNavigation)
                    .WithMany(p => p.CartMeetupPlaceFkNavigation)
                    .HasForeignKey(d => d.MeetupPlaceFk)
                    .HasConstraintName("Fk_cartpost_office_address");

                entity.HasOne(d => d.MobileBusinessEmployeeFkNavigation)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.MobileBusinessEmployeeFk)
                    .HasConstraintName("Fk_cart_mobile_business_employee");

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .HasConstraintName("fk_cart_mobile_business");

                entity.HasOne(d => d.RetailCustomerFkNavigation)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.RetailCustomerFk)
                    .HasConstraintName("fk_cart_retail_customer");

                entity.HasOne(d => d.ShippingAddressFkNavigation)
                    .WithMany(p => p.CartShippingAddressFkNavigation)
                    .HasForeignKey(d => d.ShippingAddressFk)
                    .HasConstraintName("Fk_cart_shipping_address_fk");
            });

            modelBuilder.Entity<CartAccountReceivable>(entity =>
            {
                entity.ToTable("cart_account_receivable");

                entity.HasComment("For a given cart total due, the settlement of that amounts due might be delayed. It may be that we offered and the retail customer accepted terms, such as 90 days same as cash. In such a case we would put a row in this table to detail that separate follow on agreement. The cart itself would not see normal immediate settlement, but this would not be alarming in the context of a valid row over here in the cart account receiveable table. NOTE: amounts due pursuant to terms per cart should be combined into a single invoice for the retail customer's convenience.");

                entity.Property(e => e.CartAccountReceivableId)
                    .HasColumnName("cart_account_receivable_id")
                    .HasComment("System generated surrogate primry key.");

                entity.Property(e => e.CartFk)
                    .HasColumnName("cart_fk")
                    .HasComment("Foreign key to parent closed out cart. NOTE: the cart must be closed out but not overwise settled.");

                entity.Property(e => e.FinalPaymentAmount)
                    .HasColumnName("final_payment_amount")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("The final payment_amount for the nth payment of the terms. NOTE: this is a separate field for rounding: $33.33 + #33.33 + $33.34; that kind of thing. NOTE 2: it is perfectly acceptible of rthe final payment to be equal to all prior payments.");

                entity.Property(e => e.GeneralPaymentAmount)
                    .HasColumnName("general_payment_amount")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("The general payment amount for the first n payments of the terms.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TermBeginTimePeriod)
                    .HasColumnName("term_begin_time_period")
                    .HasColumnType("date")
                    .HasComment("The day the terms start - that is, basically the date the cart was closed out.");

                entity.Property(e => e.TermNumberOfPayments)
                    .HasColumnName("term_number_of_payments")
                    .HasComment("The number of payments that areto be remitted prusuant to the agreed terms for this invoice.");

                entity.HasOne(d => d.CartFkNavigation)
                    .WithMany(p => p.CartAccountReceivable)
                    .HasForeignKey(d => d.CartFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cart_account_receivable_cart");
            });

            modelBuilder.Entity<CartCheckOutCharity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cart_check_out_charity");

                entity.HasComment("An intersection between the cart and charity tables. The existence of a record indicates that the associated charity appeared as an option at check time for the assocaited cart. NOTE: if the retail customer selects a charity and makes a contribution then this is also the table where that gets recorded.");

                entity.Property(e => e.AmountOfCharitibleContribution)
                    .HasColumnName("amount_of_charitible_contribution")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("The dollar amount of the retail customers charitible contribution. NOTE\" this may be indicated directly in this field, or this field may be derived from the portion of the cart total the retail customer indicated they wanted to contribute.");

                entity.Property(e => e.CartCheckOutCharityId)
                    .HasColumnName("cart_check_out_charity_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.CartFk)
                    .HasColumnName("cart_fk")
                    .HasComment("Foreign key to associated cart.");

                entity.Property(e => e.CharityFk)
                    .HasColumnName("charity_fk")
                    .HasComment("Foreign key to associated charity.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessMatchAmount)
                    .HasColumnName("mobile_business_match_amount")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("The dollar amount of the mobile business' match on the contribution. NOTE: this will reflect the match specification in force at the time and may not match the current match ratio specification.");

                entity.Property(e => e.PlatformMatchAmount)
                    .HasColumnName("platform_match_amount")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("The dollar amount of platform match on the contribution. NOTE: this will reflect the match specification in force at the time and may not match the current match ratio specification.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SpecifiedRatioOfCartTotal)
                    .HasColumnName("specified_ratio_of_cart_total")
                    .HasColumnType("decimal(5, 4)")
                    .HasComment("The portion of the cart total specified as a charitible contribution, scu as 0.01 maning 1%.");

                entity.HasOne(d => d.CartFkNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CartFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cart_check_out_charity_cart");

                entity.HasOne(d => d.CharityFkNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CharityFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cart_check_out_charity_charity");
            });

            modelBuilder.Entity<CartPayment>(entity =>
            {
                entity.HasKey(e => e.CartParmentId)
                    .HasName("Pk_cart_parment_cart_parment_id");

                entity.ToTable("cart_payment");

                entity.HasComment("A record of how the cart was settled. For example, a credit card or ACH payment. THis table points to the cart, the credit card or bank account and holds data on the settling payment such as which batch the payment was processed on.");

                entity.Property(e => e.CartParmentId)
                    .HasColumnName("cart_parment_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.CartFk)
                    .HasColumnName("cart_fk")
                    .HasComment("FOreign key to associated cart.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.PaidFromPrepaidCardFlag)
                    .IsRequired()
                    .HasColumnName("paid_from_prepaid_card_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')")
                    .HasComment("The retail customer only has one so a flag is enough to say where the money came from.");

                entity.Property(e => e.PartyBankAccountFk)
                    .HasColumnName("party_bank_account_fk")
                    .HasComment("FOreign key to bank account used (via ACH) to settle the cart.");

                entity.Property(e => e.PartySavedCreditCardFk)
                    .HasColumnName("party_saved_credit_card_fk")
                    .HasComment("Foreign key to saved credit card used to settle the cart  charges.");

                entity.Property(e => e.PaymentAmount)
                    .HasColumnName("payment_amount")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("The dollar amount of the payment. This should really match the cart - merchadise total+ freight + tax.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TemporaryCreditCardNumber)
                    .HasColumnName("temporary_credit_card_number")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Credit card number used to settle the cart - saved temporarily just to settle the charges an d then erased");

                entity.Property(e => e.TemporaryExpirationDate)
                    .HasColumnName("temporary_expiration_date")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("The exiration month and year on the credit card - only held temporarily while the card is being processed to settle the associated cart.");

                entity.Property(e => e.TemporarySecurityCode)
                    .HasColumnName("temporary_security_code")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("The 3 or 4 digit code on the back of a credit card - held only temporarily while the payment is being processed.");

                entity.Property(e => e.TemporaryZipCode)
                    .HasColumnName("temporary_zip_code")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasComment("Zip code of mailing address on temporary credit card.");

                entity.HasOne(d => d.CartFkNavigation)
                    .WithMany(p => p.CartPayment)
                    .HasForeignKey(d => d.CartFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_cart_payment_cart");

                entity.HasOne(d => d.PartyBankAccountFkNavigation)
                    .WithMany(p => p.CartPayment)
                    .HasForeignKey(d => d.PartyBankAccountFk)
                    .HasConstraintName("Fk_cart_payment_party_bank_account");

                entity.HasOne(d => d.PartySavedCreditCardFkNavigation)
                    .WithMany(p => p.CartPayment)
                    .HasForeignKey(d => d.PartySavedCreditCardFk)
                    .HasConstraintName("Fk_cart_payment_party_saved_credit_card");
            });

            modelBuilder.Entity<CartPointsAwarded>(entity =>
            {
                entity.ToTable("cart_points_awarded");

                entity.HasComment("For a given cart the points awarded in any applicable virtue. NOTE: this table is derived upon closing out the cart so that the correct number of points are awarded at that time and so that subsequent changes in the virtue points for products do not affect past amount of points accrued on carts.");

                entity.HasIndex(e => new { e.CartFk, e.VirtueFk })
                    .HasName("Idx_cart_points_awarded")
                    .IsUnique();

                entity.Property(e => e.CartPointsAwardedId)
                    .HasColumnName("cart_points_awarded_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.CartFk)
                    .HasColumnName("cart_fk")
                    .HasComment("Foreign key to parent cart.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.PointsAwarded)
                    .HasColumnName("points_awarded")
                    .HasComment("The number f points awarded to the retail customer when they paid for the parent cart.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.VirtueFk)
                    .HasColumnName("virtue_fk")
                    .HasComment("Foreign key to associated virtue.");

                entity.HasOne(d => d.CartFkNavigation)
                    .WithMany(p => p.CartPointsAwarded)
                    .HasForeignKey(d => d.CartFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_cart_points_awarded_cart");

                entity.HasOne(d => d.VirtueFkNavigation)
                    .WithMany(p => p.CartPointsAwarded)
                    .HasForeignKey(d => d.VirtueFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_cart_points_awarded_virtue");
            });

            modelBuilder.Entity<CartProduct>(entity =>
            {
                entity.ToTable("cart_product");

                entity.HasComment("The items that are in a shopping cart. NOTE: a cart is for a given customer and a given mobile business and holds the set of items from the mobile business' catalog and associated qualities, which the customer has selected for purchase.");

                entity.HasIndex(e => new { e.CartFk, e.ProductFk, e.CustomizationSequenceNumber })
                    .HasName("ux_cart_item")
                    .IsUnique();

                entity.Property(e => e.CartProductId)
                    .HasColumnName("cart_product_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.CartFk)
                    .HasColumnName("cart_fk")
                    .HasComment("Foreignkey to parent cart.");

                entity.Property(e => e.CustomizationSequenceNumber)
                    .HasColumnName("customization_sequence_number")
                    .HasComment("For a cart with three occurrences of the exact same product entered three times to make room for three different sets of customization, this field identifies thesq three items so that cart item can still have a proper uniqueness constraint on the table.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.OfferTag)
                    .HasColumnName("offer_tag")
                    .HasComment("In general the ODS database does not concern itself with the data that underlies discounts and promotions. The ODS just naively accepts cart items at prices specified by the smart phone App and assumes that App knows what it is doing. However, the analytics DB does need to be told when offers were used and by whom so as to guide adjusts to the offer and the generation of new offers. To that end the smart phone App send a tag along with cart items that were sold pursuant to any offer and the ODS database send along that tag to the analytics database. In this way the ODS database can remain almost entirely unconcerned about discounts and promotions, but the analytics can get the data it needs to perform it's duties. NOTE: obviously the field is nullable since a product can be purchased not pursuant to any offer.");

                entity.Property(e => e.OrderQuantity)
                    .HasColumnName("order_quantity")
                    .HasComment("Number of items  ordered.");

                entity.Property(e => e.PickupOrShipIndication)
                    .HasColumnName("pickup_or_ship_indication")
                    .HasComment("'P' means this cart's products are to be picked up at the store\\n'S' means this cart's products are to be p=shippied to a specified address : the address on file for the customer in the normal case, or a special address for the case where I buy something for my daughter\\nNOTE: this is an over-ride indicator as against a more general use of the same fiield name in the cart.");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("Unit price for the associated item on the associated cart. This price for the catalog item that applies on this cart given all applicable discounts.");

                entity.Property(e => e.ProductFk)
                    .HasColumnName("product_fk")
                    .HasComment("Foreign key to item from the product catalog which has been selected for purchase.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SpecificationDetails)
                    .HasColumnName("specification_details")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("Comma delimited list of specifications such as color and size.");

                entity.HasOne(d => d.CartFkNavigation)
                    .WithMany(p => p.CartProduct)
                    .HasForeignKey(d => d.CartFk)
                    .HasConstraintName("fk_cart_content_cart");

                entity.HasOne(d => d.ProductFkNavigation)
                    .WithMany(p => p.CartProduct)
                    .HasForeignKey(d => d.ProductFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cart_item_product");
            });

            modelBuilder.Entity<CartProductCustomization>(entity =>
            {
                entity.ToTable("cart_product_customization");

                entity.HasComment("For a given ordered product that is subject to customization., a specification as to a dimension of customization. NOTE: if you want 3 versions of a product with 3 different customizations you must put it in the cart 3 times. NOTE 2: There are cases where customization are not pick from a list - thus, the subsequent fields for text and graphic are available to allow for those cases.");

                entity.HasIndex(e => new { e.CartProductFk, e.DimensionOfCustomizationFk })
                    .HasName("ux_cart_item_customization")
                    .IsUnique();

                entity.Property(e => e.CartProductCustomizationId)
                    .HasColumnName("cart_product_customization_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.CartProductFk)
                    .HasColumnName("cart_product_fk")
                    .HasComment("Foreign key to parent cart item.");

                entity.Property(e => e.CustomGraphic)
                    .HasColumnName("custom_graphic")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("A custom graphic to put on a product such as a corporate ologo on a kite.");

                entity.Property(e => e.CustomText)
                    .HasColumnName("custom_text")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("Customer text to put on the product such as a monogramed dress shirt.");

                entity.Property(e => e.DimensionOfCustomizationFk)
                    .HasColumnName("dimension_of_customization_fk")
                    .HasComment("Foreign key to associated dimension of customerization.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.ProductDimensionValueFk)
                    .HasColumnName("product_dimension_value_fk")
                    .HasComment("Foreign key to associated dimension value. That is, the option selected from among the set for that dimension. For example, if the dimension is color you might pick Red as apposed to blue or green.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CartProductFkNavigation)
                    .WithMany(p => p.CartProductCustomization)
                    .HasForeignKey(d => d.CartProductFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cart_item_customization_cart_item");
            });

            modelBuilder.Entity<CartProductServiceDetail>(entity =>
            {
                entity.ToTable("cart_product_service_detail");

                entity.HasComment("For a given cart for a product on the cart which is a service, perhaps pursuant to a deal on the cart; this table holds the details such as the location that the service will be performed - like which retail location or what retail customer specified address; as well at the service start time.");

                entity.HasIndex(e => e.CartProductFk)
                    .HasName("ux_cart_product_service_detail")
                    .IsUnique();

                entity.Property(e => e.CartProductServiceDetailId)
                    .HasColumnName("cart_product_service_detail_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.AppointmentDate)
                    .HasColumnName("appointment_date")
                    .HasColumnType("date")
                    .HasComment("The calendar date of the appointment.");

                entity.Property(e => e.AppointmentStartTime)
                    .HasColumnName("appointment_start_time")
                    .HasComment("The number of minutes after midnight the service is to begin.");

                entity.Property(e => e.BusinessLocationFk)
                    .HasColumnName("business_location_fk")
                    .HasComment("Foreign key to business location at which the service is to take place (for services to be performed at brick and motar locations). NOTE: nullable since a service may be such that it is perfromed at an address specified by the retail customer.");

                entity.Property(e => e.CartProductFk)
                    .HasColumnName("cart_product_fk")
                    .HasComment("Foreign key to parent cart product.");

                entity.Property(e => e.CartTrustedTradePromptFk)
                    .HasColumnName("cart_trusted_trade_prompt_fk")
                    .HasComment("Foreign key to cart deal to which this service is tied. NOTE: nullable since a product does not, strinctly, need to be assocaited with a deal to be in a cart.");

                entity.Property(e => e.ExpectedDurationInMinutes)
                    .HasColumnName("expected_duration_in_minutes")
                    .HasComment("The expected service duration in minutes for this servbice. NOTE: this field is held at the professional service level, so this field constitutes an opportunity to specify an over-ride - a special duration either shorter or longer.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ServiceAddressFk)
                    .HasColumnName("service_address_fk")
                    .HasComment("Foreign key to the post office address where the service is to be performed. NOTE: this isobviously for services that are to be performed at retail customer specified sites (probably their residences). NOTE2: this feld is nullable since many services are to be performed at the business location - brick and mortar site.");

                entity.HasOne(d => d.BusinessLocationFkNavigation)
                    .WithMany(p => p.CartProductServiceDetail)
                    .HasForeignKey(d => d.BusinessLocationFk)
                    .HasConstraintName("fk_cart_product_service_detail_business_location");

                entity.HasOne(d => d.CartProductFkNavigation)
                    .WithOne(p => p.CartProductServiceDetail)
                    .HasForeignKey<CartProductServiceDetail>(d => d.CartProductFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cart_product_service_detail_cart_product");

                entity.HasOne(d => d.CartTrustedTradePromptFkNavigation)
                    .WithMany(p => p.CartProductServiceDetail)
                    .HasForeignKey(d => d.CartTrustedTradePromptFk)
                    .HasConstraintName("fk_cart_product_service_detail_cart_trusted_trade_prompt");

                entity.HasOne(d => d.ServiceAddressFkNavigation)
                    .WithMany(p => p.CartProductServiceDetail)
                    .HasForeignKey(d => d.ServiceAddressFk)
                    .HasConstraintName("fk_cart_product_service_detail_post_office_address");
            });

            modelBuilder.Entity<CartTrustedTradePrompt>(entity =>
            {
                entity.ToTable("cart_trusted_trade_prompt");

                entity.HasComment("An intersection between the cart and trusted trade prompt tables. The existence of a record indicates that the associated 1 or more titems in the cart appeared there due to selected as prompted by one or another trusted tradade prompt.  Thus, the price is likely discounted on one or more items in the cart  as driven by the details of the relevant trusted trade prompt.");

                entity.Property(e => e.CartTrustedTradePromptId)
                    .HasColumnName("cart_trusted_trade_prompt_id")
                    .HasComment("Sytem generated surrogate primary key.");

                entity.Property(e => e.CartFk)
                    .HasColumnName("cart_fk")
                    .HasComment("Foriegn key to parent cart.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.OrderQuantity)
                    .HasColumnName("order_quantity")
                    .HasDefaultValueSql("((1))")
                    .HasComment("The number of products the retail customer wants, like just one or the deal times 3 - 3 times the stuff 3 times the price.");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasComment("Dollar to pay per each instance of they deal - they may want more than 1.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TotalDiscount)
                    .HasColumnName("total_discount")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("The toal amount of discount on the set of items in the cart to which the offer applies. That is, the total discount against the otherwise applicable price(s).");

                entity.Property(e => e.TrustedTradePromptFk)
                    .HasColumnName("trusted_trade_prompt_fk")
                    .HasComment("Foreign key to applicable trusted trade prompt.");

                entity.HasOne(d => d.CartFkNavigation)
                    .WithMany(p => p.CartTrustedTradePrompt)
                    .HasForeignKey(d => d.CartFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cart_trusted_trade_prompt_cart");

                entity.HasOne(d => d.TrustedTradePromptFkNavigation)
                    .WithMany(p => p.CartTrustedTradePrompt)
                    .HasForeignKey(d => d.TrustedTradePromptFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cart_trusted_trade_prompt_trusted_trade_prompt");
            });

            modelBuilder.Entity<Charity>(entity =>
            {
                entity.ToTable("charity");

                entity.HasComment("A charitable cause supported by one or more mobile businesses. NOTE: this table does not have a separate uniqueness constaint because it inherits it's uniqueness from the organization table.");

                entity.HasIndex(e => e.TradeName)
                    .HasName("ux_charity")
                    .IsUnique();

                entity.Property(e => e.CharityId)
                    .HasColumnName("charity_id")
                    .HasComment("System generated surrogate primary key - and foreign key to an orgnization.")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccountNumber)
                    .HasColumnName("account_number")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasComment("Bank account number");

                entity.Property(e => e.GraphicIcon)
                    .HasColumnName("graphic_icon")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Displayable symbol for the charity.");

                entity.Property(e => e.InceptionToDateReceipts)
                    .HasColumnName("inception_to_date_receipts")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("Money received from mobile businesses in the platform since the charity began participation.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.PlatformMatchMaxPortionOfCartTotal)
                    .HasColumnName("platform_match_max_portion_of_cart_total")
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("The maximum we will contribute as a portion of the cart total. Otherwise a retail customer could spend $1 dollar contribute $500 and get mathcing funds for his charitible contribution - clever but we must block that.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RoutingNumber)
                    .HasColumnName("routing_number")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComment("Bank routing number,");

                entity.Property(e => e.SpecifiedPlatformMatchRatio)
                    .HasColumnName("specified_platform_match_ratio")
                    .HasColumnType("decimal(5, 4)")
                    .HasComment("The portion of the customer contribution that we will match in the event of a retail customer contribution. For example 0.50 would indicate that we would match 50 cents on the dollar and 1 would indicate we will match retail customer contributions dollar for dollar.");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("date")
                    .HasComment("Date the charity began participation on the platform.");

                entity.Property(e => e.TradeName)
                    .IsRequired()
                    .HasColumnName("trade_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Human readable name of the charity.");

                entity.HasOne(d => d.CharityNavigation)
                    .WithOne(p => p.Charity)
                    .HasForeignKey<Charity>(d => d.CharityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_charity_organization");
            });

            modelBuilder.Entity<CleansedAddress>(entity =>
            {
                entity.ToTable("cleansed_address");

                entity.HasComment("A cleansed version of one or another provided post office addess.");

                entity.HasIndex(e => new { e.StreetNumber, e.StreetPreDirection, e.StreetName, e.StreetPostDirection, e.StreetType, e.AddressLine2, e.ZipCode })
                    .HasName("idx_cleansed_address")
                    .IsUnique();

                entity.Property(e => e.CleansedAddressId)
                    .HasColumnName("cleansed_address_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.AddressLine2)
                    .HasColumnName("address_line2")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Suite 200 in 500 East Harbor, suite 200.");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasComment("City as in Arlington Virgnia or Texas.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.PostOfficeAddressFk)
                    .HasColumnName("post_office_address_fk")
                    .HasComment("Foreign key to poast office address.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.StatePostalCode)
                    .HasColumnName("state_postal_code")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Standrd state code as in CA for Cailfornia o T for Texas.");

                entity.Property(e => e.StreetName)
                    .HasColumnName("street_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Main as in 1000 n main street.");

                entity.Property(e => e.StreetNumber)
                    .HasColumnName("street_number")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComment("Physical address number like 100 in 1000 main street.");

                entity.Property(e => e.StreetPostDirection)
                    .HasColumnName("street_post_direction")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("A direction like East as in 500 north Harbor blvd East.");

                entity.Property(e => e.StreetPreDirection)
                    .HasColumnName("street_pre_direction")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("The prefix of the street name. For example, N or North for 1000 north main street.");

                entity.Property(e => e.StreetType)
                    .HasColumnName("street_type")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComment("BLVD in 500 north Harbor blvd East");

                entity.Property(e => e.ZipCode)
                    .HasColumnName("zip_code")
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("postal delivery area like 75007. Fully qualified as 5+4+2");

                entity.HasOne(d => d.PostOfficeAddressFkNavigation)
                    .WithMany(p => p.CleansedAddress)
                    .HasForeignKey(d => d.PostOfficeAddressFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cleansed_address_provided_address");
            });

            modelBuilder.Entity<ContactMechanism>(entity =>
            {
                entity.ToTable("contact_mechanism");

                entity.HasComment("An abstract class to be instantiated as a tablet or email or someting. NOTE: this table does not have a uniqueness constraint / business key because it is, in effect an abstract class.");

                entity.Property(e => e.ContactMechanismId)
                    .HasColumnName("contact_mechanism_id")
                    .HasComment("System generated surrogate key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Uuid)
                    .IsRequired()
                    .HasColumnName("uuid")
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Universally unique identifier. THis is needed so that on an insert you can read the row back and get the new auto-increment key. That may sound ike a non-problem, but ... we must consider concurrency.");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("country");

                entity.HasComment("The countries of the Earth.");

                entity.HasIndex(e => e.CountryName)
                    .HasName("ux_country")
                    .IsUnique();

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasColumnName("country_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Human readable name of country.");

                entity.Property(e => e.LastUpdateTimeStamp)
                    .HasColumnName("last_update_time_stamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.PostalAbbreviation)
                    .IsRequired()
                    .HasColumnName("postal_abbreviation")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasComment("Abbreviuation as used on international mail, such as USA.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Device>(entity =>
            {
                entity.ToTable("device");

                entity.HasComment("A device such as a phone or a tablet that facilitates communication.");

                entity.HasIndex(e => e.SerialNumber)
                    .HasName("ux_device")
                    .IsUnique();

                entity.Property(e => e.DeviceId)
                    .HasColumnName("device_id")
                    .HasComment("System generated surrogate primary key - and a foriegn key to the arent contact mechanism.")
                    .ValueGeneratedNever();

                entity.Property(e => e.DeviceType)
                    .HasColumnName("device_type")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("Also called idium. For example, phone, tablet, desktop");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("manufacturer")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("The name of the device manufacturer like Apple for an I-phone");

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("Model of the device like an 'LG' smart phone");

                entity.Property(e => e.ModelNumber)
                    .HasColumnName("model_number")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComment("Sub-type on the model like an I-phone \"9\"");

                entity.Property(e => e.Os)
                    .HasColumnName("os")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("The operating system the device is running.");

                entity.Property(e => e.OsVersion)
                    .HasColumnName("os_version")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComment("The version of the operating system the device is running such as on a desktop windows \"10\".");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SerialNumber)
                    .HasColumnName("serial_number")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("A low level ID for the device.");

                entity.HasOne(d => d.DeviceNavigation)
                    .WithOne(p => p.Device)
                    .HasForeignKey<Device>(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_device_contact_mechanism");
            });

            modelBuilder.Entity<Dimension>(entity =>
            {
                entity.ToTable("dimension");

                entity.HasComment("Selection details for a given product. For example, on the Eiffle tower hoody dimension color and dimension size. NOTE: there are two dimension source tables to account for dimension coming from manufacturers or from mbile businesses. However, it should be noted that a dimension can have no row in either table and thus \"no source\" - no row in either table means that the dimension is universal such as t-shirt sizes s, m, l, xl, xxl, and xxl.");

                entity.HasIndex(e => e.DimensionName)
                    .HasName("ux_mobile_busines_dimension")
                    .IsUnique();

                entity.Property(e => e.DimensionId)
                    .HasColumnName("dimension_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.CustomizationFlag)
                    .IsRequired()
                    .HasColumnName("customization_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("'Y'es means a custmer where the retail customer must provide a custom value such as initials for a mongramed dress shirt.\\n'N'o means the customer mustpick a pre-defined value from a ist, such as blue from a list of colors");

                entity.Property(e => e.DefaultDimensionValueFk)
                    .HasColumnName("default_dimension_value_fk")
                    .HasComment("A foreign key to the default value for this dimension for all products that participate in this dimension. NOTE: this is nullable since a default is not required and since making it required creates an insoluble chicken and egg problem.");

                entity.Property(e => e.DimensionName)
                    .HasColumnName("dimension_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Human readable text name of dimension.");

                entity.Property(e => e.GraphicGuide)
                    .HasColumnName("graphic_guide")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("A graphic to help a retail customer choose from among the options for this given dimension. For example, a height and weight guide for a clothing size dimension or a color palette for a clothing color.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<DimensionCreatorManufacturer>(entity =>
            {
                entity.ToTable("dimension_creator_manufacturer");

                entity.HasComment("An intersection between the dimension and manufacturer tables. The existence of a record indicates that the associated manufacturer is the one who created the associated dimension and set it's values. The true purpose of a dimension source is to drive default dimensions and suggestions during product setup.");

                entity.HasIndex(e => new { e.DimensionFk, e.ManufacturerFk })
                    .HasName("ux_dimension_creator_manufacturer")
                    .IsUnique();

                entity.Property(e => e.DimensionCreatorManufacturerId)
                    .HasColumnName("dimension_creator_manufacturer_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.DimensionFk)
                    .HasColumnName("dimension_fk")
                    .HasComment("Foreign key to associated dimension.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.ManufacturerFk)
                    .HasColumnName("manufacturer_fk")
                    .HasComment("Foreign key to associated manufacturer - really a role playing foreign key to the third party service provider table.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.DimensionFkNavigation)
                    .WithMany(p => p.DimensionCreatorManufacturer)
                    .HasForeignKey(d => d.DimensionFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_dimension_creator_manufacturer_dimension");

                entity.HasOne(d => d.ManufacturerFkNavigation)
                    .WithMany(p => p.DimensionCreatorManufacturer)
                    .HasForeignKey(d => d.ManufacturerFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_dimension_creator_manufacturer_manufacturer");
            });

            modelBuilder.Entity<DimensionDependentInventoryRecord>(entity =>
            {
                entity.ToTable("dimension_dependent_inventory_record");

                entity.HasComment("A product detail table. This table holds the inventory on hand, available (on hand - ordered) and target level for every dimensional configuration of a given dimensional product. NOTE: this table cannot have a uniqueness constraint because it's uniqueness is really the product_fk plus the set of dimension vlaues in the child table.");

                entity.Property(e => e.DimensionDependentInventoryRecordId)
                    .HasColumnName("dimension_dependent_inventory_record_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.ProductFk)
                    .HasColumnName("product_fk")
                    .HasComment("Foreign key to parent product.");

                entity.Property(e => e.QuantityAvailable)
                    .HasColumnName("quantity_available")
                    .HasComment("The number of items on hand minus any quantity of the items that appear on carts that have been checked out. NOTE: only applies to physical products - not virtual items nor any services.");

                entity.Property(e => e.QuantityOnHand)
                    .HasColumnName("quantity_on_hand")
                    .HasComment("Number of product in inventory. NOTE: only applicale to physcical products.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TargetQuantity)
                    .HasColumnName("target_quantity")
                    .HasComment("Normative inventory level based on best anaysis.");

                entity.HasOne(d => d.ProductFkNavigation)
                    .WithMany(p => p.DimensionDependentInventoryRecord)
                    .HasForeignKey(d => d.ProductFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_dimensional_product_inventory_product");
            });

            modelBuilder.Entity<DimensionDependentInventoryRecordDimensionValue>(entity =>
            {
                entity.HasKey(e => e.DimensionalDependentInventoryRecordDimensionValueId)
                    .HasName("pk_dimensional_inventory_dimension_value_dimensional_inventory_dimension_value_id");

                entity.ToTable("dimension_dependent_inventory_record_dimension_value");

                entity.HasComment("For a given product inventory record that holds the on hand and available quantities for a product that has one or more non-customizable dimensions this table holds the detail dimension values. For example, if a mobile business has 7 blazers on hand that are size large and color navy blue. This table holds the details of large and navy blue on behalf of the parent table that holds the pointer to the mobile business' blazer and indication of 7 on hand.");

                entity.HasIndex(e => new { e.DimensionalDependentInventoryRecordFk, e.ProductDimensionalValueFk })
                    .HasName("ux_dimension_dependent_inventory_record_dimension_0")
                    .IsUnique();

                entity.Property(e => e.DimensionalDependentInventoryRecordDimensionValueId)
                    .HasColumnName("dimensional_dependent_inventory_record_dimension_value_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.DimensionalDependentInventoryRecordFk)
                    .HasColumnName("dimensional_dependent_inventory_record_fk")
                    .HasComment("Foreign key to parent dimenstional dependent inventoy record.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.ProductDimensionalValueFk)
                    .HasColumnName("product_dimensional_value_fk")
                    .HasComment("Foreign key to associated product_dimensional value.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.DimensionalDependentInventoryRecordFkNavigation)
                    .WithMany(p => p.DimensionDependentInventoryRecordDimensionValue)
                    .HasForeignKey(d => d.DimensionalDependentInventoryRecordFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_dimensional_inventory_dimension_value_inventory_record");

                entity.HasOne(d => d.ProductDimensionalValueFkNavigation)
                    .WithMany(p => p.DimensionDependentInventoryRecordDimensionValue)
                    .HasForeignKey(d => d.ProductDimensionalValueFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_dimensional_inventory_dimension_valuedimension_value");
            });

            modelBuilder.Entity<DimensionSourceBusinessCategory>(entity =>
            {
                entity.ToTable("dimension_source_business_category");

                entity.HasComment("Intersection between the dimension and business category tables. The existence of a record indicates that a given dimension was created by and got its values from the associated business category - not from an individual mobile business. For example, in the US garage doors come in white, almond and chocolate brown. This is an industry standard thing from both manfufacturers,");

                entity.Property(e => e.DimensionSourceBusinessCategoryId)
                    .HasColumnName("dimension_source_business_category_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.BusinessCategoryFk)
                    .HasColumnName("business_category_fk")
                    .HasComment("Foreign key to parent business category.");

                entity.Property(e => e.DimensionFk)
                    .HasColumnName("dimension_fk")
                    .HasComment("Foreign key to associated dimension.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.BusinessCategoryFkNavigation)
                    .WithMany(p => p.DimensionSourceBusinessCategory)
                    .HasForeignKey(d => d.BusinessCategoryFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_dimension_source_business_category_business_category");

                entity.HasOne(d => d.DimensionFkNavigation)
                    .WithMany(p => p.DimensionSourceBusinessCategory)
                    .HasForeignKey(d => d.DimensionFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_dimension_source_business_category_dimension");
            });

            modelBuilder.Entity<DimensionSourceMobileBusiness>(entity =>
            {
                entity.ToTable("dimension_source_mobile_business");

                entity.HasComment("Intersection table between the dimension and mobile business tables. The existence of a record indicates that the associated mobile business created the assoicated dimension and it's associated values. The true purpose of a dimension source is to drive default dimensions and suggestions during product setup.");

                entity.HasIndex(e => new { e.DimensionFk, e.MobileBusinessFk })
                    .HasName("ux_dimension_source_mobile_business")
                    .IsUnique();

                entity.Property(e => e.DimensionSourceMobileBusinessId)
                    .HasColumnName("dimension_source_mobile_business_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.DimensionFk)
                    .HasColumnName("dimension_fk")
                    .HasComment("Foreign key to associated dimension.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foreign key to associated mobile business.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.DimensionFkNavigation)
                    .WithMany(p => p.DimensionSourceMobileBusiness)
                    .HasForeignKey(d => d.DimensionFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_dimension_source_mobile_business_dimension");

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.DimensionSourceMobileBusiness)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_dimension_source_mobile_business_mobile_business");
            });

            modelBuilder.Entity<DimensionValue>(entity =>
            {
                entity.ToTable("dimension_value");

                entity.HasComment("A list of the legal value for a product dimension. For example, for hoody sixe small, medium, large, XL, XXL and XXXL.");

                entity.HasIndex(e => new { e.DimensionFk, e.OptionValue })
                    .HasName("ux_product_dimension_value")
                    .IsUnique();

                entity.Property(e => e.DimensionValueId)
                    .HasColumnName("dimension_value_id")
                    .HasComment("System generated surrogate key.");

                entity.Property(e => e.DimensionFk)
                    .HasColumnName("dimension_fk")
                    .HasComment("Foreign key to parent product dimension.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.OptionGraphic)
                    .HasColumnName("option_graphic")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("A graphic representation of the option such as a swath of a color to supplement the text description of red.");

                entity.Property(e => e.OptionValue)
                    .IsRequired()
                    .HasColumnName("option_value")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("Human readable option for dimension on the product such as small, medium or large on a t shirt.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.DimensionFkNavigation)
                    .WithMany(p => p.DimensionValue)
                    .HasForeignKey(d => d.DimensionFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_product_dimension_value_dimension");
            });

            modelBuilder.Entity<EmailAddress>(entity =>
            {
                entity.ToTable("email_address");

                entity.HasComment("A email address.");

                entity.HasIndex(e => e.Email)
                    .HasName("ux_email_address")
                    .IsUnique();

                entity.Property(e => e.EmailAddressId)
                    .HasColumnName("email_address_id")
                    .HasComment("System generated surrogate primary key.")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.EmailTypeCode)
                    .HasColumnName("email_type_code")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("B - business \\nP - Personal");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.EmailAddressNavigation)
                    .WithOne(p => p.EmailAddress)
                    .HasForeignKey<EmailAddress>(d => d.EmailAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_email_address_contact_mechanism");
            });

            modelBuilder.Entity<Good>(entity =>
            {
                entity.ToTable("good");

                entity.HasComment("A kind of a product. A physical or digital item that can simply be delivered. Although there might be a need for follow up phone or video support. NOTE: good has no uniqueness constraint / business key because it gets its uniqueness from its parent table product.");

                entity.Property(e => e.GoodId)
                    .HasColumnName("good_id")
                    .HasComment("System generated surrogate primary key.")
                    .ValueGeneratedNever();

                entity.Property(e => e.CustomizableFlag)
                    .HasColumnName("customizable_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("'Y'es or 'N'o. A customizable product such as a kite could perhaps have customer text or a company logo on it when delivered. NOTE: obviously when ordering the product we need to capture a value for each dimension over which the product is customizable.");

                entity.Property(e => e.ExpectedRestockDelayInDays)
                    .HasColumnName("expected_restock_delay_in_days")
                    .HasDefaultValueSql("((0))")
                    .HasComment("The number of days expected to pass between ordering more stock from the manufacturer and getting that new stock available for sale.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.ManufacturerFk)
                    .HasColumnName("manufacturer_fk")
                    .HasComment("Foreign key to the business that manufactures this good. This is very helpful to organizes restocking orders for multiple products. NOTE: this field can be null since the mobile business may not be at a level of sophisitication to clue us in on the applicable manufacturers.");

                entity.Property(e => e.PlatformGetsAllInventoryFlag)
                    .IsRequired()
                    .HasColumnName("platform_gets_all_inventory_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')")
                    .HasComment("Have we been allocated all of the inventory to unload- or just a part (is overall inventory level my problem)\\n'Y' means Yes\\n'N' means No");

                entity.Property(e => e.QuantityAvailable)
                    .HasColumnName("quantity_available")
                    .HasComment("The number of items on hand minus any quantity of the items that appear on carts that have been checked out. NOTE: only applies to physical products - not virtual items nor any services.");

                entity.Property(e => e.QuantityOnHand)
                    .HasColumnName("quantity_on_hand")
                    .HasComment("Number of product in inventory. NOTE: only applicale to physcical products.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ReorderLagTimeInDays)
                    .HasColumnName("reorder_lag_time_in_days")
                    .HasComment("THe number of days it takes to get new stock after it is ordered from the manufacturer. This is needed to calculate accurate / helpful restocking required notifications.");

                entity.Property(e => e.ReturnAddressFk)
                    .HasColumnName("return_address_fk")
                    .HasComment("Foreign key to associated return address. NOTE: this constitutes an over ride to the general physical goods return address for the mobile business and any return address that applies for the applicable product category.");

                entity.Property(e => e.TargetQuantity)
                    .HasColumnName("target_quantity")
                    .HasComment("Normative inventory level based on best anaysis.");

                entity.Property(e => e.WeightInPounds)
                    .HasColumnName("weight_in_pounds")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Weight - needed for shipping cost.");

                entity.HasOne(d => d.GoodNavigation)
                    .WithOne(p => p.Good)
                    .HasForeignKey<Good>(d => d.GoodId)
                    .HasConstraintName("fk_good_product");

                entity.HasOne(d => d.ManufacturerFkNavigation)
                    .WithMany(p => p.Good)
                    .HasForeignKey(d => d.ManufacturerFk)
                    .HasConstraintName("fk_good_manufacturer");

                entity.HasOne(d => d.ReturnAddressFkNavigation)
                    .WithMany(p => p.Good)
                    .HasForeignKey(d => d.ReturnAddressFk)
                    .HasConstraintName("fk_good_return_address");
            });

            modelBuilder.Entity<GoodVendorOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("good_vendor_order");

                entity.HasComment("A record of a mobile business restocking a good from the manufacturer.");

                entity.Property(e => e.FulfillmentDate)
                    .HasColumnName("fulfillment_date")
                    .HasColumnType("date")
                    .HasComment("The date the supplier came through abd the ordered goods showed up.");

                entity.Property(e => e.GoodFk)
                    .HasColumnName("good_fk")
                    .HasComment("Foreign key to parent good.");

                entity.Property(e => e.GoodVendorOrderId)
                    .HasColumnName("good_vendor_order_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("date")
                    .HasComment("The date the mobile business communicated the order to the supplier.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SupplierFk)
                    .HasColumnName("supplier_fk")
                    .HasComment("Foreign key to the firm that supplies the good.");

                entity.HasOne(d => d.GoodFkNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.GoodFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_good_vendor_order_good");

                entity.HasOne(d => d.SupplierFkNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.SupplierFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_good_vendor_order_supplier");
            });

            modelBuilder.Entity<GradedHighLevelFeature>(entity =>
            {
                entity.ToTable("graded_high_level_feature");

                entity.HasComment("A table that list the set of high level platform features that a retail customer must qualify for to particupate in. For example, getting an offer to do terms (such as 90 days same as cash) of their purchases. The magic engine calculates scores per customer as to qualifying for the feature and the mobile business gets to a operational threshold, a bar retail customers must meet to be permitted to use terms. THis table holds the set of such high level graded features, terms being a single example.");

                entity.HasIndex(e => e.GradedHighLevelFeatureName)
                    .HasName("ux_graded_high_level_feature")
                    .IsUnique();

                entity.Property(e => e.GradedHighLevelFeatureId)
                    .HasColumnName("graded_high_level_feature_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.GradedHighLevelFeatureName)
                    .HasColumnName("graded_high_level_feature_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Human readable text name of the high level feature.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("invoice");

                entity.HasComment("All of invoices associated with an executed shipment. THis table is one to one with shipment.");

                entity.HasIndex(e => e.ShipmentFk)
                    .HasName("ux_invoice")
                    .IsUnique();

                entity.Property(e => e.InvoiceId)
                    .HasColumnName("invoice_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.InvoiceAmount)
                    .HasColumnName("invoice_amount")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("The dollar amount of the invoice.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ShipmentFk)
                    .HasColumnName("shipment_fk")
                    .HasComment("Foreign key to associated shipment. NOTE: field is nullable since the row may be for a cart settled by terms.");

                entity.HasOne(d => d.ShipmentFkNavigation)
                    .WithOne(p => p.Invoice)
                    .HasForeignKey<Invoice>(d => d.ShipmentFk)
                    .HasConstraintName("fk_invoices_shipment");
            });

            modelBuilder.Entity<Kpi>(entity =>
            {
                entity.ToTable("kpi");

                entity.HasComment("Key performance indicator. NOTE: these rows have assoiated hand coded calulation mechanisms.");

                entity.HasIndex(e => e.TextDescription)
                    .HasName("ux_kpi")
                    .IsUnique();

                entity.Property(e => e.KpiId)
                    .HasColumnName("kpi_id")
                    .HasComment("System gernated surrogate primary key.");

                entity.Property(e => e.DefaultFlag)
                    .HasColumnName("default_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("'Y'es mean this kpi is racked for all businesses by default ,\\n'N'o means this kpi is only tracked and displayed upon request");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.LevelIndicator)
                    .HasColumnName("level_indicator")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("'B' means at the business level\\n'E' means at the eployee level");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TextDescription)
                    .HasColumnName("text_description")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("Human readable text description of the key performance indicator.");
            });

            modelBuilder.Entity<LiveChat>(entity =>
            {
                entity.ToTable("live_chat");

                entity.HasComment("A live instant message chat between a platform employee and a mobile business owner or between a mobile business owner and a retail customer.");

                entity.HasIndex(e => new { e.FirstMessageTimestamp, e.PlatformEmployeeFk, e.MobileBusinessEmployeeFk, e.RetailCustomerFk })
                    .HasName("ux_live_chat")
                    .IsUnique();

                entity.Property(e => e.LiveChatId)
                    .HasColumnName("live_chat_id")
                    .HasComment("system genarated surrogate primary key.");

                entity.Property(e => e.FirstMessageTimestamp)
                    .HasColumnName("first_message_timestamp")
                    .HasColumnType("datetime")
                    .HasComment("Moment the first message od the chat was sent.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessEmployeeFk)
                    .HasColumnName("mobile_business_employee_fk")
                    .HasComment("Foreign key to mobile business \"Employee\" who is the owner receiving assistance or to the employee/agent of the mobile business providing assistance to a retail customer. NOTE: this field is nullable since it is possible for a platform employee to provide assistance to a retail customer.");

                entity.Property(e => e.PlatformEmployeeFk)
                    .HasColumnName("platform_employee_fk")
                    .HasComment("Foreign key to platform employee providing assistance.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RetailCustomerFk)
                    .HasColumnName("retail_customer_fk")
                    .HasComment("Foreign key to retail customer receiving assistance.");

                entity.HasOne(d => d.MobileBusinessEmployeeFkNavigation)
                    .WithMany(p => p.LiveChat)
                    .HasForeignKey(d => d.MobileBusinessEmployeeFk)
                    .HasConstraintName("fk_live_chat_mobile_business_employee");

                entity.HasOne(d => d.PlatformEmployeeFkNavigation)
                    .WithMany(p => p.LiveChat)
                    .HasForeignKey(d => d.PlatformEmployeeFk)
                    .HasConstraintName("fk_live_chat_enoic_employee");

                entity.HasOne(d => d.RetailCustomerFkNavigation)
                    .WithMany(p => p.LiveChat)
                    .HasForeignKey(d => d.RetailCustomerFk)
                    .HasConstraintName("fk_live_chat_retail_customer");
            });

            modelBuilder.Entity<LiveChatMessage>(entity =>
            {
                entity.ToTable("live_chat_message");

                entity.HasComment("An individual message in a live chat stream.");

                entity.HasIndex(e => new { e.LiveChatFk, e.TalkTimestamp })
                    .HasName("ux_live_char_message")
                    .IsUnique();

                entity.Property(e => e.LiveChatMessageId)
                    .HasColumnName("live_chat_message_id")
                    .HasComment("System Generated surrogate primary key.");

                entity.Property(e => e.InstantMessage)
                    .IsRequired()
                    .HasColumnName("instant_message")
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasComment("the instant message that is apart of the chat.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.LiveChatFk)
                    .HasColumnName("live_chat_fk")
                    .HasComment("Foreign key to parent live chat.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TalkTimestamp)
                    .HasColumnName("talk_timestamp")
                    .HasColumnType("datetime")
                    .HasComment("The moment the message was sent.");

                entity.Property(e => e.TalkerType)
                    .HasColumnName("talker_type")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("'A' means assistor and 'C' means customer.");

                entity.HasOne(d => d.LiveChatFkNavigation)
                    .WithMany(p => p.LiveChatMessage)
                    .HasForeignKey(d => d.LiveChatFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_live_char_message_live_chat");
            });

            modelBuilder.Entity<MessageCategoryRoleBasedRecipient>(entity =>
            {
                entity.ToTable("message_category_role_based_recipient");

                entity.HasComment("An intersection between the platform message category and platform role tables. The existence of a record instructs the system to send arisen platform messages of the given category to all recipient that are members of the associated platform role - limited to the current mobile business as appropriate of course.");

                entity.HasIndex(e => new { e.PlatformMessageCategoryFk, e.PlatformRoleFk })
                    .HasName("ux_message_category_role_based_recipient")
                    .IsUnique();

                entity.Property(e => e.MessageCategoryRoleBasedRecipientId)
                    .HasColumnName("message_category_role_based_recipient_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.PlatformMessageCategoryFk)
                    .HasColumnName("platform_message_category_fk")
                    .HasComment("Foreign key to associated platform message category.");

                entity.Property(e => e.PlatformRoleFk)
                    .HasColumnName("platform_role_fk")
                    .HasComment("Foreign key to the role specified here in to receive message of the given category.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.PlatformMessageCategoryFkNavigation)
                    .WithMany(p => p.MessageCategoryRoleBasedRecipient)
                    .HasForeignKey(d => d.PlatformMessageCategoryFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_message_category_role_based_recipient_message_category");

                entity.HasOne(d => d.PlatformRoleFkNavigation)
                    .WithMany(p => p.MessageCategoryRoleBasedRecipient)
                    .HasForeignKey(d => d.PlatformRoleFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_message_category_role_based_recipient_platform_role");
            });

            modelBuilder.Entity<MissedOrIncompleteWorkShift>(entity =>
            {
                entity.ToTable("missed_or_incomplete_work_shift");

                entity.HasComment("A record of an occassion when a mobile business employee agreed to a shift, but later cancelled, or just didn't show up, or showed up late and or left early.");

                entity.HasIndex(e => new { e.MobileBusinessEmployeeFk, e.WorkScheduleDate })
                    .HasName("ux_missed_or_incomplete_work_shift")
                    .IsUnique();

                entity.Property(e => e.MissedOrIncompleteWorkShiftId)
                    .HasColumnName("missed_or_incomplete_work_shift_id")
                    .HasComment("System generated surrogate primary key");

                entity.Property(e => e.Excuse)
                    .HasColumnName("excuse")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("The employee's explanation for the event; such as they left early due to failing the covid-19 thermometer check when they got back from lunch.");

                entity.Property(e => e.ExcuseMitigationFactor)
                    .HasColumnName("excuse_mitigation_factor")
                    .HasColumnType("decimal(5, 4)")
                    .HasComment("The degree to which the business location manager and or business owner accepts the excuse sets asside the otherwise natural penalty that would acrue to the employee's loyalty score. For example, if an employee left early due to failing a covid-19 temperature check when they came back from lunch - the managment would likely give them a mitigation factor of 1 (menaing 100%) and in theis way completely accept the \"excuse\" and cause no penalty to accrue.");

                entity.Property(e => e.FailureType)
                    .HasColumnName("failure_type")
                    .HasColumnType("date")
                    .HasComment("\"C\" means calcellation\\n\"N\" means no show\\n\"L\" means arrived late\\n\"E\" means left early");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessEmployeeFk)
                    .HasColumnName("mobile_business_employee_fk")
                    .HasComment("A foreign key to the parent mobile business employee record.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.WorkScheduleDate)
                    .HasColumnName("work_schedule_date")
                    .HasColumnType("date")
                    .HasComment("The date the mobile business employee did not complete all of there shift.");

                entity.HasOne(d => d.MobileBusinessEmployeeFkNavigation)
                    .WithMany(p => p.MissedOrIncompleteWorkShift)
                    .HasForeignKey(d => d.MobileBusinessEmployeeFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_missed_or_incomplete_work_shift_mobile_business_employee");
            });

            modelBuilder.Entity<MobileBusiness>(entity =>
            {
                entity.ToTable("mobile_business");

                entity.HasComment("This table represents the Mobile Business being Run in production. NOTE: There is no uniquness constraint / business key for this table. It inherits it's uniquness from the organization table.");

                entity.Property(e => e.MobileBusinessId)
                    .HasColumnName("mobile_business_id")
                    .HasComment("System generated surrogate primary key, and a foreign key to businss_organization (the parent in the inheritance hierarchy).")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveFlag)
                    .IsRequired()
                    .HasColumnName("active_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')")
                    .HasComment("'Y'es/'N'o flag to say if the mobile business is active on the platform or has been de-platformed.");

                entity.Property(e => e.Configuration)
                    .HasColumnName("configuration")
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("A blob (json) representation of all the setting for the client that make the client look and act in the correct manner on the phone ap.");

                entity.Property(e => e.DefaultTradeRadiusInMiles)
                    .HasColumnName("default_trade_radius_in_miles")
                    .HasColumnType("decimal(5, 2)")
                    .HasComment("A trade radius for the whole enterprise - used as default for every location hat does not overrise it.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.LifetimeCustomerCount)
                    .HasColumnName("lifetime_customer_count")
                    .HasComment("Lifetime customer count on the platform.");

                entity.Property(e => e.LogoUrl)
                    .HasColumnName("logo_url")
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasComment("Universal resource location - the web site of the mobile business.");

                entity.Property(e => e.OwnerFk)
                    .HasColumnName("owner_fk")
                    .HasComment("Foreign key to the person who owns this mobile business.");

                entity.Property(e => e.OwnerTitle)
                    .IsRequired()
                    .HasColumnName("owner_title")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Owner')")
                    .HasComment("A title the Owner wishes to use like an office, like CEO or Tsar");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ReferralBonus)
                    .HasColumnName("referral_bonus")
                    .HasComment("The number of tokens given as a bonus as a reward to a retail customer referring a paying customer to the mobile business web site - expressed as a number of tokens (the current rate.");

                entity.Property(e => e.RestockingFeeAsARatio)
                    .HasColumnName("restocking_fee_as_a_ratio")
                    .HasColumnType("decimal(5, 4)")
                    .HasComment("The portion f the price that is not refunded as a restocking fee. 15% would be represented as 0.15 (the decimal representation).");

                entity.Property(e => e.ReturnAddressFk)
                    .HasColumnName("return_address_fk")
                    .HasComment("Foreign key to the default return address to use for all physical goods sold by this vendor. NOTE: this can be over-ridden at the product category and product levels.");

                entity.Property(e => e.SelectedColorFk)
                    .HasColumnName("selected_color_fk")
                    .HasComment("Foreign key to the color for the screens which the owner selected.");

                entity.Property(e => e.SelectedThemeFk)
                    .HasColumnName("selected_theme_fk")
                    .HasComment("Foreign key to the presentation theme chosen my owner of this mobile business.");

                entity.Property(e => e.ShipsGoodsFlag)
                    .IsRequired()
                    .HasColumnName("ships_goods_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')")
                    .HasComment("A flag to indicate if the mobile business ever ships the goods it sells.");

                entity.Property(e => e.SophisticationLevel)
                    .HasColumnName("sophistication_level")
                    .HasDefaultValueSql("((1))")
                    .HasComment("The level of sophistication of the mobile business. This evel determines which of the spotify features that are available to the subject mobile business.");

                entity.Property(e => e.TaxItemTypeFk)
                    .HasColumnName("tax_item_type_fk")
                    .HasComment("Foriegn key to tax item type");

                entity.HasOne(d => d.MobileBusinessNavigation)
                    .WithOne(p => p.MobileBusiness)
                    .HasForeignKey<MobileBusiness>(d => d.MobileBusinessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mobile_business_organization");

                entity.HasOne(d => d.OwnerFkNavigation)
                    .WithMany(p => p.MobileBusiness)
                    .HasForeignKey(d => d.OwnerFk)
                    .HasConstraintName("fk_mobile_business_owner");

                entity.HasOne(d => d.ReturnAddressFkNavigation)
                    .WithMany(p => p.MobileBusiness)
                    .HasForeignKey(d => d.ReturnAddressFk)
                    .HasConstraintName("fk_mobile_business_return_address");

                entity.HasOne(d => d.SelectedColorFkNavigation)
                    .WithMany(p => p.MobileBusiness)
                    .HasForeignKey(d => d.SelectedColorFk)
                    .HasConstraintName("Fk_mobile_business_color");

                entity.HasOne(d => d.SelectedThemeFkNavigation)
                    .WithMany(p => p.MobileBusiness)
                    .HasForeignKey(d => d.SelectedThemeFk)
                    .HasConstraintName("Fk_mobile_business_theme");

                entity.HasOne(d => d.TaxItemTypeFkNavigation)
                    .WithMany(p => p.MobileBusiness)
                    .HasForeignKey(d => d.TaxItemTypeFk)
                    .HasConstraintName("fk_mobile_buisness");
            });

            modelBuilder.Entity<MobileBusinessAggregator>(entity =>
            {
                entity.ToTable("mobile_business_aggregator");

                entity.HasComment("A strip mall owner who makes his tenets use our platform. NOTE: this table has no uniqueness constraint / business key. It inherits it's uniqness from the parent organization.");

                entity.Property(e => e.MobileBusinessAggregatorId)
                    .HasColumnName("mobile_business_aggregator_id")
                    .HasComment("System generated surrogate primary key.")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RevenueShareRatio)
                    .HasColumnName("revenue_share_ratio")
                    .HasComment("The part of the revenue the mobile business aggregator gets as a share of platform revenue share.");

                entity.HasOne(d => d.MobileBusinessAggregatorNavigation)
                    .WithOne(p => p.MobileBusinessAggregator)
                    .HasForeignKey<MobileBusinessAggregator>(d => d.MobileBusinessAggregatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mobile_business_aggregator_organization");
            });

            modelBuilder.Entity<MobileBusinessAggregatorMobileBusiness>(entity =>
            {
                entity.ToTable("mobile_business_aggregator_mobile_business");

                entity.HasComment("An intersection table between the mobile business aggregator and mobile buiness tables. The existence of a record indicates that the assocaited mobile business was brought in through the associated mobile business aggregator.");

                entity.HasIndex(e => new { e.MobileBusinessAggregatorFk, e.MobileBusinessFk })
                    .HasName("ux_mobile_business_aggregator_mobile_business")
                    .IsUnique();

                entity.Property(e => e.MobileBusinessAggregatorMobileBusinessId)
                    .HasColumnName("mobile_business_aggregator_mobile_business_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessAggregatorFk)
                    .HasColumnName("mobile_business_aggregator_fk")
                    .HasComment("FOreign key to parent mobile business aggregator.");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foriegn key to mobile business.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("date");

                entity.HasOne(d => d.MobileBusinessAggregatorFkNavigation)
                    .WithMany(p => p.MobileBusinessAggregatorMobileBusiness)
                    .HasForeignKey(d => d.MobileBusinessAggregatorFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mobile_business_aggregator_mobile_business_aggregator");

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.MobileBusinessAggregatorMobileBusiness)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mobile_business_aggregator_mobile_business_mobile_business");
            });

            modelBuilder.Entity<MobileBusinessBusinessCategory>(entity =>
            {
                entity.ToTable("mobile_business_business_category");

                entity.HasComment("Intersection between the mobile business and business category tables. The existence of a record indicates that the mobile business operates in the associated business category as a good, service or asset. NOTE: a mobile business is permitted more than one category per offer mode.");

                entity.Property(e => e.MobileBusinessBusinessCategoryId)
                    .HasColumnName("mobile_business_business_category_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.BusinessCategoryFk)
                    .HasColumnName("business_category_fk")
                    .HasComment("Foreign key to assocaited business category.");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("FOreign key to associated mobile business.");

                entity.Property(e => e.OfferMode)
                    .IsRequired()
                    .HasColumnName("offer_mode")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("'G' means good\\n'S' means service\\n'A\" means asset");

                entity.HasOne(d => d.BusinessCategoryFkNavigation)
                    .WithMany(p => p.MobileBusinessBusinessCategory)
                    .HasForeignKey(d => d.BusinessCategoryFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_mobile_business_business_category_business_category");

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.MobileBusinessBusinessCategory)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_mobile_business_business_category_mobile_business");
            });

            modelBuilder.Entity<MobileBusinessCharity>(entity =>
            {
                entity.ToTable("mobile_business_charity");

                entity.HasComment("An intersection between the mobile business and charity table. The existence of a record indicates that the mobile business has established a relationship with the associated charity to remit a portion of revenue where the retail customer has requested it - perhaps with matching funds.");

                entity.HasIndex(e => new { e.MobileBusinessFk, e.CharityFk })
                    .HasName("ux_mobile_business_charity")
                    .IsUnique();

                entity.Property(e => e.MobileBusinessCharityId)
                    .HasColumnName("mobile_business_charity_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.ActiveFlag)
                    .IsRequired()
                    .HasColumnName("active_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')")
                    .HasComment("'Y' means this charity is active for appearing at the check out as per the mobile business owner's instructions.\\n\"N' means this charity is not active for appearing at the check out as per the mobile business owners instructions.");

                entity.Property(e => e.CharityFk)
                    .HasColumnName("charity_fk")
                    .HasComment("Foreign key to associated charity.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foreign key to parent mobile business.");

                entity.Property(e => e.MobileBusinessMatchMaxPortionOfCartTotal)
                    .HasColumnName("mobile_business_match_max_portion_of_cart_total")
                    .HasColumnType("decimal(5, 4)")
                    .HasDefaultValueSql("((0.05))")
                    .HasComment("The maximum we will contribute as a portion of the cart total. Otherwise a retail customer could spend $1 dollar contribute $500 and get mathcing funds for his charitible contribution - clever but we must block that.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SpecifiedMatchRatio)
                    .HasColumnName("specified_match_ratio")
                    .HasColumnType("decimal(5, 4)")
                    .HasComment("The portion of the customer contribution that we will match in the event of a retail consytomer contribution. For example 0.50 would indicate that we would match 50 cents on the dollar and 1 would indicate we will match retail customer contributions dollar for dollar.");

                entity.HasOne(d => d.CharityFkNavigation)
                    .WithMany(p => p.MobileBusinessCharity)
                    .HasForeignKey(d => d.CharityFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mobile_business_charity_charity");

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.MobileBusinessCharity)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mobile_business_charity_mobile_business");
            });

            modelBuilder.Entity<MobileBusinessEmployee>(entity =>
            {
                entity.ToTable("mobile_business_employee");

                entity.HasComment("A person that does work for a mobile business. NOTE: there is no uniqueness constraint. UNiqueness must come from the parent person row.");

                entity.HasIndex(e => new { e.MobileBusinessEmployeeId, e.MobileBusinessFk })
                    .HasName("ux_mobile_business_employee");

                entity.Property(e => e.MobileBusinessEmployeeId)
                    .HasColumnName("mobile_business_employee_id")
                    .HasComment("System generated surrogate primary key and a foreign key to the hierarchical parent - person.")
                    .ValueGeneratedNever();

                entity.Property(e => e.IncomeStructureIndicator)
                    .HasColumnName("income_structure_indicator")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('P')")
                    .HasComment("'P'means pay per time\\n'S' means salary - pay per relationship\\n'C' means commission\\n'B' means both pay per hour and per commission");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foreign key to mobile business that the mobile business agent acts on behalf of.");

                entity.Property(e => e.PictureUrl)
                    .HasColumnName("picture_url")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SellingIndicator)
                    .HasColumnName("selling_indicator")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WorkScheduleIndicator)
                    .HasColumnName("work_schedule_indicator")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.MobileBusinessEmployeeNavigation)
                    .WithOne(p => p.MobileBusinessEmployee)
                    .HasForeignKey<MobileBusinessEmployee>(d => d.MobileBusinessEmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mobile_business_employee_person");

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.MobileBusinessEmployee)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mobile_business_employee_mobile_business");
            });

            modelBuilder.Entity<MobileBusinessEmployeeAuthorizationGroup>(entity =>
            {
                entity.ToTable("mobile_business_employee_authorization_group");

                entity.HasComment("This table is about role based access control. The obvious instance would be a subset of the employeess at a mobile business. -- The Group Table Represents the top heirarchy for Role Based access to create Teams and assign to Locations, assign Teams to Services");

                entity.HasIndex(e => new { e.MobileBuisnessFk, e.GroupName })
                    .HasName("ux_employee_authorization_group")
                    .IsUnique();

                entity.Property(e => e.MobileBusinessEmployeeAuthorizationGroupId)
                    .HasColumnName("mobile_business_employee_authorization_group_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.GroupName)
                    .HasColumnName("group_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Text name of the role / set of employees.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBuisnessFk)
                    .HasColumnName("mobile_buisness_fk")
                    .HasComment("Foreign key to parent mobile business.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.MobileBuisnessFkNavigation)
                    .WithMany(p => p.MobileBusinessEmployeeAuthorizationGroup)
                    .HasForeignKey(d => d.MobileBuisnessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Group_Mobile_Buisness1");
            });

            modelBuilder.Entity<MobileBusinessEmployeeAuthorizationGroupMembership>(entity =>
            {
                entity.ToTable("mobile_business_employee_authorization_group_membership");

                entity.HasComment("An intersection beween the mobile business employee and mobile business employee group tables. The existence of a record indicates that the associated mobile business employee is a member of the associated mobile business employee group - thus gaining access rights to the functions associated with the platform role(s) associated with the parent employee group.");

                entity.HasIndex(e => new { e.EmployeeGroupFk, e.MobileBusinessEmployeeFk })
                    .HasName("ux_employee_authorization_group_membership")
                    .IsUnique();

                entity.Property(e => e.MobileBusinessEmployeeAuthorizationGroupMembershipId)
                    .HasColumnName("mobile_business_employee_authorization_group_membership_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.EmployeeGroupFk)
                    .HasColumnName("employee_group_fk")
                    .HasComment("Foreign key to parent mobile business employee group.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessEmployeeFk)
                    .HasColumnName("mobile_business_employee_fk")
                    .HasComment("Foreign key to the associated mobile business employee.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.EmployeeGroupFkNavigation)
                    .WithMany(p => p.MobileBusinessEmployeeAuthorizationGroupMembership)
                    .HasForeignKey(d => d.EmployeeGroupFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mobile_business_agent_group_membership_group");

                entity.HasOne(d => d.MobileBusinessEmployeeFkNavigation)
                    .WithMany(p => p.MobileBusinessEmployeeAuthorizationGroupMembership)
                    .HasForeignKey(d => d.MobileBusinessEmployeeFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mobile_business_agent_group_membership_agent");
            });

            modelBuilder.Entity<MobileBusinessEmployeeAuthorizationGroupRole>(entity =>
            {
                entity.HasKey(e => e.GroupToPartyGroupRoleId)
                    .HasName("pk_mobile_business_agent_group_role_group_to_party_group_role_id");

                entity.ToTable("mobile_business_employee_authorization_group_role");

                entity.HasComment("Intersection table between the mobile business employee authorization group and roles tables. The existence of a record indicates that all members of the associated mobile business employee authorization group are, due to being in the group, cleared to perform all platform ap functions authorized for the given role.");

                entity.HasIndex(e => new { e.MobileBusinessEmployeeGroupFk, e.PlatformRoleFk, e.StartDt })
                    .HasName("ux_mobile_business_agent_group_role")
                    .IsUnique();

                entity.Property(e => e.GroupToPartyGroupRoleId)
                    .HasColumnName("group_to_party_group_role_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.EndDt)
                    .HasColumnName("end_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessEmployeeGroupFk)
                    .HasColumnName("mobile_business_employee_group_fk")
                    .HasComment("Foreign key to associated mobile employee group.");

                entity.Property(e => e.PlatformRoleFk)
                    .HasColumnName("platform_role_fk")
                    .HasComment("Foreign key to associated platform role.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.StartDt)
                    .HasColumnName("start_dt")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.MobileBusinessEmployeeGroupFkNavigation)
                    .WithMany(p => p.MobileBusinessEmployeeAuthorizationGroupRole)
                    .HasForeignKey(d => d.MobileBusinessEmployeeGroupFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mobile_business_to_party_role_group");

                entity.HasOne(d => d.PlatformRoleFkNavigation)
                    .WithMany(p => p.MobileBusinessEmployeeAuthorizationGroupRole)
                    .HasForeignKey(d => d.PlatformRoleFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mobilebusiness_to_partyrole_partyrole");
            });

            modelBuilder.Entity<MobileBusinessEmployeeAvailability>(entity =>
            {
                entity.ToTable("mobile_business_employee_availability");

                entity.HasComment("A list of future days that tells hours of availability to work. This table pre-supposes that the \"employee\" or the mobile business is not just generally available from 8:00 to 5:00 but instead supposes that the \"employee\" has other work obligations and in this table, the employee publishes his/her availability to the mobile business owner or manager as a notification.");

                entity.HasIndex(e => e.MobileBusinessEmployeeFk)
                    .HasName("ux_mobile_business_employee_availability")
                    .IsUnique();

                entity.Property(e => e.MobileBusinessEmployeeAvailabilityId)
                    .HasColumnName("mobile_business_employee_availability_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessEmployeeFk)
                    .HasColumnName("mobile_business_employee_fk")
                    .HasComment("Foreign key to parent mobile business employee.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.WeeklyScheduleFk)
                    .HasColumnName("weekly_schedule_fk")
                    .HasComment("Foreign key to associated weekly schedule.");

                entity.HasOne(d => d.MobileBusinessEmployeeFkNavigation)
                    .WithOne(p => p.MobileBusinessEmployeeAvailability)
                    .HasForeignKey<MobileBusinessEmployeeAvailability>(d => d.MobileBusinessEmployeeFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mobile_business_employee_availability");

                entity.HasOne(d => d.WeeklyScheduleFkNavigation)
                    .WithMany(p => p.MobileBusinessEmployeeAvailability)
                    .HasForeignKey(d => d.WeeklyScheduleFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mobile_business_employee_availability_weekly_schedule");
            });

            modelBuilder.Entity<MobileBusinessEmployeeBreakPreference>(entity =>
            {
                entity.ToTable("mobile_business_employee_break_preference");

                entity.HasComment("A reord of preferences to drive appointment scheduling.  An employee can say I do or don't want a lunch break starting no earlier than 11:00 and no later than 12:30 and I want 30 miuntes or I want 1 hour. NOTE: these recrods are not timed to any particular day or even day of week. Instead, these are general requirements for the mobile business employee work day.");

                entity.HasIndex(e => new { e.MobileBusinessEmployeeFk, e.WorkBreakCategoryFk, e.WorkBreakStartTimeMinimum })
                    .HasName("ux_mobile_business_employee_break_preference")
                    .IsUnique();

                entity.Property(e => e.MobileBusinessEmployeeBreakPreferenceId)
                    .HasColumnName("mobile_business_employee_break_preference_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessEmployeeFk)
                    .HasColumnName("mobile_business_employee_fk")
                    .HasComment("Foreign key to parent mobile business employee.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.WorkBreakCategoryFk)
                    .HasColumnName("work_break_category_fk")
                    .HasComment("Foreign key to associated work break category.");

                entity.Property(e => e.WorkBreakDurationInMinutes)
                    .HasColumnName("work_break_duration_in_minutes")
                    .HasComment("Number of minutes the break should be.");

                entity.Property(e => e.WorkBreakStartTimeMaximum)
                    .HasColumnName("work_break_start_time_maximum")
                    .HasComment("Number of minutes after midnight grinage time which is the latest time the break can be scheduled to start.");

                entity.Property(e => e.WorkBreakStartTimeMinimum)
                    .HasColumnName("work_break_start_time_minimum")
                    .HasComment("Number of minutes after midnight grinage time which is the earliest time the break can be scheduled to start.");

                entity.HasOne(d => d.MobileBusinessEmployeeFkNavigation)
                    .WithMany(p => p.MobileBusinessEmployeeBreakPreference)
                    .HasForeignKey(d => d.MobileBusinessEmployeeFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mobile_business_employee_break_preference_employee");

                entity.HasOne(d => d.WorkBreakCategoryFkNavigation)
                    .WithMany(p => p.MobileBusinessEmployeeBreakPreference)
                    .HasForeignKey(d => d.WorkBreakCategoryFk)
                    .HasConstraintName("fk_mobile_business_employee_break_preference_break_category");
            });

            modelBuilder.Entity<MobileBusinessEmployeeConcreteSchedule>(entity =>
            {
                entity.ToTable("mobile_business_employee_concrete_schedule");

                entity.HasComment("The actual employee schedule after considering the business calendar, the employee calendar and approved time off - for the case of an 8:00 to 5:00 job. Alternatively, a restaurant owner may set a concrete schedule based on their need and \"employee\" availability.");

                entity.HasIndex(e => e.MobileBusinessEmployeeFk)
                    .HasName("ux_employee_concrete_schedule")
                    .IsUnique();

                entity.Property(e => e.MobileBusinessEmployeeConcreteScheduleId)
                    .HasColumnName("mobile_business_employee_concrete_schedule_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessEmployeeFk)
                    .HasColumnName("mobile_business_employee_fk")
                    .HasComment("Foreign key to mobile business emloyee.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.WeeklyScheduleFk)
                    .HasColumnName("weekly_schedule_fk")
                    .HasComment("Foreign key to associated weekly schedule.");

                entity.HasOne(d => d.MobileBusinessEmployeeFkNavigation)
                    .WithOne(p => p.MobileBusinessEmployeeConcreteSchedule)
                    .HasForeignKey<MobileBusinessEmployeeConcreteSchedule>(d => d.MobileBusinessEmployeeFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_employee_concrete_schedule_employee");

                entity.HasOne(d => d.WeeklyScheduleFkNavigation)
                    .WithMany(p => p.MobileBusinessEmployeeConcreteSchedule)
                    .HasForeignKey(d => d.WeeklyScheduleFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_mobile_business_employee_concrete_schedule_weekly_schedule");
            });

            modelBuilder.Entity<MobileBusinessEmployeeLocationFillin>(entity =>
            {
                entity.ToTable("mobile_business_employee_location_fillin");

                entity.HasComment("An nitersection between the mobile business employee and business location tables. The existence of a record indicates that the associated employee has expressed a willingness to fill in at the associated location if shifts, for whatever reason, become available.");

                entity.HasIndex(e => new { e.MobileBusinessEmployeeFk, e.BusinessLocationFk, e.StartDate })
                    .HasName("ux_mobile_business_employee_location_fillin")
                    .IsUnique();

                entity.Property(e => e.MobileBusinessEmployeeLocationFillinId)
                    .HasColumnName("mobile_business_employee_location_fillin_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.BusinessLocationFk)
                    .HasColumnName("business_location_fk")
                    .HasComment("Foreign key to associated business location.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessEmployeeFk)
                    .HasColumnName("mobile_business_employee_fk")
                    .HasComment("Foriegn key to parent mobile business employee.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("date")
                    .HasComment("The date the associated employee started working at the associated business location.");

                entity.Property(e => e.TransferCharge)
                    .HasColumnName("transfer_charge")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("The employee may have attached a charge assocaited with such filling assignments. I am willing to drive all the way to location X where the business owner seems to be periodically short of prodctive capacity, but it is far from my home and I want $40 plus all my usual compensation.");

                entity.Property(e => e.WeeklyScheduleFk)
                    .HasColumnName("weekly_schedule_fk")
                    .HasComment("Foreign key to assocaited weekly schedule");

                entity.HasOne(d => d.BusinessLocationFkNavigation)
                    .WithMany(p => p.MobileBusinessEmployeeLocationFillin)
                    .HasForeignKey(d => d.BusinessLocationFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mobile_business_employee_location_assignment_location_0");

                entity.HasOne(d => d.MobileBusinessEmployeeFkNavigation)
                    .WithMany(p => p.MobileBusinessEmployeeLocationFillin)
                    .HasForeignKey(d => d.MobileBusinessEmployeeFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mobile_business_employee_location_assignment_employee_0");

                entity.HasOne(d => d.WeeklyScheduleFkNavigation)
                    .WithMany(p => p.MobileBusinessEmployeeLocationFillin)
                    .HasForeignKey(d => d.WeeklyScheduleFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_mobile_business_employee_location_fillin_weekly_schedule");
            });

            modelBuilder.Entity<MobileBusinessEmployeeOperatingParameters>(entity =>
            {
                entity.HasKey(e => e.MobileBusinessServiceOperatingParametersId)
                    .HasName("pk_mobile_business_service_operating_parameters_mobile_business_service_operating_parameters_id_0");

                entity.ToTable("mobile_business_employee_operating_parameters");

                entity.HasComment("The parameters that drive system behavior for the parent mobile business as to employee scheduling. For example, do employees just man locations in general thus their location assingments are static, or do they float between locations as part of the employee work hour scheduling process in order to deliver specific different services that they are diffeentially able to provide? That is, are location assingments static or dynmic..");

                entity.HasIndex(e => e.MobileBusinessFk)
                    .HasName("ux_mobile_business_employee_operating_parameters_0");

                entity.Property(e => e.MobileBusinessServiceOperatingParametersId)
                    .HasColumnName("mobile_business_service_operating_parameters_id")
                    .HasComment("System generated surrogate primry key.");

                entity.Property(e => e.EmployeeDefaultLoyaltyPoints)
                    .HasColumnName("employee_default_loyalty_points")
                    .HasDefaultValueSql("((1500))")
                    .HasComment("The number of loyalty points a new employee starts at - you can look at as the number of points the employee is awarded for accepting the offer.");

                entity.Property(e => e.EmployeeWorkDayLateshowOrEarlyLeavePenalty)
                    .HasColumnName("employee_work_day_lateshow_or_early_leave_penalty")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Number of loyalty points that the mobile business employee is penalized per minute for showing up late or leaving early on a individual scheduled shift. NOTE: this penalty maxes out at the no show penalty amount.");

                entity.Property(e => e.EmployeeWorkDayNoShowLoyaltyPenalty)
                    .HasColumnName("employee_work_day_no_show_loyalty_penalty")
                    .HasDefaultValueSql("((600))")
                    .HasComment("The number of loyalty points subtracted for an employee missing a whole shoft without prior notification.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.LocationAssignmentMethod)
                    .HasColumnName("location_assignment_method")
                    .HasComment("\"S\" means static assingments\\n\"D\" means dynamic assingments as part o scheduling\\n\"N\" not at all - the platform is not imnvolved in employee managment as to location assignments");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foreign key to parent mobile business.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SchedulingOfHoursMethod)
                    .HasColumnName("scheduling_of_hours_method")
                    .HasComment("\"S\" means static - a static work schedule 9 to 5, perhaps\\n\"D\" means dynamic assingments as part of scheduling - part of operations\\n\"N\" not at all - the platform is not imnvolved in employee managment as to hours");

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.MobileBusinessEmployeeOperatingParameters)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mobile_business_service_operating_parameters_mb_0");
            });

            modelBuilder.Entity<MobileBusinessEmployeeScheduledWorkdayBreaks>(entity =>
            {
                entity.ToTable("mobile_business_employee_scheduled_workday_breaks");

                entity.HasComment("For a given mobile business (indirectly given) and a given general day of the week (again indirectly) the pre-scheduled breaks set as a matter of mobile business policy");

                entity.HasIndex(e => e.MobileBusinessEmployeeFk)
                    .HasName("ux_mobile_business_employee_scheduled_workday_brea")
                    .IsUnique();

                entity.Property(e => e.MobileBusinessEmployeeScheduledWorkdayBreaksId)
                    .HasColumnName("mobile_business_employee_scheduled_workday_breaks_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessEmployeeFk)
                    .HasColumnName("mobile_business_employee_fk")
                    .HasComment("Foreign key to associated mobile buisness employee.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.WeeklyScheduleFk)
                    .HasColumnName("weekly_schedule_fk")
                    .HasComment("Foreign key to associated weekly schedule.");

                entity.HasOne(d => d.MobileBusinessEmployeeFkNavigation)
                    .WithOne(p => p.MobileBusinessEmployeeScheduledWorkdayBreaks)
                    .HasForeignKey<MobileBusinessEmployeeScheduledWorkdayBreaks>(d => d.MobileBusinessEmployeeFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_mobile_business_employee_scheduled_workday_breaks_employee");

                entity.HasOne(d => d.WeeklyScheduleFkNavigation)
                    .WithMany(p => p.MobileBusinessEmployeeScheduledWorkdayBreaks)
                    .HasForeignKey(d => d.WeeklyScheduleFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_mobile_business_employee_scheduled_workday_breaks_weekly_schedule");
            });

            modelBuilder.Entity<MobileBusinessEmployeeServiceQualification>(entity =>
            {
                entity.ToTable("mobile_business_employee_service_qualification");

                entity.HasComment("An intersection between the employee and product tables. The existence of a record indicates that the employee is qualified to assist or perform the associated service. NOTE: obviously the foriegn keys to product will point to services rather than a physical item.");

                entity.HasIndex(e => new { e.MobileBusinessEmployeeFk, e.ProfessionalServiceFk })
                    .HasName("ux_employee_service_qualification")
                    .IsUnique();

                entity.Property(e => e.MobileBusinessEmployeeServiceQualificationId)
                    .HasColumnName("mobile_business_employee_service_qualification_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessEmployeeFk)
                    .HasColumnName("mobile_business_employee_fk")
                    .HasComment("Foreign key to mobile business employee.");

                entity.Property(e => e.OverrideTimeRequirement)
                    .HasColumnName("override_time_requirement")
                    .HasComment("A number of minutes it takes for the assocaited mobile business employee to perform the associated servce. NOTE: this constitutes an override when compared to the amount of time held at the service leve;l.");

                entity.Property(e => e.ProductRetailCategoryFk)
                    .HasColumnName("product_retail_category_fk")
                    .HasComment("Foreign key to product retail category. That is, really a set of services. THis field allows us to qualify an employee for a set of similar services rther than qualifying an employee on each member service. NOTE: this field is nullable since the record can obviously be at the service level.");

                entity.Property(e => e.ProfessionalServiceFk)
                    .HasColumnName("professional_service_fk")
                    .HasComment("Foreign key to the professional service that the associated employee is qualified to perform or at least assist in the performance of. NOTE: this field is nullable since the record can obviously be at the product retail category (service category) level.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.MobileBusinessEmployeeFkNavigation)
                    .WithMany(p => p.MobileBusinessEmployeeServiceQualification)
                    .HasForeignKey(d => d.MobileBusinessEmployeeFk)
                    .HasConstraintName("fk_employee_service_qualification_employee");

                entity.HasOne(d => d.ProductRetailCategoryFkNavigation)
                    .WithMany(p => p.MobileBusinessEmployeeServiceQualification)
                    .HasForeignKey(d => d.ProductRetailCategoryFk)
                    .HasConstraintName("fk_mobile_business_employee_service_qualification_retail_cat");

                entity.HasOne(d => d.ProfessionalServiceFkNavigation)
                    .WithMany(p => p.MobileBusinessEmployeeServiceQualification)
                    .HasForeignKey(d => d.ProfessionalServiceFk)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_employee_service_qualification_service");
            });

            modelBuilder.Entity<MobileBusinessHighLevelFeatureThresoldScore>(entity =>
            {
                entity.ToTable("mobile_business_high_level_feature_thresold_score");

                entity.HasComment("For a given mobile business and high level graded feature this table holds the treshold score set by the mobile business as athreshold a retail customer must meet to be permitted to use the assocaited high level graded feature of the system - scuh as terms on purchases vs cash up front.");

                entity.HasIndex(e => e.GradedHighLevelFeatureFk)
                    .HasName("ux_mobile_business_high_level_feature_thresold_mobile_business")
                    .IsUnique();

                entity.HasIndex(e => new { e.MobileBusinessFk, e.GradedHighLevelFeatureFk })
                    .HasName("ux_mobile_business_high_level_feature_feature")
                    .IsUnique();

                entity.Property(e => e.MobileBusinessHighLevelFeatureThresoldScoreId)
                    .HasColumnName("mobile_business_high_level_feature_thresold_score_id")
                    .HasComment("System generated surrogate primary key/");

                entity.Property(e => e.GradedHighLevelFeatureFk)
                    .HasColumnName("graded_high_level_feature_fk")
                    .HasComment("Foreign key to graded high level feature.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foreign key to parent mobile business.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ThresholdScore)
                    .HasColumnName("threshold_score")
                    .HasComment("The score needed to be permitted in the platofrm feature. NOTE: alhtough the magic engine works in terms of z-scores the mobile business owners would likely do better with percentiles - thus we express the thresholds as percentiles.");

                entity.HasOne(d => d.GradedHighLevelFeatureFkNavigation)
                    .WithOne(p => p.MobileBusinessHighLevelFeatureThresoldScore)
                    .HasForeignKey<MobileBusinessHighLevelFeatureThresoldScore>(d => d.GradedHighLevelFeatureFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mobile_business_high_level_feature_thresold_score_feature");

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.MobileBusinessHighLevelFeatureThresoldScore)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mobile_business_graded_high_level_feature_thresold_score_mb");
            });

            modelBuilder.Entity<MobileBusinessHoliday>(entity =>
            {
                entity.ToTable("mobile_business_holiday");

                entity.HasComment("Scheduled days off for brick and motor components of mobile businesses. For example, a beauty salon that closes on Thanksgiving.");

                entity.HasIndex(e => new { e.MobileBusinessFk, e.HolidayDate })
                    .HasName("ux_mobile_business_holiday")
                    .IsUnique();

                entity.Property(e => e.MobileBusinessHolidayId)
                    .HasColumnName("mobile_business_holiday_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.HolidayDate)
                    .HasColumnName("holiday_date")
                    .HasColumnType("date")
                    .HasComment("Day the business, as a whole, is taking off.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foreign key to parent mobile business.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.MobileBusinessHoliday)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mobile_business_holiday_mobile_business");
            });

            modelBuilder.Entity<MobileBusinessHoursOfOperation>(entity =>
            {
                entity.ToTable("mobile_business_hours_of_operation");

                entity.HasComment("The hours of operations of all locations of a given mobile business. NOTE: general hours can be over-ridden at the business location level. NOTE: this is a one to one table but is separated for clarity, especially for cases where a mobile business does not have any brick and motor and does not have any \"hours of operaton\".");

                entity.HasIndex(e => e.MobileBusinessFk)
                    .HasName("ux_mobile_business_hours_of_operation");

                entity.Property(e => e.MobileBusinessHoursOfOperationId)
                    .HasColumnName("mobile_business_hours_of_operation_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foreign key to parent mobile business.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.WeeklyScheduleFk)
                    .HasColumnName("weekly_schedule_fk")
                    .HasComment("Foreign key to assocaited weekly schedule record.");

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.MobileBusinessHoursOfOperation)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mobile_business_hours_of_operation_mobile_business");

                entity.HasOne(d => d.WeeklyScheduleFkNavigation)
                    .WithMany(p => p.MobileBusinessHoursOfOperation)
                    .HasForeignKey(d => d.WeeklyScheduleFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_mobile_business_hours_of_operation+_weekly_schedule");
            });

            modelBuilder.Entity<MobileBusinessKeyword>(entity =>
            {
                entity.ToTable("mobile_business_keyword");

                entity.HasComment("Fore mobile businesses keywords to be found by crawlers that should qualify the mobile buiness web site to be found by search engines on searched of that keyword.");

                entity.HasIndex(e => new { e.MobileBusinessFk, e.Keyword })
                    .HasName("ux_mobile_business_keyword")
                    .IsUnique();

                entity.Property(e => e.MobileBusinessKeywordId)
                    .HasColumnName("mobile_business_keyword_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.Keyword)
                    .IsRequired()
                    .HasColumnName("keyword")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Search string to lead to the mobile business's web site.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foreign key to parent mobile business.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.MobileBusinessKeyword)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mobile_business_keyword_mobile_business");
            });

            modelBuilder.Entity<MobileBusinessKpi>(entity =>
            {
                entity.ToTable("mobile_business_kpi");

                entity.HasComment("An intersection between the mobile business and kpi tables. The existence of a record indicates that the associated mobile business is set up to track over time the associated key performance indicator. NOTE: periodic measurement of the KPI is performed in the analytics engine and the results of such periodic measures are stored in the analytics database, not here in the ODS.");

                entity.HasIndex(e => new { e.MobileBusinessFk, e.KpiFk })
                    .HasName("ux_mobile_business_kpi")
                    .IsUnique();

                entity.Property(e => e.MobileBusinessKpiId)
                    .HasColumnName("mobile_business_kpi_id")
                    .HasComment("System egenrated surrogate primary key.");

                entity.Property(e => e.ElectionDate)
                    .HasColumnName("election_date")
                    .HasColumnType("date")
                    .HasComment("Date the business elected to start tracking this KPI.");

                entity.Property(e => e.KpiFk)
                    .HasColumnName("kpi_fk")
                    .HasComment("Foreign key to associated key performance indicator.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foreign key to associated mobile business.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TargetPerformanceMeasure)
                    .HasColumnName("target_performance_measure")
                    .HasComment("The value established by/for the business owner as their goas as to the associated key performance measure.");

                entity.HasOne(d => d.KpiFkNavigation)
                    .WithMany(p => p.MobileBusinessKpi)
                    .HasForeignKey(d => d.KpiFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mobile_business_kpi_kpi");

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.MobileBusinessKpi)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mobile_business_kpi_mobile_business");
            });

            modelBuilder.Entity<MobileBusinessPlatformSupportedFormOfPayment>(entity =>
            {
                entity.ToTable("mobile_business_platform_supported_form_of_payment");

                entity.HasComment("An intersection between the mobile_business and platform_supported_form_of_payment tables, The existence of a record indicates that the associated mobile business wishes for the platform to support, for them, the associated form of payment.");

                entity.HasIndex(e => new { e.MobileBusinessFk, e.PlatformSupportedFormOfPaymentFk })
                    .HasName("ux_mobile_business_platform_supported_form_of_paym")
                    .IsUnique();

                entity.Property(e => e.MobileBusinessPlatformSupportedFormOfPaymentId)
                    .HasColumnName("mobile_business_platform_supported_form_of_payment_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foreign key to parent mobile business.");

                entity.Property(e => e.PlatformSupportedFormOfPaymentFk)
                    .HasColumnName("platform_supported_form_of_payment_fk")
                    .HasComment("Foreign key to associated form of payment.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.MobileBusinessPlatformSupportedFormOfPayment)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mobile_business_platform_supported_form_of_payment_mb");

                entity.HasOne(d => d.PlatformSupportedFormOfPaymentFkNavigation)
                    .WithMany(p => p.MobileBusinessPlatformSupportedFormOfPayment)
                    .HasForeignKey(d => d.PlatformSupportedFormOfPaymentFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_mobile_business_platform_supported_form_of_payment_psfp");
            });

            modelBuilder.Entity<MobileBusinessRecruitmentMessage>(entity =>
            {
                entity.ToTable("mobile_business_recruitment_message");

                entity.HasComment("A place to store override recruitement messages. Recruitment messages are used to invite new mobile business employees and retail customers onto the platform. They are called overrised since there are standard platform wide messages that can be used inthe absense of any messages appearing in this table.");

                entity.Property(e => e.MobileBusinessRecruitmentMessageId)
                    .HasColumnName("mobile_business_recruitment_message_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.MobileBuinessFk)
                    .HasColumnName("mobile_buiness_fk")
                    .HasComment("Foreign key to parent mobile business.");

                entity.Property(e => e.MobileBusinessEmployeeRecruitementMessage)
                    .IsRequired()
                    .HasColumnName("mobile_business_employee_recruitement_message")
                    .IsUnicode(false)
                    .HasComment("The text of the message to send to the vendor employees to recruit them onto the platform. NOTE: this constitutes an override to general mobile business employee recruitement message held at the platform level.");

                entity.Property(e => e.RetailCustomerRecruitementMessagew)
                    .IsRequired()
                    .HasColumnName("retail_customer_recruitement_messagew")
                    .IsUnicode(false)
                    .HasComment("The text of the message to send to the retail customers to recruit them onto the platform. NOTE: this constitutes an override to general mobile business employee recruitement message held at the platform level.");

                entity.HasOne(d => d.MobileBuinessFkNavigation)
                    .WithMany(p => p.MobileBusinessRecruitmentMessage)
                    .HasForeignKey(d => d.MobileBuinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_mobile_business_recruitment_message_mobile_business");
            });

            modelBuilder.Entity<MobileBusinessServiceOperatingParameters>(entity =>
            {
                entity.ToTable("mobile_business_service_operating_parameters");

                entity.HasComment("The paraters that drive system behavior for the parent mobile business as to serviceoperations. For example, whe we need to reschedule an appointment - how many miles should we look around when trying to find a suitable fill in location.");

                entity.HasIndex(e => e.MobileBusinessFk)
                    .HasName("ux_mobile_business_service_operating_parameters");

                entity.Property(e => e.MobileBusinessServiceOperatingParametersId)
                    .HasColumnName("mobile_business_service_operating_parameters_id")
                    .HasComment("System generated surrogate primry key.");

                entity.Property(e => e.BusinessLocationBasedServiceMilesDisplacement)
                    .HasColumnName("business_location_based_service_miles_displacement")
                    .HasComment("Default number of miles to look around for locations when a retail customers is asking to setup an appoint or needing to reschedule one. In the case of rescheduling this would mean looking around near the old location they had been setup for. For a new apointment this would refer to how many miles to look around there preferred location or their home.");

                entity.Property(e => e.BusinessLocationBasedServiceTimeFutureDisplacementInDays)
                    .HasColumnName("business_location_based_service_time_future_displacement_in_days")
                    .HasComment("Default number of days to look around for appointment slots when a retail customers is asking to setup an appoint or needing to reschedule one. In the case of rescheduling an appointment or creating a new one this would mean looking ahead a certin number of days.");

                entity.Property(e => e.BusinessLocationBasesServiceTimePastDisplacementInDays)
                    .HasColumnName("business_location_bases_service_time_past_displacement_in_days")
                    .HasComment("Default number of days to look backward from a scheduled appointment when we are rescheduling an appoint.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foreign key to parent mobile business.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SchedulingType)
                    .IsRequired()
                    .HasColumnName("scheduling_type")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("\"W\" means schedle work spaces\\n\"E\" means schedule employees\\n\"B\" means schedule for both - NOTE: this can depend on the particular service, hair cuts are employees and  and a qualified employee and private room for waxing.");

                entity.Property(e => e.ServiceDeliveryType)
                    .HasColumnName("service_delivery_type")
                    .HasComment("\"A\" by appointment only\\n\"W\" walkup only\\n\"B\" both");

                entity.Property(e => e.ServiceLocationType)
                    .HasColumnName("service_location_type")
                    .HasComment("\"R\" means this mobile business provides services at retail locations.\\n\"H\" means this mobile business provides services at cusotmer's homes\\n\"B\" means this mobile business provides services at retail locations and a homes\\nNOTE: In all cases this general indication can be over-riden at the service level.");

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.MobileBusinessServiceOperatingParameters)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mobile_business_service_operating_parameters_mb");
            });

            modelBuilder.Entity<MobileBusinessVirtueRanking>(entity =>
            {
                entity.ToTable("mobile_business_virtue_ranking");

                entity.HasComment("A ranking or weighting of the virtues laid down by a given mobile business. NOTE: vitues can be ranked or weighted for the purposes of evaluating employees, or customers.");

                entity.HasIndex(e => new { e.MobileBusinessFk, e.VirtueFk })
                    .HasName("ux_mobile_business_virtue_ranking")
                    .IsUnique();

                entity.Property(e => e.MobileBusinessVirtueRankingId)
                    .HasColumnName("mobile_business_virtue_ranking_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foreign key to associated mobile business.");

                entity.Property(e => e.RankOrder)
                    .HasColumnName("rank_order")
                    .HasComment("Number between 1 and 5 among the existing set of defined virtues.");

                entity.Property(e => e.RankingType)
                    .IsRequired()
                    .HasColumnName("ranking_type")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("'C' means customer\\n'E' means employee");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.VirtueFk)
                    .HasColumnName("virtue_fk")
                    .HasComment("Foreign key to assocaited virtue.");

                entity.Property(e => e.WeightingFactor)
                    .HasColumnName("weighting_factor")
                    .HasColumnType("decimal(5, 4)")
                    .HasComment("Weighting factor use for evaluating cusotmers or employees as to the given virute. NOTE: this is to be a number between 0 and 1.");

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.MobileBusinessVirtueRanking)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mobile_business_ranking_of_virtues_mobile_business");

                entity.HasOne(d => d.VirtueFkNavigation)
                    .WithMany(p => p.MobileBusinessVirtueRanking)
                    .HasForeignKey(d => d.VirtueFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mobile_business_ranking_of_virtues_vurtue");
            });

            modelBuilder.Entity<MobileBusinessVirtueScore>(entity =>
            {
                entity.ToTable("mobile_business_virtue_score");

                entity.HasComment("Intersection between the mobile busines and virtue table. Each row holds a score for the given mobile business on the measure of the given virtue.");

                entity.HasIndex(e => new { e.MobileBusinessFk, e.VirtueFk })
                    .HasName("ux_mobile_business_virtue_score")
                    .IsUnique();

                entity.Property(e => e.MobileBusinessVirtueScoreId)
                    .HasColumnName("mobile_business_virtue_score_id")
                    .HasComment("System_generated surrogate primary key.");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foreign key to parent mobile business.");

                entity.Property(e => e.Score)
                    .HasColumnName("score")
                    .HasColumnType("decimal(5, 4)");

                entity.Property(e => e.VirtueFk)
                    .HasColumnName("virtue_fk")
                    .HasComment("Foreign key to associated virtue.");

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.MobileBusinessVirtueScore)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_mobile_business_virtue_score_mobile_business");

                entity.HasOne(d => d.VirtueFkNavigation)
                    .WithMany(p => p.MobileBusinessVirtueScore)
                    .HasForeignKey(d => d.VirtueFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_mobile_business_virtue_score_virtue");
            });

            modelBuilder.Entity<Mytest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mytest");

                entity.Property(e => e.SqlString)
                    .HasColumnName("sql_string")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NotificationEmail>(entity =>
            {
                entity.ToTable("notification_email");

                entity.HasComment("One row for every notification email sent to every retail customer. NOTE: such emails are triggered by transaction processing.");

                entity.HasIndex(e => new { e.MobileBusinessFk, e.DestinationEmail, e.SendTimestamp })
                    .HasName("ux_notification_email")
                    .IsUnique();

                entity.Property(e => e.NotificationEmailId)
                    .HasColumnName("notification_email_id")
                    .HasComment("Sysem generated surrogate primary key.");

                entity.Property(e => e.DestinationEmail)
                    .IsRequired()
                    .HasColumnName("destination_email")
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasComment("Destimation email address of the email.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foreign key to assocaited mobile business.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RetailCustomerFk)
                    .HasColumnName("retail_customer_fk")
                    .HasComment("Foreign key to associated retail customer.");

                entity.Property(e => e.SendTimestamp)
                    .HasColumnName("send_timestamp")
                    .HasColumnType("datetime")
                    .HasComment("Time the email was sentout the door.");

                entity.Property(e => e.SourceEmail)
                    .IsRequired()
                    .HasColumnName("source_email")
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasComment("Source email address of the email.");

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.NotificationEmail)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_marketing_email_mobile_business");

                entity.HasOne(d => d.RetailCustomerFkNavigation)
                    .WithMany(p => p.NotificationEmail)
                    .HasForeignKey(d => d.RetailCustomerFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_marketing_email_retail_customer");
            });

            modelBuilder.Entity<OrderProcessingQueue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("order_processing_queue");

                entity.HasComment("A list of carts that are to be processed for fulfillment. For example, wher an order must be pickked up. This list of carts constitutes a work queue. Somebody has to fill a bag with the ordered goods to be picked up by the customer at one or another of the retail locations.");

                entity.Property(e => e.CartFk)
                    .HasColumnName("cart_fk")
                    .HasComment("Foreign key to parent carts that holds one or more goods that are to be pickup up at the store.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessEmployeeFk)
                    .HasColumnName("mobile_business_employee_fk")
                    .HasComment("Foreign key to the mobile business employee who has puilled this order off of the queue and is packing the items. The vision is you mark 5 as yours, they fall of the queue, they show up on your to be packed list, you pack them, put them near the cash register, mark them as complete and they fall of of your to be packed list. -- rinse and repeat --");

                entity.Property(e => e.OrderPickupQueueId)
                    .HasColumnName("order_pickup_queue_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.OrderStatus)
                    .HasColumnName("order_status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("'N' means new\\n'A' means assigned to one or another mobile business employee\\n'O' marks for fulfillment by the owner\\n'C' means completed (packed and near the cash regiser");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CartFkNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CartFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_order_pickup_queue_cart");

                entity.HasOne(d => d.MobileBusinessEmployeeFkNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MobileBusinessEmployeeFk)
                    .HasConstraintName("Fk_order_pickup_queue_mobile_business_employee");
            });

            modelBuilder.Entity<Party>(entity =>
            {
                entity.ToTable("party");

                entity.HasComment("Party represents the central ID mechanism that is used to tie all of the attributes of user.  Their personal attributes, preferences, devices, contact preferences, marketing rights, demarketing, and de-platforming statuses. NOTE: party is, in effect, an abstract class and thus does not need any business key / data attribute uniqueness constraint enforced. All inheritance hierarchy children of party are compelled to enforce uniqueness for themselves or again defer the need to their children. NOTE: although party has no real business key thinking of te case where two parties insert into party at the same time thinking to extend it into a person and a mobile business they might use the same party_id -- so we add a guid they insert and then read back to be sure they use different parties to make their person and mobeil business -- thus there is a uniqueness constraint on this GUID field, like a business key, but it is not really a business key.");

                entity.HasIndex(e => e.Uuid)
                    .HasName("ux_party")
                    .IsUnique();

                entity.Property(e => e.PartyId)
                    .HasColumnName("party_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.ApRelatedNotificationsSetting)
                    .IsRequired()
                    .HasColumnName("ap_related_notifications_setting")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')")
                    .HasComment("'Y' means yes do receive ap related notification\\n'N' means no do not send me ap related notifications");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasComment("Date the party was created.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.PurchaseAutoFillSetting)
                    .IsRequired()
                    .HasColumnName("purchase_auto_fill_setting")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')")
                    .HasComment("'Y' means yes do auto fill on purchases\\n'N' means no do not auto fill on purchases");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TokenBalance)
                    .HasColumnName("token_balance")
                    .HasComment("The number of tokens (a local legdger entry balance) that this party has. NOTE; someday this local ledger will be replaced by a distributed ledger and a real crpto currency.");

                entity.Property(e => e.Uuid)
                    .HasColumnName("uuid")
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasComment("Universally unique identifier. This is needed to make sure we can insert a row and get the key back for use in other tables within the party inheritence model.");
            });

            modelBuilder.Entity<PartyBankAccount>(entity =>
            {
                entity.ToTable("party_bank_account");

                entity.HasComment("A bank account for a party to facilitate dis-intermediated purchases.");

                entity.Property(e => e.PartyBankAccountId)
                    .HasColumnName("party_bank_account_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.AccountNumber)
                    .HasColumnName("account_number")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("The account number of the party's account at the bank identified by the routing number.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.PartyFk)
                    .HasColumnName("party_fk")
                    .HasComment("Foreign key to the party that owns the account.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RoutingNumber)
                    .HasColumnName("routing_number")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("The bank of the account encoded as an indentifier in the clearing house system.");

                entity.HasOne(d => d.PartyFkNavigation)
                    .WithMany(p => p.PartyBankAccount)
                    .HasForeignKey(d => d.PartyFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_party_bank_account_party");
            });

            modelBuilder.Entity<PartyContactMechanism>(entity =>
            {
                entity.ToTable("party_contact_mechanism");

                entity.HasComment("This party contacts");

                entity.HasIndex(e => new { e.PartyFk, e.ContactMechanismFk, e.ContactRoleFk })
                    .HasName("ux_party_contact_mechanism")
                    .IsUnique();

                entity.Property(e => e.PartyContactMechanismId)
                    .HasColumnName("party_contact_mechanism_id")
                    .HasComment("System generated surrrogate primary key.");

                entity.Property(e => e.ContactMechanismFk)
                    .HasColumnName("contact_mechanism_fk")
                    .HasComment("Foreign key to the associaed contact mechansim.");

                entity.Property(e => e.ContactRoleFk)
                    .HasColumnName("contact_role_fk")
                    .HasComment("Foreign key to applicable party role. This means that pursuant to their duties in the given role contact them in the given manner. NOTE: if party role is null this means that the contact mechanism is general.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.PartyFk)
                    .HasColumnName("party_fk")
                    .HasComment("Foreign key to parent party.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ContactMechanismFkNavigation)
                    .WithMany(p => p.PartyContactMechanism)
                    .HasForeignKey(d => d.ContactMechanismFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_party_contact_mechanism_contact_mechanism");

                entity.HasOne(d => d.PartyFkNavigation)
                    .WithMany(p => p.PartyContactMechanism)
                    .HasForeignKey(d => d.PartyFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_party_contact_mechanism_party");
            });

            modelBuilder.Entity<PartyImage>(entity =>
            {
                entity.ToTable("party_image");

                entity.HasComment("An i,age held for a party such as a hair dressor's picture or a owner's mobile business logo.");

                entity.Property(e => e.PartyImageId)
                    .HasColumnName("party_image_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.ImageDescription)
                    .IsRequired()
                    .HasColumnName("image_description")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Human readable text description of image such as logo.");

                entity.Property(e => e.PartyFk)
                    .HasColumnName("party_fk")
                    .HasComment("Foreign key to parent party.");

                entity.Property(e => e.PlatformParticipantTypeFk)
                    .HasColumnName("platform_participant_type_fk")
                    .HasComment("Foreign key to applicable platform participation type.");

                entity.Property(e => e.SavedImage)
                    .IsRequired()
                    .HasColumnName("saved_image")
                    .HasColumnType("image")
                    .HasComment("Actual displayable image.");

                entity.HasOne(d => d.PartyFkNavigation)
                    .WithMany(p => p.PartyImage)
                    .HasForeignKey(d => d.PartyFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_party_image_party");

                entity.HasOne(d => d.PlatformParticipantTypeFkNavigation)
                    .WithMany(p => p.PartyImage)
                    .HasForeignKey(d => d.PlatformParticipantTypeFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_party_image_platform_participation_type");
            });

            modelBuilder.Entity<PartyLanguagePreference>(entity =>
            {
                entity.ToTable("party_language_preference");

                entity.HasComment("For agiven pparty (read platform particupant) the human language they wish to communicate - NOTE: here in United Sates - likely the only language they could possibly communicate in.");

                entity.HasIndex(e => new { e.PartyFk, e.PlatformSupportedLanguageFk })
                    .HasName("ux_party_language_preference")
                    .IsUnique();

                entity.Property(e => e.PartyLanguagePreferenceId)
                    .HasColumnName("party_language_preference_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.PartyFk)
                    .HasColumnName("party_fk")
                    .HasComment("Foreign key to asociated party.");

                entity.Property(e => e.PlatformSupportedLanguageFk)
                    .HasColumnName("platform_supported_language_fk")
                    .HasComment("Foreign key to the preferned language of the associated polatform part.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.PartyFkNavigation)
                    .WithMany(p => p.PartyLanguagePreference)
                    .HasForeignKey(d => d.PartyFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_party_language_preference_party");

                entity.HasOne(d => d.PlatformSupportedLanguageFkNavigation)
                    .WithMany(p => p.PartyLanguagePreference)
                    .HasForeignKey(d => d.PlatformSupportedLanguageFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_party_language_preference_platform_supported_language");
            });

            modelBuilder.Entity<PartyPlatformObjectivePriority>(entity =>
            {
                entity.ToTable("party_platform_objective_priority");

                entity.HasComment("For a given party, be they an owner, mobile business employee ort a retail customer, the ordering of the priorities they have to chose from.");

                entity.HasIndex(e => new { e.PartyFk, e.PlatformObjectiveFk, e.ObjectivePriority })
                    .HasName("ux_party_platform_objective_priority")
                    .IsUnique();

                entity.Property(e => e.PartyPlatformObjectivePriorityId)
                    .HasColumnName("party_platform_objective_priority_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.ObjectivePriority)
                    .HasColumnName("objective_priority")
                    .HasComment("The order on the list for the priority among its peers set by the given party.");

                entity.Property(e => e.PartyFk)
                    .HasColumnName("party_fk")
                    .HasComment("Foreign key to parent party.");

                entity.Property(e => e.PlatformObjectiveFk)
                    .HasColumnName("platform_objective_fk")
                    .HasComment("Foerign key to assocaited objective.");

                entity.Property(e => e.PlatformParticipantTypeFk)
                    .HasColumnName("platform_participant_type_fk")
                    .HasComment("Foriegn key to applicable platform participation type.");

                entity.HasOne(d => d.PartyFkNavigation)
                    .WithMany(p => p.PartyPlatformObjectivePriority)
                    .HasForeignKey(d => d.PartyFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_party_platform_objective_priority_party");

                entity.HasOne(d => d.PlatformObjectiveFkNavigation)
                    .WithMany(p => p.PartyPlatformObjectivePriority)
                    .HasForeignKey(d => d.PlatformObjectiveFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_party_platform_objective_priorityPlatform_objective");

                entity.HasOne(d => d.PlatformParticipantTypeFkNavigation)
                    .WithMany(p => p.PartyPlatformObjectivePriority)
                    .HasForeignKey(d => d.PlatformParticipantTypeFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_party_platform_objective_priority_platform_participation_type");
            });

            modelBuilder.Entity<PartyPreference>(entity =>
            {
                entity.HasKey(e => e.PartyPreferencesId)
                    .HasName("pk_party_preferences_party_preferences_id");

                entity.ToTable("party_preference");

                entity.HasComment("Represents the global table that a customer can set for DO NOT CALL or DO NOT MARKET PREFERENCES.");

                entity.HasIndex(e => e.PartyFk)
                    .HasName("ux_party_preferences")
                    .IsUnique();

                entity.Property(e => e.PartyPreferencesId)
                    .HasColumnName("Party_Preferences_id")
                    .HasComment("System generated surrogate primary key.")
                    .ValueGeneratedNever();

                entity.Property(e => e.DoNotCallFlag)
                    .HasColumnName("do_not_call_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("'Y' means do not call. 'N'o mean ok to call.");

                entity.Property(e => e.DoNotContactFlag)
                    .HasColumnName("do_not_contact_flag")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("'Y' means do not contact. 'N'o mean ok to contact.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.PartyFk)
                    .HasColumnName("party_fk")
                    .HasComment("Foreign key to parent party.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.PartyFkNavigation)
                    .WithOne(p => p.PartyPreference)
                    .HasForeignKey<PartyPreference>(d => d.PartyFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_party_preferences_party");
            });

            modelBuilder.Entity<PartySavedCreditCard>(entity =>
            {
                entity.ToTable("party_saved_credit_card");

                entity.HasComment("For a given retail customer a saved credit card. Obviously, we save the credit card information to make future purchases less tedious.");

                entity.HasIndex(e => e.CreditCardNumber)
                    .HasName("ux_party_saved_credit_card")
                    .IsUnique();

                entity.Property(e => e.PartySavedCreditCardId)
                    .HasColumnName("party_saved_credit_card_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.BillingAddressFk)
                    .HasColumnName("billing_address_fk")
                    .HasComment("Foreign key to billing address for this credit card.");

                entity.Property(e => e.CreditCardNumber)
                    .IsRequired()
                    .HasColumnName("credit_card_number")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("The 4 sets of digits that are the credit card number and, by the way, encode the type as in visa or master card.");

                entity.Property(e => e.ExpirationDate)
                    .IsRequired()
                    .HasColumnName("expiration_date")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("The month and year the creit card expires saves as 5 character (no attempt to validate).");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.PartyFk)
                    .HasColumnName("party_fk")
                    .HasComment("Foriegn key to the party that owns this credit card account.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SecurityCode)
                    .HasColumnName("security_code")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("The 3 digit code on the back of a credit card.");

                entity.Property(e => e.ZipCode)
                    .HasColumnName("zip_code")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.BillingAddressFkNavigation)
                    .WithMany(p => p.PartySavedCreditCard)
                    .HasForeignKey(d => d.BillingAddressFk)
                    .HasConstraintName("Fk_retail_customer_saved_credit_card_post_office_address");

                entity.HasOne(d => d.PartyFkNavigation)
                    .WithMany(p => p.PartySavedCreditCard)
                    .HasForeignKey(d => d.PartyFk)
                    .HasConstraintName("Fk_party_saved_credit_card_party");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("payment");

                entity.HasComment("A transfer of funds to settle a debt.");

                entity.HasIndex(e => new { e.PartyFk, e.IdentificationNumber })
                    .HasName("ux_payment")
                    .IsUnique();

                entity.Property(e => e.PaymentId).HasColumnName("payment_id");

                entity.Property(e => e.IdentificationNumber)
                    .HasColumnName("identification_number")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasComment("Some kind of relatively (at least within the source) unique payment number like a check number,");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.PartyFk)
                    .HasColumnName("party_fk")
                    .HasComment("The foreign key to the party who is the source of the payment funds. It might be thought that this is a redundant field since sure the party invoiced, or the party closing out their cart would pay thier bill, but we need to be flexible enough to allow any party to pay someone else's bill.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RemittanceDate)
                    .HasColumnName("remittance_date")
                    .HasColumnType("date")
                    .HasComment("They date the payment instrument was sent out.");

                entity.Property(e => e.SettlementDate)
                    .HasColumnName("settlement_date")
                    .HasColumnType("date")
                    .HasComment("Date the payment cleared the bank.");

                entity.HasOne(d => d.PartyFkNavigation)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.PartyFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_payment_party");
            });

            modelBuilder.Entity<PaymentApplication>(entity =>
            {
                entity.ToTable("payment_application");

                entity.HasComment("Intersection between the invoice and payment tables. the existence of a record indicates that the associated invoice was at least partly settled from monies from the associated payments.");

                entity.HasIndex(e => new { e.InvoiceFk, e.PaymentFk })
                    .HasName("ux_invoice_payment")
                    .IsUnique();

                entity.Property(e => e.PaymentApplicationId)
                    .HasColumnName("payment_application_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.InvoiceFk)
                    .HasColumnName("invoice_fk")
                    .HasComment("Foreign key to associated invoice.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.PaymentApplicationAmount)
                    .HasColumnName("payment_application_amount")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("Amount of money from the payment (usually all of it) that is hereby being applied to the associated invoice.");

                entity.Property(e => e.PaymentFk)
                    .HasColumnName("payment_fk")
                    .HasComment("Foreign key to associated payment.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.InvoiceFkNavigation)
                    .WithMany(p => p.PaymentApplication)
                    .HasForeignKey(d => d.InvoiceFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_invoice_payment_invoice");

                entity.HasOne(d => d.PaymentFkNavigation)
                    .WithMany(p => p.PaymentApplication)
                    .HasForeignKey(d => d.PaymentFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_invoice_payment_payment");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("person");

                entity.HasComment("The person table contains information on the customer attributes captured for all Mobile Business Owners, retail cusomers and employees.  First Name and Last Name are required.  Date of Birth details are only captured for Mobile Business Owners as a result of External Identity Verification (3rd Party). NOTE: employees also count as persons. NOTE: person can not have a uniqueness constraint build in dbSchema since some of the appropriate fields are nullable. Uniqueness is added in the DDL follow on script.");

                entity.HasIndex(e => e.PlatformSmartphoneNumber)
                    .HasName("ux_person")
                    .IsUnique();

                entity.Property(e => e.PersonId)
                    .HasColumnName("person_id")
                    .HasComment("System generated surrogate key - and a foreign key to the associated parent party.")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .HasColumnType("datetime")
                    .HasComment("Date of Birth.  Captured as part of the 3rd Party verification necessary for Mobile Business Owners.");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("full_name")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("Users full name");

                entity.Property(e => e.HouseholdSegmentFk)
                    .HasColumnName("household_segment_fk")
                    .HasComment("Foreign key to applicable market segment for this subject person.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.PlatformSmartphoneNumber)
                    .IsRequired()
                    .HasColumnName("platform_smartphone_number")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(('F'+substring(CONVERT([char],rand()),(3),(6)))+substring(CONVERT([char],rand()),(3),(6)))");

                entity.Property(e => e.PlatformUserName)
                    .IsRequired()
                    .HasColumnName("platform_user_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Platform user ID - there main email. NOTE: if the person participates as a mobile business ownere three times, plus n employee of another business plus as a retail customer of 4 mobile businesses; they should have 5 emails - 3 for their 3 businesses, 1 for their role as the employee of some one else's mobile business and 1 as a customer of 4 mobile businesses.\\n\\nFrom the platforms point of view this one person is 5 distanct persons, since they are playing 5 different roles.");

                entity.Property(e => e.PrimaryContactMechanismFk)
                    .HasColumnName("primary_contact_mechanism_fk")
                    .HasComment("One or another contact mechanism for the person, such as phyical address or deive iP address. This is the primary mechainsim.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SubSegmentFk)
                    .HasColumnName("sub_segment_fk")
                    .HasComment("Foreign key to applicable sub segment for the subject person.");

                entity.HasOne(d => d.PersonNavigation)
                    .WithOne(p => p.Person)
                    .HasForeignKey<Person>(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_person_party");

                entity.HasOne(d => d.PrimaryContactMechanismFkNavigation)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.PrimaryContactMechanismFk)
                    .HasConstraintName("fk_person_post_office_adddress");

                entity.Property(e => e.RefreshToken)
                    .HasColumnName("refresh_token")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("The refresh token used for authentication once the Token expires.");
            });

            modelBuilder.Entity<PersonAsUser>(entity =>
            {
                entity.ToTable("person_as_user");

                entity.HasComment("A combination of a person ID, (an owner, mobile busines employee, platform employee or retail customer) a mobile business ID, a device_ID and anumber for the platform itself. This table is at the user/device. So, a UUID in this table can serve as an externalizable ID. NOTE: !!! this is a dervied table. The point of the table is to map back and forth between the a moble ap usable UID and a user of the platform adequate defined in terms adequate for the database.");

                entity.Property(e => e.PersonAsUserId)
                    .HasColumnName("person_as_user_id")
                    .HasComment("System generated surrogte primary key.");

                entity.Property(e => e.DeviceFk)
                    .HasColumnName("device_fk")
                    .HasComment("Foreign key to associated device.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foreign key to associated mobile business. NOTE: this field is nullable since the person can be a platform employee in which case no mobile business in particular applies.");

                entity.Property(e => e.PasswordBin).HasColumnName("password_bin");

                entity.Property(e => e.PasswordSalt).HasColumnName("password_salt");

                entity.Property(e => e.PersonFk)
                    .HasColumnName("person_fk")
                    .HasComment("Foriegn key to associated person.");

                entity.Property(e => e.PersonStatus)
                    .HasColumnName("person_status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')")
                    .HasComment("'P' means prospect\\n'A' means active user\\n'D' means deplatformed\\nNOTE: deplatforming allows us to block access while leaving all data in place.");

                entity.Property(e => e.PlatformParticipantTypeFk)
                    .HasColumnName("platform_participant_type_fk")
                    .HasComment("Foreign key to applicable platform participation type.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Uuid)
                    .HasColumnName("uuid")
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Universally unique identifier.");

                entity.HasOne(d => d.DeviceFkNavigation)
                    .WithMany(p => p.PersonAsUser)
                    .HasForeignKey(d => d.DeviceFk)
                    .HasConstraintName("fk_person_as_user_device");

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.PersonAsUser)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .HasConstraintName("fk_person_as_user_mobile_business");

                entity.HasOne(d => d.PersonFkNavigation)
                    .WithMany(p => p.PersonAsUser)
                    .HasForeignKey(d => d.PersonFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_person_as_user_person");

                entity.HasOne(d => d.PlatformParticipantTypeFkNavigation)
                    .WithMany(p => p.PersonAsUser)
                    .HasForeignKey(d => d.PlatformParticipantTypeFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_person_as_user_platform_participation_type");
            });

            modelBuilder.Entity<PlatformAssetClass>(entity =>
            {
                entity.ToTable("platform_asset_class");

                entity.HasComment("The standard set of asset classes that seed all mobile bsuiness asset classes, that have assets.");

                entity.HasIndex(e => e.ClassName)
                    .HasName("ux_platform_asset_class")
                    .IsUnique();

                entity.Property(e => e.PlatformAssetClassId)
                    .HasColumnName("platform_asset_class_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.ClassName)
                    .HasColumnName("class_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("A human readable text name of the asset class.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<PlatformCustomerSurvey>(entity =>
            {
                entity.ToTable("platform_customer_survey");

                entity.HasComment("A questionnaire for the customer given by the platform itself to a set of the retail customers either passively or actively in both cases for marketing purposes or for special qualification purposes such as covid-19 questions that qualify a retail customer to receive service at all.");

                entity.HasIndex(e => e.SurveyName)
                    .HasName("ux_platform_customer_survey")
                    .IsUnique();

                entity.Property(e => e.PlatformCustomerSurveyId)
                    .HasColumnName("platform_customer_survey_id")
                    .HasComment("System generated surrogate primry key.");

                entity.Property(e => e.AppliesByDefaultFlag)
                    .IsRequired()
                    .HasColumnName("applies_by_default_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("'Y'es / 'N'o flag to indicate if the survey should be applied to all mobile business customers. NOTE: where the test is not a default one, then the mobile businesses to which the survey applies are documented in a detail table platform_customer_survey_mobile_business.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SurveyName)
                    .IsRequired()
                    .HasColumnName("survey_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Human readable text name for survey.");

                entity.Property(e => e.SurveyTrigger)
                    .HasColumnName("survey_trigger")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("How often should the survey arise? Upon every check out. Upon the user reporting receipt of goods, etc.");
            });

            modelBuilder.Entity<PlatformEmployee>(entity =>
            {
                entity.ToTable("platform_employee");

                entity.HasComment("Our employees. NOTE: there is no uniquness constraint / busines key on this table since it inherits it's uniqueness from the parent person.");

                entity.Property(e => e.PlatformEmployeeId)
                    .HasColumnName("platform_employee_id")
                    .HasComment("System generated surrogate primary key.")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.PlatformEmployeeNavigation)
                    .WithOne(p => p.PlatformEmployee)
                    .HasForeignKey<PlatformEmployee>(d => d.PlatformEmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_platform_employee_person");
            });

            modelBuilder.Entity<PlatformError>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("platform_error");

                entity.HasComment("A set of runtime errors held in the database to facilitate setting the messages at will without changing the deployed code.");

                entity.Property(e => e.ErrorCode)
                    .IsRequired()
                    .HasColumnName("error_code")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("A code used by the UI to refer to the error.");

                entity.Property(e => e.ErrorContext)
                    .IsRequired()
                    .HasColumnName("error_context")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("A desription of the error as well as when the error arises in the course of operating the platform.");

                entity.Property(e => e.ErrorMessage)
                    .IsRequired()
                    .HasColumnName("error_message")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("The text message to be displayed in the event that the error occurrs on the platform.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.PlatformErrorId)
                    .HasColumnName("platform_error_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<PlatformMessage>(entity =>
            {
                entity.ToTable("platform_message");

                entity.HasComment("A message sent from the platform - such as a de-platform notification : or an analytics driven notification - to a platform memeber such as a mobile business owner, a mobile business employee or a retail customer. NOTE: this table constitutes a historical record of those messages.");

                entity.HasIndex(e => new { e.MessageCategoryFk, e.MessageRecipientFk, e.SendTimestamp })
                    .HasName("ux_platform_message")
                    .IsUnique();

                entity.Property(e => e.PlatformMessageId)
                    .HasColumnName("platform_message_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MessageCategoryFk)
                    .HasColumnName("message_category_fk")
                    .HasComment("Foreign key to applicable message category.");

                entity.Property(e => e.MessageRecipientFk)
                    .HasColumnName("message_recipient_fk")
                    .HasComment("Foreign key to the party receiving the message. NOTE: where that pary is a business organization we will need to find the authorized agent to receive messages of this type.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SendTimestamp)
                    .HasColumnName("send_timestamp")
                    .HasColumnType("datetime")
                    .HasComment("The moment the message was sent. NOTE: Greenich standard time.");

                entity.Property(e => e.SourceSubSystem)
                    .HasColumnName("source_sub_system")
                    .HasComment("Text description of the origin of the message. For example \"simple trigger\" for a de-platform notification or \"Magic Engine\" for a report on the outcome from an authorized offer.");

                entity.Property(e => e.TextMessage)
                    .IsRequired()
                    .HasColumnName("text_message")
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasComment("The human readable message text.");

                entity.HasOne(d => d.MessageCategoryFkNavigation)
                    .WithMany(p => p.PlatformMessage)
                    .HasForeignKey(d => d.MessageCategoryFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_platform_message_message_category");

                entity.HasOne(d => d.MessageRecipientFkNavigation)
                    .WithMany(p => p.PlatformMessage)
                    .HasForeignKey(d => d.MessageRecipientFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_platform_platform_message_party");
            });

            modelBuilder.Entity<PlatformMessageCategory>(entity =>
            {
                entity.ToTable("platform_message_category");

                entity.HasComment("The list of message categories such as deplatforn notification, which we need in order to know who to send different types of messages too.");

                entity.HasIndex(e => e.CategoryName)
                    .HasName("ux_platform_message_category")
                    .IsUnique();

                entity.Property(e => e.PlatformMessageCategoryId)
                    .HasColumnName("platform_message_category_id")
                    .HasComment("System generated surrogate key.");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnName("category_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Human readable text name of category - such as deplatform notification.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<PlatformObjective>(entity =>
            {
                entity.ToTable("platform_objective");

                entity.HasComment("The set of objectives that we have laid down and programed the platform to be able to seek for platform participants such as mobile business owmers, employees of those businesses and retail customers, and the then the platform participant to set up their own prorities as to these objectives.");

                entity.Property(e => e.PlatformObjectiveId)
                    .HasColumnName("platform_objective_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.BusinessObjectiveCode)
                    .IsRequired()
                    .HasColumnName("business_objective_code")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("A three letter code used to link the behavior of the magic engine to the objectives laid down by the mobile business owner.");

                entity.Property(e => e.BusinessObjectiveDescription)
                    .IsRequired()
                    .HasColumnName("business_objective_description")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Human readable text description of business objective.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.PlatformParticipantTypeFk)
                    .HasColumnName("platform_participant_type_fk")
                    .HasComment("Foreign key to applicable platform participation type such as owner.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.PlatformParticipantTypeFkNavigation)
                    .WithMany(p => p.PlatformObjective)
                    .HasForeignKey(d => d.PlatformParticipantTypeFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_platform_objective_platform_participation_type");
            });

            modelBuilder.Entity<PlatformOperationalFunction>(entity =>
            {
                entity.ToTable("platform_operational_function");

                entity.HasComment("The set of functions that can be performed in the system.");

                entity.HasIndex(e => e.FunctionName)
                    .HasName("ux_operational_function")
                    .IsUnique();

                entity.Property(e => e.PlatformOperationalFunctionId)
                    .HasColumnName("platform_operational_function_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("date")
                    .HasComment("The date the function was formally added to the system for purposes of controlling access.");

                entity.Property(e => e.FunctionName)
                    .IsRequired()
                    .HasColumnName("function_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Human readable text name of platform operational function.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<PlatformParticipantType>(entity =>
            {
                entity.ToTable("platform_participant_type");

                entity.HasComment("A list of platform participation roles such as mobile business owner, or retail customer.");

                entity.HasIndex(e => e.ParticipantTypeIndicator)
                    .HasName("ux_platform_participant_type")
                    .IsUnique();

                entity.HasIndex(e => e.TextDescription)
                    .HasName("ux2_platform_participant_type")
                    .IsUnique();

                entity.Property(e => e.PlatformParticipantTypeId)
                    .HasColumnName("platform_participant_type_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.ParticipantTypeIndicator)
                    .IsRequired()
                    .HasColumnName("participant_type_indicator")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("3 character code for participant type such as OWN for mobile business owner.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TextDescription)
                    .IsRequired()
                    .HasColumnName("text_description")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Text explanation of the participation type code.");
            });

            modelBuilder.Entity<PlatformPersonToPersonFollow>(entity =>
            {
                entity.ToTable("platform_person_to_person_follow");

                entity.HasComment("A person can follow a person in the platform. The main use case here is for a retail customer to follow a mobile business employee and recieve recomendations for goods and or services. The retail customer to buy those goods and or service and for the employeeto receive a sales commission.");

                entity.HasIndex(e => new { e.InfluencerFk, e.FollowerFk })
                    .HasName("ux_platform_person_to_person_follow")
                    .IsUnique();

                entity.Property(e => e.PlatformPersonToPersonFollowId)
                    .HasColumnName("platform_person_to_person_follow_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.FollowerFk)
                    .HasColumnName("follower_fk")
                    .HasComment("Foreign key to the person being followed.");

                entity.Property(e => e.InfluencerFk)
                    .HasColumnName("influencer_fk")
                    .HasComment("Foreign key to the person being followed.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FollowerFkNavigation)
                    .WithMany(p => p.PlatformPersonToPersonFollow)
                    .HasForeignKey(d => d.FollowerFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_platform_follow_follower");

                entity.HasOne(d => d.InfluencerFkNavigation)
                    .WithMany(p => p.PlatformPersonToPersonFollow)
                    .HasForeignKey(d => d.InfluencerFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_platform_follow_person");
            });

            modelBuilder.Entity<PlatformRecruitementMessage>(entity =>
            {
                entity.ToTable("platform_recruitement_message");

                entity.HasComment("Default messages to be sent to recrit mobile business employees and retail customers onto the platform. NOTE: these messages can be edited by the mobile business owner prior to being sent out. NOTE 2: there is no need for a uniqueness constraint on this table since it is only supposed to have 1 row in the first place, and is loaded byt the boot strap script and can not be modified by the application.");

                entity.Property(e => e.PlatformRecruitementMessageId)
                    .HasColumnName("platform_recruitement_message_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessEmployeeRecruitementMessage)
                    .IsRequired()
                    .HasColumnName("mobile_business_employee_recruitement_message")
                    .IsUnicode(false)
                    .HasComment("The text to be sent to employees to \"invite\" them onto the platform.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RetailCustomerRecruitementMessage)
                    .IsRequired()
                    .HasColumnName("retail_customer_recruitement_message")
                    .IsUnicode(false)
                    .HasComment("The text to be sent to retail customers to invite them onto the platform.");
            });

            modelBuilder.Entity<PlatformRole>(entity =>
            {
                entity.ToTable("platform_role");

                entity.HasComment("This table defines all of the roles a user has within the platform.");

                entity.HasIndex(e => e.RoleDescription)
                    .HasName("ux_platform_role")
                    .IsUnique();

                entity.Property(e => e.PlatformRoleId)
                    .HasColumnName("platform_role_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("date")
                    .HasComment("The date this role was added o the system.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RoleDescription)
                    .HasColumnName("role_description")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasComment("Human readable text description of the role.");
            });

            modelBuilder.Entity<PlatformScreensMainColor>(entity =>
            {
                entity.ToTable("platform_screens_main_color");

                entity.HasComment("The color options for the screen on the mobile businesses on the platform.");

                entity.Property(e => e.PlatformScreensMainColorId)
                    .HasColumnName("platform_screens_main_color_id")
                    .HasComment("System generated surrogate promary id.");

                entity.Property(e => e.ColorImage)
                    .HasColumnName("color_image")
                    .HasColumnType("image")
                    .HasComment("Viewable swatch of the color.");

                entity.Property(e => e.HexidecimalCode)
                    .IsRequired()
                    .HasColumnName("hexidecimal_code")
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasComment("Code for the programmers to use to reference hte color.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<PlatformStoreTheme>(entity =>
            {
                entity.ToTable("platform_store_theme");

                entity.HasComment("The set of mobile business looks we make available.");

                entity.HasIndex(e => e.PlatformStoreThemeId)
                    .HasName("Unq_platform_store_theme_platform_store_theme_id")
                    .IsUnique();

                entity.Property(e => e.PlatformStoreThemeId)
                    .HasColumnName("platform_store_theme_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TextDescription)
                    .IsRequired()
                    .HasColumnName("text_description")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Human readable text description of the theme.");

                entity.Property(e => e.ThemeImage)
                    .HasColumnName("theme_image")
                    .HasColumnType("image")
                    .HasComment("An example image of the theme for the owner to examine.");
            });

            modelBuilder.Entity<PlatformSupportedFormOfPayment>(entity =>
            {
                entity.HasKey(e => e.PlatormSupportedFormOfPaymentId)
                    .HasName("Pk_platorm_supported_form_of_payment_platorm_supported_form_of_payment_id");

                entity.ToTable("platform_supported_form_of_payment");

                entity.HasComment("A list of the forms of payment that are permitted within the patform. The list is useful, among other things, for allowing a retail customer to set their prefered/default form of payment.");

                entity.HasIndex(e => e.TextDescription)
                    .HasName("ux_platorm_supported_form_of_payment")
                    .IsUnique();

                entity.Property(e => e.PlatormSupportedFormOfPaymentId)
                    .HasColumnName("platorm_supported_form_of_payment_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TextDescription)
                    .IsRequired()
                    .HasColumnName("text_description")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("HUman readable text description of form of payment such as - credit card");
            });

            modelBuilder.Entity<PlatformSupportedLanguage>(entity =>
            {
                entity.ToTable("platform_supported_language");

                entity.HasComment("The set of languiages the platform currently supports.");

                entity.Property(e => e.PlatformSupportedLanguageId)
                    .HasColumnName("platform_supported_language_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LanguageCode)
                    .IsRequired()
                    .HasColumnName("language_code")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Standard code for the lanugage such as ENGL.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TextName)
                    .HasColumnName("text_name")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("Full name of language such as French.");
            });

            modelBuilder.Entity<PostOfficeAddress>(entity =>
            {
                entity.ToTable("post_office_address");

                entity.HasComment("A post office address. Can be mailing only or physical. NOTE: Uniqueness constraint is added  after dbSchema since it involves a derived field.");

                entity.HasIndex(e => new { e.AddressLine1, e.AddressLine2, e.ZipCode })
                    .HasName("ux_post_office_address")
                    .IsUnique();

                entity.Property(e => e.PostOfficeAddressId)
                    .HasColumnName("post_office_address_id")
                    .HasComment("System generated surrogate primary key.")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasColumnName("address_line_1")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Line 1 of address");

                entity.Property(e => e.AddressLine2)
                    .HasColumnName("address_line_2")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Line 2 of address");

                entity.Property(e => e.AddressLine3)
                    .HasColumnName("address_line_3")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Line 3 of address");

                entity.Property(e => e.AddressType)
                    .IsRequired()
                    .HasColumnName("address_type")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('P')")
                    .HasComment("'M' means mailing only such as a post office box\\n'P' means physical :: also default shipping\\n'S' means special shipping address");

                entity.Property(e => e.AddrressSource)
                    .HasColumnName("addrress_source")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("'P' - provided by the person\\n'IL' - inferred from reverse geo-coding of their phone latitude longitude data.\\n'IP' - inferred from the phone number");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("City of address");

                entity.Property(e => e.CountryCd)
                    .HasColumnName("country_cd")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("Country code of address, such as USA");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasColumnType("decimal(9, 6)")
                    .HasComment("location latitude");

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasColumnType("decimal(9, 6)")
                    .HasComment("location longitude");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.StatePostalCode)
                    .HasColumnName("state_postal_code")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("State of address, such as CA");

                entity.Property(e => e.VerifiedDt)
                    .HasColumnName("verified_dt")
                    .HasColumnType("datetime")
                    .HasComment("Date the address was last veritified with the post office.");

                entity.Property(e => e.ZipCode)
                    .HasColumnName("zip_code")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("postal zip length 9 no formatting.");

                entity.HasOne(d => d.PostOfficeAddressNavigation)
                    .WithOne(p => p.PostOfficeAddress)
                    .HasForeignKey<PostOfficeAddress>(d => d.PostOfficeAddressId)
                    .HasConstraintName("fk_address_contact_mechansim");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.HasComment("A good, service or bundle offerred on the market by a mobile business. NOTE: also bundles are just products.");

                entity.HasIndex(e => new { e.MobileBusinessFk, e.TextDescription })
                    .HasName("ux_product")
                    .IsUnique();

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.CommissionAmount)
                    .HasColumnName("commission_amount")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("A dollar commission to pay to a mobile business agent especially for services performed by the mobile business agent; especially where those services are both sold by and performed by the mobile business agent. NOTE: this commission amount very often does not apply at all and at the other end of the spectrum can be over-written by more complex cases where different mobile business agents get different commission amounts.");

                entity.Property(e => e.CommissionRate)
                    .HasColumnName("commission_rate")
                    .HasColumnType("decimal(5, 4)")
                    .HasComment("A proportion of the gross to pay to a mobile business agent especially for services performed by the mobile business agent; especially where those services are both sold by and performed by the mobile business agent. NOTE: this commission rate very often does not apply at all and at the other end of the spectrum can be over-written by more complex cases where different mobile business agents get different commission rates.");

                entity.Property(e => e.CommissionRatio)
                    .HasColumnName("commission_ratio")
                    .HasColumnType("decimal(5, 4)")
                    .HasComment("Portion of the gross revenue to be paid to the mobile business employee as a commission.");

                entity.Property(e => e.DefaultPurchaseMode)
                    .HasColumnName("default_purchase_mode")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("'P' means pick up \\n'D' means delivery\\n'S' means ship\\nNOTE: this is important for payments since a cart when closed out requires pimmediatee payment (or at least terms) for pick up and delivered items like pet snakes and pizzas; but settlement for items to be shipped only takes place upon shipment - before then we only reserve room on creedit cards our our own gift card \"accounts\".");

                entity.Property(e => e.Dislikes)
                    .HasColumnName("dislikes")
                    .HasComment("Dislikes over the last 12 months.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.Likes)
                    .HasColumnName("likes")
                    .HasComment("Likes posted the last 12 mmonths.");

                entity.Property(e => e.LoyaltyPointsToAccrue)
                    .HasColumnName("loyalty_points_to_accrue")
                    .HasComment("The number of loyal points a retail customer gets by purvchasing 1 of this product.");

                entity.Property(e => e.MaximumPrice)
                    .HasColumnName("maximum_price")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("Highest price the platform is permitted to sell the product for,");

                entity.Property(e => e.MinimumPrice)
                    .HasColumnName("minimum_price")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("Lowest price the platform is permitted to sell the product for,");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foriegn key to parent mobile business.");

                entity.Property(e => e.OkForDeliveryFlag)
                    .IsRequired()
                    .HasColumnName("ok_for_delivery_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("'Y' means the mobile business will deliver the good.\\n'N'' means they will not");

                entity.Property(e => e.OkForPickupFlag)
                    .IsRequired()
                    .HasColumnName("ok_for_pickup_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("'Y' means the product can be picked up at one or another retail location.");

                entity.Property(e => e.OkForShipFlag)
                    .IsRequired()
                    .HasColumnName("ok_for_ship_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("'Y' means the mobile business will ship the good.\\n'N'' means they will not");

                entity.Property(e => e.PhysicalOrVirtualIndicator)
                    .IsRequired()
                    .HasColumnName("physical_or_virtual_indicator")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("'P'hysical or 'V'irtual good or service. NOTE: it is tempting to create a category of B - both for a cooking class that can be an on-line video as well as an in prson class ut it has been decided that it is best to list two products. An online one and a classroom one.");

                entity.Property(e => e.PictureUrl)
                    .HasColumnName("picture_url")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ProductRetailCategoryFk)
                    .HasColumnName("product_retail_category_fk")
                    .HasComment("Foreign key to applicable product retail category.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ServiceLifeExactOrCategoryFlag)
                    .HasColumnName("service_life_exact_or_category_flag")
                    .HasComment("\"Y\" means the service life for exact product or for any product in the category. For example, once you buy piano you are unlikely to buy another. However, once you buy a italian meal you may very well buy another restuarant meal the next day but not another italian meal for a week. --- this implies the need to establish service life categories and sub-categories, but this will need to happen in the analytics DB ---");

                entity.Property(e => e.ServiceLifeInDays)
                    .HasColumnName("service_life_in_days")
                    .HasComment("The number of days the product is expected to remain in service before it needs to be replaced. A piano may remain in service for 7000 days whereas a shirt might be 1000 and a meal might be a week meaning the time before re-order is likely. A meal gets a week since it is unlikely a person will order the same kind of food twice in a week.");

                entity.Property(e => e.TaxItemTypeFk)
                    .HasColumnName("tax_item_type_fk")
                    .HasComment("Foreign key to the tax item type that applies to product (good or service). NOTE: field is nullable since the type can be set at the product category level and there may be no need to over-rise that at the product level.");

                entity.Property(e => e.TextDescription)
                    .HasColumnName("text_description")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Human readable text description of the product.");

                entity.Property(e => e.UnitOfMeasure)
                    .HasColumnName("unit_of_measure")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("The unit of measure that is the default for the sale of this product - the unit applicable to all sales implicitly. NOTE: unit of measure can be blank indicating that there is more than one unit of measure and unit of measure is treated as a product dimension perhaps with different prices per unit of measure. In such a case the product table price field should be null - since price could mean nothing in the absense of a selected uit of measure.");

                entity.Property(e => e.VisableFlag)
                    .HasColumnName("visable_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("A flag to indicate if the product is drectly available for sale. This might seem to be a silly question, but a product may exist only as a component of a bundle in which case it should be 'N' - not visable.");

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_product_mobile_business");

                entity.HasOne(d => d.ProductRetailCategoryFkNavigation)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.ProductRetailCategoryFk)
                    .HasConstraintName("fk_product_product_retail_category");

                entity.HasOne(d => d.TaxItemTypeFkNavigation)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.TaxItemTypeFk)
                    .HasConstraintName("fk_product_tax_item_type");
            });

            modelBuilder.Entity<ProductApplicableDimension>(entity =>
            {
                entity.HasKey(e => e.ProductProductDimesionId)
                    .HasName("pk_product_product_dimension_product_product_dimesion_id");

                entity.ToTable("product_applicable_dimension");

                entity.HasComment("An intersection between the product and mobile business dimension tables. The existence of a record indicates that the associated product must have a value specified for the associated mobile business dimension in order to be a fulfillable order.");

                entity.HasIndex(e => new { e.ProductFk, e.DimensionFk })
                    .HasName("ux_product_applicable_dimension")
                    .IsUnique();

                entity.Property(e => e.ProductProductDimesionId)
                    .HasColumnName("product_product_dimesion_id")
                    .HasComment("System generated surrogate priimary key.");

                entity.Property(e => e.DefaultDimensionValueFk)
                    .HasColumnName("default_dimension_value_fk")
                    .HasComment("Foreign key to default dimension value that the product page comes up set to. NOTE: this dimension value constitutes an over-ride to the default dimension value set at the dimension level which applies to all products that participate in the associated parent dimension. NOTE 2: obviously this field is nullable since a product may get it's default value for a given dimension at the dimension level and thus need not get it at the product level.");

                entity.Property(e => e.DimensionFk)
                    .HasColumnName("dimension_fk")
                    .HasComment("Foreign key to associated dimension.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.ProductFk)
                    .HasColumnName("product_fk")
                    .HasComment("Foreign key to associated product.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.DefaultDimensionValueFkNavigation)
                    .WithMany(p => p.ProductApplicableDimension)
                    .HasForeignKey(d => d.DefaultDimensionValueFk)
                    .HasConstraintName("fk_product_product_dimension_default_value");

                entity.HasOne(d => d.DimensionFkNavigation)
                    .WithMany(p => p.ProductApplicableDimension)
                    .HasForeignKey(d => d.DimensionFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_product_product_dimension_dimension");

                entity.HasOne(d => d.ProductFkNavigation)
                    .WithMany(p => p.ProductApplicableDimension)
                    .HasForeignKey(d => d.ProductFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_product_product_dimension_product");
            });

            modelBuilder.Entity<ProductCustomerReview>(entity =>
            {
                entity.ToTable("product_customer_review");

                entity.HasComment("An intersection between the product and retail customer tables. Each row holds a review of a product by a retail customer (a like or dislike) given on a particular year and month.");

                entity.HasIndex(e => new { e.ProductFk, e.RetailCustomerFk, e.ReviewTimestamp })
                    .HasName("ux_product_customer_review")
                    .IsUnique();

                entity.Property(e => e.ProductCustomerReviewId)
                    .HasColumnName("product_customer_review_id")
                    .HasComment("System generated surrgate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.ProductFk)
                    .HasColumnName("product_fk")
                    .HasComment("Foreign key to parent product.");

                entity.Property(e => e.Rating)
                    .IsRequired()
                    .HasColumnName("rating")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("'L'ike or 'D'is-like.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RetailCustomerFk)
                    .HasColumnName("retail_customer_fk")
                    .HasComment("Foreign key to retail customer providing the review.");

                entity.Property(e => e.ReviewTimestamp)
                    .HasColumnName("review_timestamp")
                    .HasColumnType("datetime")
                    .HasComment("The moment the review was submitted.");

                entity.Property(e => e.TextMessage)
                    .HasColumnName("text_message")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("Short typed in message from the reatil customer to explain their rating.");

                entity.HasOne(d => d.ProductFkNavigation)
                    .WithMany(p => p.ProductCustomerReview)
                    .HasForeignKey(d => d.ProductFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_product_customer_review_product");

                entity.HasOne(d => d.RetailCustomerFkNavigation)
                    .WithMany(p => p.ProductCustomerReview)
                    .HasForeignKey(d => d.RetailCustomerFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_product_customer_review_retail_customer");
            });

            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.ToTable("product_image");

                entity.HasComment("The images for products hjeld in a separate table so that queries on products not concerned with images are not slawed by the images. NOTE: a 1 to 1 table.");

                entity.Property(e => e.ProductImageId)
                    .HasColumnName("product_image_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.ImageVettedIndicator)
                    .IsRequired()
                    .HasColumnName("image_vetted_indicator")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("\"Y\" means the image has been vetted and is appropriate\\n\"N\" means the image is not yet vetted\\n\"R\" means the image failed vetting and has been removed");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.ProductFk)
                    .HasColumnName("product_fk")
                    .HasComment("Foreign key to parent product.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RetailImage)
                    .IsRequired()
                    .HasColumnName("retail_image")
                    .HasColumnType("image")
                    .HasComment("Image of the parent product suitable for display for sale.");

                entity.HasOne(d => d.ProductFkNavigation)
                    .WithMany(p => p.ProductImage)
                    .HasForeignKey(d => d.ProductFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_product_image_product");
            });

            modelBuilder.Entity<ProductQuantityDiscount>(entity =>
            {
                entity.ToTable("product_quantity_discount");

                entity.HasComment("A list of products subject to quantity discount. I refer to the stadnard practice of $4 each 3 for $10.");

                entity.Property(e => e.ProductQuantityDiscountId)
                    .HasColumnName("product_quantity_discount_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.ProductFk)
                    .HasColumnName("product_fk")
                    .HasComment("Foreign key to parent product.");

                entity.Property(e => e.QualifyingQuantity)
                    .HasColumnName("qualifying_quantity")
                    .HasComment("The number of items it take to qualify for the reduced price.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ReducedPriceForTheSet)
                    .HasColumnName("reduced_price_for_the_set")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("The $10 price you pay for 3 products that are otherwise $4 each. NOTE: a 4th items woudl be $10/3 (the qualifying quantity).");

                entity.HasOne(d => d.ProductFkNavigation)
                    .WithMany(p => p.ProductQuantityDiscount)
                    .HasForeignKey(d => d.ProductFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_product_quantity_discount_product");
            });

            modelBuilder.Entity<ProductRetailCategory>(entity =>
            {
                entity.ToTable("product_retail_category");

                entity.HasComment("A mobile business division of their products. NOTE: this division can be a hierarchy thus the table is self referencing. NOTE: this table does not have a uniqueness constrint / business key in dbSchema because dbSchema can't handle this complex case that depends ona derived column. This table is given a unique consraint in a dbSchema DDL tack on DDL script.");

                entity.HasIndex(e => new { e.MobileBusinessFk, e.CategoryName })
                    .HasName("ux_product_retail_category")
                    .IsUnique();

                entity.Property(e => e.ProductRetailCategoryId)
                    .HasColumnName("product_retail_category_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("category_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Text name of product category such as shoes.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("A foreign key to a parent mobile business who divides their offering into categories,");

                entity.Property(e => e.NormalServiceDurationInMinutes)
                    .HasColumnName("normal_service_duration_in_minutes")
                    .HasComment("A product category can refer to a class of services rather than a category of goods. In such a case we might wish to record a standard service delivery duration of rthis whole set of services -- that may be over-riden at the service level.");

                entity.Property(e => e.ParentProductRetailCategoryFk)
                    .HasColumnName("parent_product_retail_category_fk")
                    .HasComment("A nullable pointer to a higher level category from a child category. Obviously, the foreign key is nullable since some categories must be the top ones.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RefundAndReturnPolicyGraphic)
                    .HasColumnName("refund_and_return_policy_graphic")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("The refund and return policy for all items of this category as a displayable graphic.");

                entity.Property(e => e.RestockingFeeAsARatio)
                    .HasColumnName("restocking_fee_as_a_ratio")
                    .HasColumnType("decimal(5, 4)")
                    .HasComment("The portion f the price that is not refunded as a restocking fee. 15% would be represented as 0.15 (the decimal representation). NOTE: this field is nullable since a category may be about or at least may include services which can not, in any meaningful way, be restocked.");

                entity.Property(e => e.ReturnAddressFk)
                    .HasColumnName("return_address_fk")
                    .HasComment("Foreign key to return address that applies for products of this category. NOTE: this field is nullable since some product are not subject to return and even if they are this field represent an over-ride compared to the mobile business' general return address.");

                entity.Property(e => e.TaxItemTypeFk)
                    .HasColumnName("tax_item_type_fk")
                    .HasComment("Foriegn key to tax item type. NOTE: an entry here constitutes an over-ride to the indication held at the mobile business level; and where there are sub-categories, obviously, at each level non null entries would constitute over-rides to the parent level tan item type. NOTE 2: the field can be null thus leaving determination to the product level or the mobiel business level.");

                entity.Property(e => e.WhoPaysShipping)
                    .HasColumnName("who_pays_shipping")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("'C' - customer or 'B' - business. NOTE: this field can be null for cases of sub-categories. In such cases null would mean that the sub-category uses the parent categories instructions as to who pays shipping; and for such sub-categories a non null value would be an over-ride of the applicable parent categories instructions as to who pays shipping.");

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.ProductRetailCategory)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_product_category_mobile_business");

                entity.HasOne(d => d.ParentProductRetailCategoryFkNavigation)
                    .WithMany(p => p.InverseParentProductRetailCategoryFkNavigation)
                    .HasForeignKey(d => d.ParentProductRetailCategoryFk)
                    .HasConstraintName("fk_product_retail_category_parent_category");

                entity.HasOne(d => d.ReturnAddressFkNavigation)
                    .WithMany(p => p.ProductRetailCategory)
                    .HasForeignKey(d => d.ReturnAddressFk)
                    .HasConstraintName("fk_product_retail_category_return_address");

                entity.HasOne(d => d.TaxItemTypeFkNavigation)
                    .WithMany(p => p.ProductRetailCategory)
                    .HasForeignKey(d => d.TaxItemTypeFk)
                    .HasConstraintName("fk_product_category_tax_item_type");
            });

            modelBuilder.Entity<ProductRetailCategoryApplicableDimension>(entity =>
            {
                entity.ToTable("product_retail_category_applicable_dimension");

                entity.HasComment("An intersection between the product retail category and manufacturer dimension table. The existence of a record indicates that the associated manufacturer dimension applies to all the products in the associated product retail category. For example, Clopay garage doors come in 3 colors (white, almond and chocolate brown) so all door models in the Clopay product category \"garage doors\" must be requested in White, almond or chocolate brown when ordered. We note this requirement by relating the category \"garage door\" with the dimension \"color\".");

                entity.HasIndex(e => new { e.ProductRetailCategoryFk, e.DimensionFk })
                    .HasName("idx_product_retail_category_applicable_dimension")
                    .IsUnique();

                entity.Property(e => e.ProductRetailCategoryApplicableDimensionId)
                    .HasColumnName("product_retail_category_applicable_dimension_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.DimensionFk)
                    .HasColumnName("dimension_fk")
                    .HasComment("Foreign key to associated dimension.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.ProductRetailCategoryFk)
                    .HasColumnName("product_retail_category_fk")
                    .HasComment("Foreign key to associated product retail category.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.DimensionFkNavigation)
                    .WithMany(p => p.ProductRetailCategoryApplicableDimension)
                    .HasForeignKey(d => d.DimensionFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_product_retail_category_applicable_dimension_dimension");

                entity.HasOne(d => d.ProductRetailCategoryFkNavigation)
                    .WithMany(p => p.ProductRetailCategoryApplicableDimension)
                    .HasForeignKey(d => d.ProductRetailCategoryFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_product_retail_category_applicable_dimension_category");
            });

            modelBuilder.Entity<ProductRetailCategoryTag>(entity =>
            {
                entity.HasKey(e => e.ProductPropertyId)
                    .HasName("pk_product_property_product_property_id_0");

                entity.ToTable("product_retail_category_tag");

                entity.HasComment("An intersection between the product and tag tables. The existence of a record indicates that the associated product is properly \"Tagged\" with the associated tag. By implication, that tag should be a property that is true of the product and not up for specification such as size and color. For example, a product might be tagged as silk - not up for discussion, if you don't want silk you need to find another product.");

                entity.HasIndex(e => new { e.ProductRetailCategoryFk, e.TagFk })
                    .HasName("ux_product_retail_caegory_tag")
                    .IsUnique();

                entity.Property(e => e.ProductPropertyId)
                    .HasColumnName("product_property_id")
                    .HasComment("System generatted surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.ProductRetailCategoryFk)
                    .HasColumnName("product_retail_category_fk")
                    .HasComment("Foreign key to associated product retail category.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TagFk)
                    .HasColumnName("tag_fk")
                    .HasComment("A foreign key to the associated tag.");

                entity.HasOne(d => d.ProductRetailCategoryFkNavigation)
                    .WithMany(p => p.ProductRetailCategoryTag)
                    .HasForeignKey(d => d.ProductRetailCategoryFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_product_retail_category_tag_retail_category");

                entity.HasOne(d => d.TagFkNavigation)
                    .WithMany(p => p.ProductRetailCategoryTag)
                    .HasForeignKey(d => d.TagFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_product_tag_tag_0");
            });

            modelBuilder.Entity<ProductSubscription>(entity =>
            {
                entity.ToTable("product_subscription");

                entity.HasComment("An on-going purchase of a product such as a magazine or deposable razors.");

                entity.HasIndex(e => new { e.ProductFk, e.PeriodicPurchaseRate })
                    .HasName("ux_product_subscription")
                    .IsUnique();

                entity.Property(e => e.ProductSubscriptionId)
                    .HasColumnName("product_subscription_id")
                    .HasComment("System generate surrogate primary key.");

                entity.Property(e => e.BaseDate)
                    .HasColumnName("base_date")
                    .HasColumnType("date")
                    .HasComment("The date to use when calcualting the expected future delivery dates. NOTE: this can be different from the first delivery date since the customer may have requested a re-jiger of the subscription as to delivery dates and the calendar.");

                entity.Property(e => e.CartFk)
                    .HasColumnName("cart_fk")
                    .HasComment("Foreign key to parent cart (and thus indirectly to the retail customer).");

                entity.Property(e => e.DeliveryAddressFk)
                    .HasColumnName("delivery_address_fk")
                    .HasComment("Foreign key to delivery address. NOTE: this is nullable because you might be purchasing a virtual product, such as your personal horoscope.");

                entity.Property(e => e.FirstDeliveryDate)
                    .HasColumnName("first_delivery_date")
                    .HasColumnType("date")
                    .HasComment("Date the retail customer expects delivery of the first occurrence of the subscription. This is the initial base date to use for calculating the net effect of the periodicity.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.PeriodicPurchaseRate)
                    .HasColumnName("periodic_purchase_rate")
                    .HasComment("The days between each purchase.");

                entity.Property(e => e.ProductFk)
                    .HasColumnName("product_fk")
                    .HasComment("Foreign key to parent forieng key.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CartFkNavigation)
                    .WithMany(p => p.ProductSubscription)
                    .HasForeignKey(d => d.CartFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_product_subscription_cart");

                entity.HasOne(d => d.DeliveryAddressFkNavigation)
                    .WithMany(p => p.ProductSubscription)
                    .HasForeignKey(d => d.DeliveryAddressFk)
                    .HasConstraintName("fk_product_subscription_delivery_address");

                entity.HasOne(d => d.ProductFkNavigation)
                    .WithMany(p => p.ProductSubscription)
                    .HasForeignKey(d => d.ProductFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_product_subscription_product");
            });

            modelBuilder.Entity<ProductTag>(entity =>
            {
                entity.HasKey(e => e.ProductPropertyId)
                    .HasName("pk_product_property_product_property_id");

                entity.ToTable("product_tag");

                entity.HasComment("An intersection between the product and tag tables. The existence of a record indicates that the associated product is properly \"Tagged\" with the associated tag. By implication, that tag should be a property that is true of the product and not up for specification such as size and color. For example, a product might be tagged as silk - not up for discussion, if you don't want silk you need to find another product.");

                entity.HasIndex(e => new { e.ProductFk, e.TagFk })
                    .HasName("ux_product_tag")
                    .IsUnique();

                entity.Property(e => e.ProductPropertyId)
                    .HasColumnName("product_property_id")
                    .HasComment("System generatted surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.ProductFk)
                    .HasColumnName("product_fk")
                    .HasComment("Foreign key to associated product.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TagFk)
                    .HasColumnName("tag_fk")
                    .HasComment("A foreign key to the associated tag.");

                entity.HasOne(d => d.ProductFkNavigation)
                    .WithMany(p => p.ProductTag)
                    .HasForeignKey(d => d.ProductFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_product_tag_product");

                entity.HasOne(d => d.TagFkNavigation)
                    .WithMany(p => p.ProductTag)
                    .HasForeignKey(d => d.TagFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_product_tag_tag");
            });

            modelBuilder.Entity<ProductTerms>(entity =>
            {
                entity.ToTable("product_terms");

                entity.HasComment("Integrated financing for item purchase.");

                entity.HasIndex(e => new { e.ProductFk, e.TermsText })
                    .HasName("ux_product_terms")
                    .IsUnique();

                entity.Property(e => e.ProductTermsId)
                    .HasColumnName("product_terms_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.LayAway)
                    .HasColumnName("lay_away")
                    .HasColumnType("date")
                    .HasComment("'Y'es or 'N'o flag. Yes means to interpret the payment terms in the same way, but ship at the end rather than ship at the beginning or the term days.");

                entity.Property(e => e.LoyaltyLevel)
                    .HasColumnName("loyalty_level")
                    .HasComment("If terms are only available to loyalty customers then value 99 means to any loyal customer. If they are availble to only level 1 loyalty customers then tthe value should be 1. Null means terms are available to everyone even those not in the loyalty program.");

                entity.Property(e => e.PaymentFrequencyInDays)
                    .HasColumnName("payment_frequency_in_days")
                    .HasColumnType("date")
                    .HasComment("How often payment will be made. Forexample 30 for the case of 90 days same as cash mean payments are to be made 30, 60 and 90 days after the shipment date.");

                entity.Property(e => e.ProductFk)
                    .HasColumnName("product_fk")
                    .HasComment("Foreign key to parent product.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TermDays)
                    .HasColumnName("term_days")
                    .HasComment("Number of days the terms permit - such as 90 for 90 days same as cash.");

                entity.Property(e => e.TermsText)
                    .IsRequired()
                    .HasColumnName("terms_text")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("A human readable text explanation of terms such as \"90 days same as cash (3 each payments of x as 30, 60 and 90 days\".");

                entity.HasOne(d => d.ProductFkNavigation)
                    .WithMany(p => p.ProductTerms)
                    .HasForeignKey(d => d.ProductFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_product_terms_product");
            });

            modelBuilder.Entity<ProductVirtuePointCredit>(entity =>
            {
                entity.ToTable("product_virtue_point_credit");

                entity.HasComment("This table holds the number of virtue points earned the retail customer for every product/virtue combinationy.");

                entity.HasIndex(e => new { e.ProductFk, e.VirtueFk })
                    .HasName("ux_product_virtue_point_credit")
                    .IsUnique();

                entity.Property(e => e.ProductVirtuePointCreditId)
                    .HasColumnName("product_virtue_point_credit_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.PointsToAward)
                    .HasColumnName("points_to_award")
                    .HasComment("The number of points to award to the retail customer in the event that they purchase this product.");

                entity.Property(e => e.ProductFk)
                    .HasColumnName("product_fk")
                    .HasComment("Foreign key to associated product.");

                entity.Property(e => e.VirtueFk)
                    .HasColumnName("virtue_fk")
                    .HasComment("Foreign key to assocaited virtue");

                entity.HasOne(d => d.ProductFkNavigation)
                    .WithMany(p => p.ProductVirtuePointCredit)
                    .HasForeignKey(d => d.ProductFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_product_virtue_point_credit_product");

                entity.HasOne(d => d.VirtueFkNavigation)
                    .WithMany(p => p.ProductVirtuePointCredit)
                    .HasForeignKey(d => d.VirtueFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_product_virtue_point_credit_virtue");
            });

            modelBuilder.Entity<ProfessionalService>(entity =>
            {
                entity.ToTable("professional_service");

                entity.HasComment("A sellable service such as a hair cur or a home repair. NOTE: this table has no uniqueness constraint / business key. It inherits its uniqueness from the product table.");

                entity.Property(e => e.ProfessionalServiceId)
                    .HasColumnName("professional_service_id")
                    .HasComment("System generated surrogate primary key.")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExpectedDurationInMinutes)
                    .HasColumnName("expected_duration_in_minutes")
                    .HasComment("The amount of time the service is expected to take. NOTE: this does not include any travel time in cases where that applies. NOTE 2: this may be null since we may have a duration indicated at the product retail category level that we do not wish to over-ride here at the individual service level.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MeanFrequencyOfRecurranceInDays)
                    .HasColumnName("mean_frequency_of_recurrance_in_days")
                    .HasComment("This is guessed and then measured. Higher for hair cuts than paino tunings (for most people). We use this to drive offers which attempt to trigger recurrance on recurring serices.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ServiceType)
                    .IsRequired()
                    .HasColumnName("service_type")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Does the service go to one customer as is normal like a haircut, or N customers like a class in which case it varies per business location or more generally venue.\\n1 means one and N means many");

                entity.HasOne(d => d.ProfessionalServiceNavigation)
                    .WithOne(p => p.ProfessionalService)
                    .HasForeignKey<ProfessionalService>(d => d.ProfessionalServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_service_product");
            });

            modelBuilder.Entity<Prospect>(entity =>
            {
                entity.ToTable("prospect");

                entity.HasComment("A brick and motor customer from a a member mobile business. This is primary used to jump start the mobile business aquisition process. We send emails to brick and mortar customers inviting them to join the platform. NOTE: a prospect is a kind of a person. once a person registers they become a retail customer and cease being a prospect - thus, we then add a row to retail customer with the already established surrogate key for that person and delete the row from prospect.");

                entity.Property(e => e.ProspectId)
                    .HasColumnName("prospect_id")
                    .HasComment("System generated surrogate primary key.")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasComment("Email that we have on the prospect - probably how we will invite them.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foreign key to the mobile business who bought in the prospect. That is, the prospect is really a historical brick and mortar customer of this mobile business.");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phone_number")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("The phone, the primary device of the prospect.");

                entity.Property(e => e.ProspectType)
                    .IsRequired()
                    .HasColumnName("prospect_type")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("'RC' mean retail customer\\n'MBE' means mobile business employee");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.Prospect)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_prospect_mobile_business");

                entity.HasOne(d => d.ProspectNavigation)
                    .WithOne(p => p.Prospect)
                    .HasForeignKey<Prospect>(d => d.ProspectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_prospect_person");
            });

            modelBuilder.Entity<Recommendation>(entity =>
            {
                entity.ToTable("recommendation");

                entity.HasComment("Recommendation to use some aspect of the platform. NOTE: uniqueness constraint must be added after the fact since it shoudl include nullable fields.");

                entity.Property(e => e.RecommendationId)
                    .HasColumnName("recommendation_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.PersonFk)
                    .HasColumnName("person_fk")
                    .HasComment("Foreign key to associated person who is making some recomendation.");

                entity.Property(e => e.Pitch)
                    .IsRequired()
                    .HasColumnName("pitch")
                    .HasMaxLength(4896)
                    .IsUnicode(false)
                    .HasComment("Text that recomends some action.");

                entity.Property(e => e.ProductCategoryFk)
                    .HasColumnName("product_category_fk")
                    .HasComment("Nullable foreign key to product category being pitched. NOTE: often null as recomendations are often on things other than product categories.");

                entity.Property(e => e.ProductFk)
                    .HasColumnName("product_fk")
                    .HasComment("Nullable foreign key to product being pitched. NOTE: often null as recomendations are often on things other than products.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Video)
                    .HasColumnName("video")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Video pitch version of recomendation.");

                entity.HasOne(d => d.PersonFkNavigation)
                    .WithMany(p => p.Recommendation)
                    .HasForeignKey(d => d.PersonFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_recomendation_person");

                entity.HasOne(d => d.ProductCategoryFkNavigation)
                    .WithMany(p => p.Recommendation)
                    .HasForeignKey(d => d.ProductCategoryFk)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_recomendation_product_category");

                entity.HasOne(d => d.ProductFkNavigation)
                    .WithMany(p => p.Recommendation)
                    .HasForeignKey(d => d.ProductFk)
                    .HasConstraintName("fk_recomendation_product");
            });

            modelBuilder.Entity<RentableGood>(entity =>
            {
                entity.ToTable("rentable_good");

                entity.HasComment("A good that is rentable. NOTE: such items must have serial numbers and be rented out as specific items.");

                entity.HasIndex(e => e.SerialNumber)
                    .HasName("ux_rentable_good")
                    .IsUnique();

                entity.Property(e => e.RentableGoodId)
                    .HasColumnName("rentable_good_id")
                    .HasComment("System generated surrogate key.")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RentableLocationFk)
                    .HasColumnName("rentable_location_fk")
                    .HasComment("A foreign key to a location to rent out. My product is one or another of my locations.");

                entity.Property(e => e.RentableSubLocationFk)
                    .HasColumnName("rentable_sub_location_fk")
                    .HasComment("Foriegn key to business sub location. My prduct is a sublocation at one or another of my locations. For example, a cinference room at a hotel or a chair at a coop beauty salon.");

                entity.Property(e => e.SerialNumber)
                    .HasColumnName("serial_number")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("Identification number for a particular item of inventory to facilitate renting it out individually and maintaining a coordinated schedule for it's use.");

                entity.HasOne(d => d.RentableGoodNavigation)
                    .WithOne(p => p.RentableGood)
                    .HasForeignKey<RentableGood>(d => d.RentableGoodId)
                    .HasConstraintName("fk_rentable_good_good");
            });

            modelBuilder.Entity<RentableGoodCalendar>(entity =>
            {
                entity.HasKey(e => e.ProductCalendarId)
                    .HasName("pk_product_calendar_product_calendar_id");

                entity.ToTable("rentable_good_calendar");

                entity.HasComment("A calendar for a serialized rentable good. Each entry pulls the rentable good out of service. This can happen due to a retail customer renting the serialized good and due to maintenance vendor cleaning or performing maintenance on serialized rentable product. NOTE: this table holds both historical records for past days, the current days schedule as well as reservations for the serialized rentable good for future days.");

                entity.HasIndex(e => new { e.RentableGoodFk, e.BeginUnavailabilityDate })
                    .HasName("ux_rentable_good_calendar")
                    .IsUnique();

                entity.Property(e => e.ProductCalendarId)
                    .HasColumnName("product_calendar_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.BeginPeriodOfUnavailability)
                    .HasColumnName("begin_period_of_unavailability")
                    .HasColumnType("date")
                    .HasComment("Number of seconds after midnight that the serialized rentable product came to be unavailable for some portion of the partial_day_use_date.");

                entity.Property(e => e.BeginUnavailabilityDate)
                    .HasColumnName("begin_unavailability_date")
                    .HasColumnType("date")
                    .HasComment("Date the serialized rentable product went out of service for a full day or multi-day stent.");

                entity.Property(e => e.EndPeriodOfUnavailability)
                    .HasColumnName("end_period_of_unavailability")
                    .HasColumnType("date")
                    .HasComment("Number of seconds after midnight that the serialized rentable product came back into service thus ending some perios of unavailability ending some blocked out portion of the partial_day_use_date.");

                entity.Property(e => e.EndUnavailabilityDate)
                    .HasColumnName("end_unavailability_date")
                    .HasColumnType("date")
                    .HasComment("Date the serialized rentable product came back in from use or service.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MaintenanceVendorFk)
                    .HasColumnName("maintenance_vendor_fk")
                    .HasComment("Foreign key to vendor performing maintenance on the parent serialized rentable product. NOTE: this field can be null since the parent serialized rentable product may be unavailable due to it being rented out by a retail customer. NOTE2: if both retail customer and maintenance vendor are null this should mean that the mobile uniqueness itself is doing maintenance on the serialized rentable product.");

                entity.Property(e => e.PartialDayUseDate)
                    .HasColumnName("partial_day_use_date")
                    .HasColumnType("date")
                    .HasComment("The day a serialized rentable priduct went unavilable for some protion of the day.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RentableGoodFk)
                    .HasColumnName("rentable_good_fk")
                    .HasComment("Foreign key to the parent serialized rentable product.");

                entity.Property(e => e.RetailCustomerFk)
                    .HasColumnName("retail_customer_fk")
                    .HasComment("Foreign key to the retail customer who has rented out the serialized rentable product. NOTE: this field can be null for cases where the unavailability of the serialized rentable product is due to it being cleansed or fixed or getting scheduled maintenance.");

                entity.HasOne(d => d.MaintenanceVendorFkNavigation)
                    .WithMany(p => p.RentableGoodCalendar)
                    .HasForeignKey(d => d.MaintenanceVendorFk)
                    .HasConstraintName("fk_product_calendar_maintenace_vendor");

                entity.HasOne(d => d.RentableGoodFkNavigation)
                    .WithMany(p => p.RentableGoodCalendar)
                    .HasForeignKey(d => d.RentableGoodFk)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_rentable_good_calendar_rentable_good");

                entity.HasOne(d => d.RetailCustomerFkNavigation)
                    .WithMany(p => p.RentableGoodCalendar)
                    .HasForeignKey(d => d.RetailCustomerFk)
                    .HasConstraintName("fk_product_calendar_retail_csutomer");
            });

            modelBuilder.Entity<RestockAlert>(entity =>
            {
                entity.ToTable("restock_alert");

                entity.HasComment("A registry entry of the event where in we alerted a mobile business that they are low on inventory so that they might have to order to avoid foregoing sales and taking damage to their reputation as to fulfillment.");

                entity.HasIndex(e => new { e.RestockRequirementFk, e.AlertTimestamp })
                    .HasName("ux_restock_alert")
                    .IsUnique();

                entity.Property(e => e.RestockAlertId)
                    .HasColumnName("restock_alert_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.AlertTimestamp)
                    .HasColumnName("alert_timestamp")
                    .HasColumnType("datetime")
                    .HasComment("Moment we sent the alert of the inventory short fall.");

                entity.Property(e => e.ConfirmationFlag)
                    .HasColumnName("confirmation_flag")
                    .HasColumnType("datetime")
                    .HasComment("'Y'es we have received confirmation of receipt and 'N'o we have not yet reived confirmation of receipt.");

                entity.Property(e => e.ContactMechanismFk)
                    .HasColumnName("contact_mechanism_fk")
                    .HasComment("Foriegn key to associated contact mechanism.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RestockRequirementFk)
                    .HasColumnName("restock_requirement_fk")
                    .HasComment("Foriegn key to parent restock requirement.");

                entity.HasOne(d => d.ContactMechanismFkNavigation)
                    .WithMany(p => p.RestockAlert)
                    .HasForeignKey(d => d.ContactMechanismFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_restock_alert_contact_mechanism");

                entity.HasOne(d => d.RestockRequirementFkNavigation)
                    .WithMany(p => p.RestockAlert)
                    .HasForeignKey(d => d.RestockRequirementFk)
                    .HasConstraintName("fk_restock_alert_restock_requirement");
            });

            modelBuilder.Entity<RestockEvent>(entity =>
            {
                entity.ToTable("restock_event");

                entity.HasComment("A record of the notification that a mobile business owner has restocked a product or bundle, presumably in response to our restock alert but possibly via a restock mechanism driven entirely on his side.");

                entity.HasIndex(e => new { e.ProductFk, e.NewQuantity })
                    .HasName("ujx_restock_event")
                    .IsUnique();

                entity.Property(e => e.RestockEventId)
                    .HasColumnName("restock_event_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessEmployeeFk)
                    .HasColumnName("mobile_business_employee_fk")
                    .HasComment("The person who told the platform about the rise in inventory.");

                entity.Property(e => e.NewQuantity)
                    .HasColumnName("new_quantity")
                    .HasComment("New quantity on hand to be put into the system.");

                entity.Property(e => e.ProductFk)
                    .HasColumnName("product_fk")
                    .HasComment("Foreign key to product being restocked. NOTE: this field can be null because the row might be about restocking a bundle.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.MobileBusinessEmployeeFkNavigation)
                    .WithMany(p => p.RestockEvent)
                    .HasForeignKey(d => d.MobileBusinessEmployeeFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_restock_event_mobile_business_agent");

                entity.HasOne(d => d.ProductFkNavigation)
                    .WithMany(p => p.RestockEvent)
                    .HasForeignKey(d => d.ProductFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_restock_event_product");
            });

            modelBuilder.Entity<RestockRequirement>(entity =>
            {
                entity.ToTable("restock_requirement");

                entity.HasComment("A record of the detection of a product quantity available falling below the target quantity on hand'");

                entity.HasIndex(e => new { e.ProductFk, e.DetectionTs })
                    .HasName("ux_restock_requirement")
                    .IsUnique();

                entity.Property(e => e.RestockRequirementId)
                    .HasColumnName("restock_requirement_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.DetectionTs)
                    .HasColumnName("detection_ts")
                    .HasComment("Moment we detected that the quantity available fell below the quantity on hand either due to a fall in the quantity on hand or a rise in the target quantity.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.ProductFk)
                    .HasColumnName("product_fk")
                    .HasComment("Foreign key to subject product.");

                entity.Property(e => e.QuantityAvailable)
                    .HasColumnName("quantity_available")
                    .HasComment("The quantity available at the time of the restock requirement detection.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ResolutionNotificationConfirmationFlag)
                    .HasColumnName("resolution_notification_confirmation_flag")
                    .HasColumnType("datetime")
                    .HasComment("\"Y\"es we got confirmation of the resolution notification and \"N\"o we have not gotten resolution notification.");

                entity.Property(e => e.ResolutionNotificationTransmissionTimestamp)
                    .HasColumnName("resolution_notification_transmission_timestamp")
                    .HasColumnType("datetime")
                    .HasComment("The moment we sent out the notice that this inventory alert had been resolved.");

                entity.Property(e => e.ResolutionTimestamp)
                    .HasColumnName("resolution_timestamp")
                    .HasColumnType("datetime")
                    .HasComment("The moment the quantity available went over our inventory target.");

                entity.Property(e => e.TargetQuantity)
                    .HasColumnName("target_quantity")
                    .HasComment("The desired quantity on hand at the time of the restock requirement detection.");

                entity.HasOne(d => d.ProductFkNavigation)
                    .WithMany(p => p.RestockRequirement)
                    .HasForeignKey(d => d.ProductFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_restock_requirement_product");
            });

            modelBuilder.Entity<RetailCustomer>(entity =>
            {
                entity.ToTable("retail_customer");

                entity.HasComment("A platform system user who participates by buying items from one or more mobile businesses. NOTE: the customer can also be an agent of a mobile business. NOTE: this table does not have a uniqueness constraint / busines key. It inherits it's uniqueness from the person table.");

                entity.Property(e => e.RetailCustomerId)
                    .HasColumnName("retail_customer_id")
                    .HasComment("System generated surrogate primary key.")
                    .ValueGeneratedNever();

                entity.Property(e => e.DefaultFormOfPaymentFk)
                    .HasColumnName("default_form_of_payment_fk")
                    .HasComment("Foriegn key to the form of payment the retail customer wishes to use as their default for any cart. NOTE: this field is null since it is not required to be filled in as part of retail customer onboarding.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ReputationScore)
                    .HasColumnName("reputation_score")
                    .HasComment("A number between 0 and 1 that is driven by activity vs complaints and returns.");

                entity.Property(e => e.UseTermsWhenAvailable)
                    .HasColumnName("use_terms_when_available")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')")
                    .HasComment("'Y' means yes, default to using terms to purchase when they are available\\n'N' means to default to not suing terms on purchases");

                entity.Property(e => e.UseTokensDefault)
                    .HasColumnName("use_tokens_default")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')")
                    .HasComment("'Y' means yes use toekns when I've got them\\n'N' means no do not use tokens.");

                entity.HasOne(d => d.DefaultFormOfPaymentFkNavigation)
                    .WithMany(p => p.RetailCustomer)
                    .HasForeignKey(d => d.DefaultFormOfPaymentFk)
                    .HasConstraintName("Fk_retail_customer_platform_supported_form_of_payment");

                entity.HasOne(d => d.RetailCustomerNavigation)
                    .WithOne(p => p.RetailCustomer)
                    .HasForeignKey<RetailCustomer>(d => d.RetailCustomerId)
                    .HasConstraintName("fk_retail_customer_person");
            });

            modelBuilder.Entity<RetailCustomerBadge>(entity =>
            {
                entity.ToTable("retail_customer_badge");

                entity.HasComment("A 3 way intersection between the retail customer, universal badge and mobile business tables. The existence of a record indacates that the associated retail customers has been awarded the associated badge by the assocaited mobile business.");

                entity.HasIndex(e => new { e.RetailCustomerFk, e.UniversalBadgeFk })
                    .HasName("ux_retail_customer_badge")
                    .IsUnique();

                entity.Property(e => e.RetailCustomerBadgeId)
                    .HasColumnName("retail_customer_badge_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foreign key to the mobile business that awarded the badge.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RetailCustomerFk)
                    .HasColumnName("retail_customer_fk")
                    .HasComment("Foreign key to subject retail customer.");

                entity.Property(e => e.UniversalBadgeFk)
                    .HasColumnName("universal_badge_fk")
                    .HasComment("Foreign key to associated badge.");

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.RetailCustomerBadge)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_retail_customer_badge_mobile_business");

                entity.HasOne(d => d.RetailCustomerFkNavigation)
                    .WithMany(p => p.RetailCustomerBadge)
                    .HasForeignKey(d => d.RetailCustomerFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_retail_customer_badge_retail_customer");

                entity.HasOne(d => d.UniversalBadgeFkNavigation)
                    .WithMany(p => p.RetailCustomerBadge)
                    .HasForeignKey(d => d.UniversalBadgeFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_retail_customer_badge_universal_badge");
            });

            modelBuilder.Entity<RetailCustomerBusinessRelationship>(entity =>
            {
                entity.ToTable("retail_customer_business_relationship");

                entity.HasComment("An intersection between the retail customer and mobile business tables. THe existence of a record indicates that the retail customer is in the system as a member of the associated mobile business's loyalty program in as much as this whole platform is a loyalty program.");

                entity.Property(e => e.RetailCustomerBusinessRelationshipId)
                    .HasColumnName("retail_customer_business_relationship_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foreign key to associated mobile business.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RetailCustomerFk)
                    .HasColumnName("retail_customer_fk")
                    .HasComment("Foreign key to associated retail customer.");

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.RetailCustomerBusinessRelationship)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_retai_customer_business_relationship_mobile_business");

                entity.HasOne(d => d.RetailCustomerFkNavigation)
                    .WithMany(p => p.RetailCustomerBusinessRelationship)
                    .HasForeignKey(d => d.RetailCustomerFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_retai_customer_business_relationship_retail_customer");
            });

            modelBuilder.Entity<RetailCustomerCharibleContribution>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("retail_customer_charible_contribution");

                entity.HasComment("A record of the money contributed to a charity by a retail customer as part of the check out of a particular shopping cart.");

                entity.Property(e => e.CartFk)
                    .HasColumnName("cart_fk")
                    .HasComment("Foreign key to parent cart that has triggered a charitible contribution.");

                entity.Property(e => e.CharityFk)
                    .HasColumnName("charity_fk")
                    .HasComment("Foreign key to selected charity.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessMatchAmount)
                    .HasColumnName("mobile_business_match_amount")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("Dollar amount of any match by the mobile business on the cart - our charitible contribution.");

                entity.Property(e => e.PlatformMatchAmount)
                    .HasColumnName("platform_match_amount")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("Dollar amount of any match by us - our charitible contribution.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RetailCustomerCharibleContributionId)
                    .HasColumnName("retail_customer_charible_contribution_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.RetailCustomerContributionAmount)
                    .HasColumnName("retail_customer_contribution_amount")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("The dollar amount of the charitible contribution.");

                entity.HasOne(d => d.CartFkNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CartFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_retail_customer_charible_contribution_cart");

                entity.HasOne(d => d.CharityFkNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CharityFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_retail_customer_charible_contribution_charity");
            });

            modelBuilder.Entity<RetailCustomerCurrentCarharitiesAvailable>(entity =>
            {
                entity.ToTable("retail_customer_current_carharities_available");

                entity.HasComment("The set of charities that should appear as options on the next cart the retail customer checks out - vs- the set that did appear on the last cart vs what charitible contribution have been made by this retail customer. NOTE: !!! this is a derived table. we net out the retail customers historical contribution, the set of charities approved by the mobile business and the results of a set of A/B tests.");

                entity.Property(e => e.RetailCustomerCurrentCarharitiesAvailableId)
                    .HasColumnName("retail_customer_current_carharities_available_id")
                    .HasComment("System generated surrogate primry key.");

                entity.Property(e => e.CharityFk)
                    .HasColumnName("charity_fk")
                    .HasComment("Foreign key to charity.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.OrderOfAppearance)
                    .HasColumnName("order_of_appearance")
                    .HasComment("The priority of the charity as in where it appears on an ordered list of possible charities. Like google ones you have to scroll to effectively do not exist.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RetailCustomerFk)
                    .HasColumnName("retail_customer_fk")
                    .HasComment("Foreign key to retail customer.");

                entity.HasOne(d => d.CharityFkNavigation)
                    .WithMany(p => p.RetailCustomerCurrentCarharitiesAvailable)
                    .HasForeignKey(d => d.CharityFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_retail_customer_current_carharities_available_charity");

                entity.HasOne(d => d.RetailCustomerFkNavigation)
                    .WithMany(p => p.RetailCustomerCurrentCarharitiesAvailable)
                    .HasForeignKey(d => d.RetailCustomerFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_retail_customer_current_carharities_available_retail_customer");
            });

            modelBuilder.Entity<RetailCustomerMobileBusinessAffinity>(entity =>
            {
                entity.ToTable("retail_customer_mobile_business_affinity");

                entity.HasComment("A score that describes the likelihood of a retail customer purchasing goods and services / generating profits for a given mobile business. These scores are driven by analysis of past spend and click stream data and are used to drive a particulazied view of the platform market place for the retail customer.");

                entity.HasIndex(e => new { e.RetailCustomerFk, e.MobileBusinessFk })
                    .HasName("ux_retail_customer_mobile_business_affinity")
                    .IsUnique();

                entity.Property(e => e.RetailCustomerMobileBusinessAffinityId)
                    .HasColumnName("retail_customer_mobile_business_affinity_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foreign key to associated mobile business.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RetailCustomerFk)
                    .HasColumnName("retail_customer_fk")
                    .HasComment("Foreign key to parent retail customer.");

                entity.Property(e => e.Score)
                    .HasColumnName("score")
                    .HasColumnType("decimal(5, 4)")
                    .HasComment("An affinity measure to lie between 0 and 1.");

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.RetailCustomerMobileBusinessAffinity)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_retail_customer_mobile_business_affinity_mobile_business");

                entity.HasOne(d => d.RetailCustomerFkNavigation)
                    .WithMany(p => p.RetailCustomerMobileBusinessAffinity)
                    .HasForeignKey(d => d.RetailCustomerFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_retail_customer_mobile_business_affinity_retail_customer");
            });

            modelBuilder.Entity<RetailCustomerPrepaidCard>(entity =>
            {
                entity.HasKey(e => e.RetailCusotmerCustomerPrepaidCardId)
                    .HasName("Pk_reail_cusotmer_perpaid_card_retail_cusotmer_customer_prepaid_card_id");

                entity.ToTable("retail_customer_prepaid_card");

                entity.HasComment("An account the customer has with a mobile business wherer deposit money and then draw money down from to make purchases of goods and services from that mobile business - like a star bucks card. NOTE: recharging is to take place from the retail customer's associated bank account.");

                entity.HasIndex(e => e.RetailCustomerFk)
                    .HasName("ux_retail_customer_perpaid_card")
                    .IsUnique();

                entity.Property(e => e.RetailCusotmerCustomerPrepaidCardId)
                    .HasColumnName("retail_cusotmer_customer_prepaid_card_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.AccountBalance)
                    .HasColumnName("account_balance")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("The dollar amount of money that is in the account.");

                entity.Property(e => e.CardNumber)
                    .IsRequired()
                    .HasColumnName("card_number")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("A 16 digit number that looks like a credit card number and which is a smart key. UI uses it to look legit, obviously everything is already linked here in the back end.");

                entity.Property(e => e.DayOfMonthForAutomaticTransfer)
                    .HasColumnName("day_of_month_for_automatic_transfer")
                    .HasColumnType("date")
                    .HasComment("The day of the money the retail customer wishes to send over the mad money allotment - such as the 1st or 15th. 31st will be interpretted as last day of rthe month for all months.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foreign key to associated mobile business.");

                entity.Property(e => e.MonthlyMadMoneyAutomaticTransferAmount)
                    .HasColumnName("monthly_mad_money_automatic_transfer_amount")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("An amonut of money to be transfered to the prepaid card every month regardless of the current balance");

                entity.Property(e => e.RechargeTransferAmount)
                    .HasColumnName("recharge_transfer_amount")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("The amount of money to move from the bank acocunt to the prepaid card upon hitting the recharge trigger amount.");

                entity.Property(e => e.RechargeTriggerAmount)
                    .HasColumnName("recharge_trigger_amount")
                    .HasComment("The amount of money which at or below the prepaid account is automatically bolstered from the retail customer's bank account already on file. This is a low amount such that it may not be enough for a nrmal purchase thus blocking the use of the pre-paid card.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RetailCustomerFk)
                    .HasColumnName("retail_customer_fk")
                    .HasComment("Foreign key to parent retail customer.");

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.RetailCustomerPrepaidCard)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_retail_customer_prepaid_card_mobile_business");

                entity.HasOne(d => d.RetailCustomerFkNavigation)
                    .WithOne(p => p.RetailCustomerPrepaidCard)
                    .HasForeignKey<RetailCustomerPrepaidCard>(d => d.RetailCustomerFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_retail_customer_perpaid_card_retail_customer");
            });

            modelBuilder.Entity<RetailCustomerPushCommunication>(entity =>
            {
                entity.ToTable("retail_customer_push_communication");

                entity.Property(e => e.RetailCustomerPushCommunicationId)
                    .HasColumnName("retail_customer_push_communication_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.CommunicationContent)
                    .IsRequired()
                    .HasColumnName("communication_content")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Text or even video of the push commnication - likely an offer.");

                entity.Property(e => e.LsastUpdateTimestamp)
                    .HasColumnName("lsast_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RetailCustomerFk)
                    .HasColumnName("retail_customer_fk")
                    .HasComment("Foreign key to recipeint retail customer.");

                entity.HasOne(d => d.RetailCustomerFkNavigation)
                    .WithMany(p => p.RetailCustomerPushCommunication)
                    .HasForeignKey(d => d.RetailCustomerFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_retail_customer_push_communication_retail_customer");
            });

            modelBuilder.Entity<RetailCustomerServiceCalendarPreference>(entity =>
            {
                entity.ToTable("retail_customer_service_calendar_preference");

                entity.HasComment("For a given retail customer and service or product retail ccategory (class of services) this table holds the calendar preferences of the retail customer as to receiving the serviceon an on-going basis; such as hair coloring. Example indications include Friday afternoons or Saturday mornings. NOTE: more than more rcord for a given retail customer and product reatil catgeory or service is allowed. Multiple recrods indicates that the different scheduled calendar indicates are all more or less acceptable times for setting appintments. NOTE 2: if both product retail category is null and service is null the associated record shold be interpreted to indicate preferences for the mobile business as such.");

                entity.HasIndex(e => new { e.RetailCustomerFk, e.ProductRetailCategoryFk, e.ServiceFk, e.DayOfWeek, e.TimeOfDay })
                    .HasName("ux_retail_customer_service_calendar_preference")
                    .IsUnique();

                entity.Property(e => e.RetailCustomerServiceCalendarPreferenceId)
                    .HasColumnName("retail_customer_service_calendar_preference_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasColumnName("day_of_week")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Day of the week such as Monday or Saturday.");

                entity.Property(e => e.EndTimestamp)
                    .HasColumnName("end_timestamp")
                    .HasColumnType("datetime")
                    .HasComment("The moment the retail customer discontinued the preference.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foriegn key to the associated mobile business to which this preference applies.");

                entity.Property(e => e.PreferedTimeAsExactMinutesAfterGrinageMidnight)
                    .HasColumnName("prefered_time_as_exact_minutes_after_grinage_midnight")
                    .HasComment("For cases where the user indicated an exact time they prefer to be served, that exact time expressed as a minutes after midnight.");

                entity.Property(e => e.PreferenceOrder)
                    .HasColumnName("preference_order")
                    .HasDefaultValueSql("((1))")
                    .HasComment("A number to indicate top prefernce on down if there are more than one.");

                entity.Property(e => e.ProductRetailCategoryFk)
                    .HasColumnName("product_retail_category_fk")
                    .HasComment("Foreign key to the assocciated product retail category to which this scheduling calendar preference applies.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RetailCustomerFk)
                    .HasColumnName("retail_customer_fk")
                    .HasComment("Foreign key to aprent retail customer.");

                entity.Property(e => e.ServiceFk)
                    .HasColumnName("service_fk")
                    .HasComment("The exact service to which this expressed servingin prefernce applies.");

                entity.Property(e => e.StartTimestamp)
                    .HasColumnName("start_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The moment the preference was established.");

                entity.Property(e => e.TimeOfDay)
                    .IsRequired()
                    .HasColumnName("time_of_day")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("legal values are\\n\"morning\" beiging of service ours till 11:00\\n\"around noon\" 11:00 to 1:00\\n\"afternoon\" 1:00 or after\\n\"exact\" exact preference");

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.RetailCustomerServiceCalendarPreference)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_retail_customer_service_calendar_preference_mobile_business");

                entity.HasOne(d => d.ProductRetailCategoryFkNavigation)
                    .WithMany(p => p.RetailCustomerServiceCalendarPreference)
                    .HasForeignKey(d => d.ProductRetailCategoryFk)
                    .HasConstraintName("fk_retail_customer_service_calendar_preference_product_category");

                entity.HasOne(d => d.RetailCustomerFkNavigation)
                    .WithMany(p => p.RetailCustomerServiceCalendarPreference)
                    .HasForeignKey(d => d.RetailCustomerFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_retail_customer_service_calendar_preference_retail_customer");

                entity.HasOne(d => d.ServiceFkNavigation)
                    .WithMany(p => p.RetailCustomerServiceCalendarPreference)
                    .HasForeignKey(d => d.ServiceFk)
                    .HasConstraintName("fk_retail_customer_service_calendar_preference_service");
            });

            modelBuilder.Entity<RetailCustomerServiceLocationPreference>(entity =>
            {
                entity.ToTable("retail_customer_service_location_preference");

                entity.HasComment("For a given retail customer and service or product retail ccategory (class of services) this table holds the location prefrence of the retail customer as to receiving the serviceon an on-going basis; such as hair coloring. NOTE: if both product retail category is null and service is null the associated record shold be interpreted to indicate preferences for the mobile business as such.");

                entity.HasIndex(e => new { e.RetailCustomerFk, e.BusinessLocationFk, e.ProductRetailCategoryFk, e.ServiceFk })
                    .HasName("ux_retail_customer_service_location_preference")
                    .IsUnique();

                entity.Property(e => e.RetailCustomerServiceLocationPreferenceId)
                    .HasColumnName("retail_customer_service_location_preference_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.BusinessLocationFk)
                    .HasColumnName("business_location_fk")
                    .HasComment("Foriegn key to the associated business location which the retail customer prefers.");

                entity.Property(e => e.EndTimestamp)
                    .HasColumnName("end_timestamp")
                    .HasColumnType("datetime")
                    .HasComment("The moment the retail customer discontinued the preference.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.ProductRetailCategoryFk)
                    .HasColumnName("product_retail_category_fk")
                    .HasComment("Foreign key to the assocciated product retail category to which this scheduling calendar preference applies.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RetailCustomerFk)
                    .HasColumnName("retail_customer_fk")
                    .HasComment("Foreign key to aprent retail customer.");

                entity.Property(e => e.ServiceFk)
                    .HasColumnName("service_fk")
                    .HasComment("The exact service to which this expressed servingin prefernce applies.");

                entity.Property(e => e.StartTimestamp)
                    .HasColumnName("start_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The moment the preference was established.");

                entity.HasOne(d => d.BusinessLocationFkNavigation)
                    .WithMany(p => p.RetailCustomerServiceLocationPreference)
                    .HasForeignKey(d => d.BusinessLocationFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_retail_customer_service_location_preference_location");

                entity.HasOne(d => d.ProductRetailCategoryFkNavigation)
                    .WithMany(p => p.RetailCustomerServiceLocationPreference)
                    .HasForeignKey(d => d.ProductRetailCategoryFk)
                    .HasConstraintName("fk_retail_customer_service_location_preference_product_category");

                entity.HasOne(d => d.RetailCustomerFkNavigation)
                    .WithMany(p => p.RetailCustomerServiceLocationPreference)
                    .HasForeignKey(d => d.RetailCustomerFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_retail_customer_service_location_preference_retail_customer");

                entity.HasOne(d => d.ServiceFkNavigation)
                    .WithMany(p => p.RetailCustomerServiceLocationPreference)
                    .HasForeignKey(d => d.ServiceFk)
                    .HasConstraintName("fk_retail_customer_service_location_preference_service");
            });

            modelBuilder.Entity<RetailCustomerServiceSpecialDuration>(entity =>
            {
                entity.ToTable("retail_customer_service_special_duration");

                entity.HasComment("An intersection between the retail customer and service tables. The existence of a record indicates that the assocaited retail customer requires a non standard amount of time to receive the associated service.");

                entity.HasIndex(e => new { e.RetailCustomerFk, e.ProductRetailCategoryFk, e.ServiceFk })
                    .HasName("ux_retail_customer_service_special_duration_start_timestamp")
                    .IsUnique();

                entity.HasIndex(e => new { e.RetailCustomerFk, e.ProductRetailCategoryFk, e.ServiceFk, e.StartTimestamp })
                    .HasName("ux2_retail_customer_service_special_duration_start_timestamp")
                    .IsUnique();

                entity.Property(e => e.RetailCustomerServiceSpecialDurationId)
                    .HasColumnName("retail_customer_service_special_duration_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.EndTimestamp)
                    .HasColumnName("end_timestamp")
                    .HasColumnType("datetime")
                    .HasComment("The moment the retail customer discontinued the preference.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.ProductRetailCategoryFk)
                    .HasColumnName("product_retail_category_fk")
                    .HasComment("Foreign key to associated product retail category - a set of services vs a set of goods which the associated retail customer which the customer wants to get, when she gets those services, from the associated moabile business employee. NOTE: this field can be null since the record may be at the individual service level; also the record can be null for both serivce and product retail category in which case the record should be interpresented to indicate a general perference of the customer to receive all services available from the indirectly associated mobile business from the associated mobile business employee.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RetailCustomerFk)
                    .HasColumnName("retail_customer_fk")
                    .HasComment("Foreign key to associated retail customers who has indicated these preferences.");

                entity.Property(e => e.ServiceFk)
                    .HasColumnName("service_fk")
                    .HasComment("Foreign key to the assocaited service. NOTE: this field can be null since the record may be at the poduct retail category level (where the product retail category is for a set of services vs a set of goods); also the record can be null for both serivce and product retail category in which case the record should be interpresented to indicate a general perference of the customer to receive all services available from the indirectly associated mobile business from the associated mobile business employee.");

                entity.Property(e => e.SpecialDurationAsARatios)
                    .HasColumnName("special_duration_as_a_ratios")
                    .HasColumnType("decimal(5, 4)")
                    .HasComment("The number of minutes it takes this customer to receive this service compared to normal - expressed as a ratio. For eample, my partly black son takes longer to get a hair cut that might be 1.8 - 80% more than normal.");

                entity.Property(e => e.SpecialDurationInMinutes)
                    .HasColumnName("special_duration_in_minutes")
                    .HasComment("The number of minutes it takes this customer to receive this service. FOr eample, my partly black son takes longer to get a hair cut.");

                entity.Property(e => e.StartTimestamp)
                    .HasColumnName("start_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The moment the preference was established.");

                entity.HasOne(d => d.ProductRetailCategoryFkNavigation)
                    .WithMany(p => p.RetailCustomerServiceSpecialDuration)
                    .HasForeignKey(d => d.ProductRetailCategoryFk)
                    .HasConstraintName("fk_retail_customer_service_sd_preference_product_category");

                entity.HasOne(d => d.RetailCustomerFkNavigation)
                    .WithMany(p => p.RetailCustomerServiceSpecialDuration)
                    .HasForeignKey(d => d.RetailCustomerFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_retail_customer_service_sd_preference_retail_customer");

                entity.HasOne(d => d.ServiceFkNavigation)
                    .WithMany(p => p.RetailCustomerServiceSpecialDuration)
                    .HasForeignKey(d => d.ServiceFk)
                    .HasConstraintName("fk_retail_customer_service_sd_preference_service");
            });

            modelBuilder.Entity<RetailCustomerServicerPreference>(entity =>
            {
                entity.HasKey(e => e.RetailCustomerServicePreferenceId)
                    .HasName("pk_retail_customer_service_preference_retail_customer_service_preference_id");

                entity.ToTable("retail_customer_servicer_preference");

                entity.HasComment("A three way intersection between the retail customer and mobile business_employee tables. The existence of a record indicates that the associated retail customer prefers to receive the the associated service from the associated mobile business employee - the record also has the necessary implication that the associated mobile business employee is qualified to perform the associated service.");

                entity.HasIndex(e => new { e.RetailCustomerFk, e.MobileBusinessEmployeeFk, e.ProductRetailCategoryFk, e.ProfessionalServiceFk, e.StartTimestamp })
                    .HasName("ux_retail_customer_servicer_preference")
                    .IsUnique();

                entity.Property(e => e.RetailCustomerServicePreferenceId)
                    .HasColumnName("retail_customer_service_preference_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.EndTimestamp)
                    .HasColumnName("end_timestamp")
                    .HasColumnType("datetime")
                    .HasComment("The moment the retail customer discontinued the preference.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.MobileBusinessEmployeeFk)
                    .HasColumnName("mobile_business_employee_fk")
                    .HasComment("Foreign key to prefered mobile business employee.");

                entity.Property(e => e.ProductRetailCategoryFk)
                    .HasColumnName("product_retail_category_fk")
                    .HasComment("Foreign key to associated product retail category - a set of services vs a set of goods which the associated retail customer which the customer wants to get, when she gets those services, from the associated mobile business employee. NOTE: this field can be null since the record may be at the individual service level; also the record can be null for both service and product retail category in which case the record should be represented to indicate a general preference of the customer to receive all services available from the indirectly associated mobile business from the associated mobile business employee.");

                entity.Property(e => e.ProfessionalServiceFk)
                    .HasColumnName("professional_service_fk")
                    .HasComment("Foreign key to the assocaited service. NOTE: this field can be null since the record may be at the poduct retail category level (where the product retail category is for a set of services vs a set of goods); also the record can be null for both serivce and product retail category in which case the record should be interpresented to indicate a general perference of the customer to receive all services available from the indirectly associated mobile business from the associated mobile business employee.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RetailCustomerFk)
                    .HasColumnName("retail_customer_fk")
                    .HasComment("Foreign key to associated retail customers who has indicated these preferences.");

                entity.Property(e => e.StartTimestamp)
                    .HasColumnName("start_timestamp")
                    .HasColumnType("datetime")
                    .HasComment("The moment the preference was established.");

                entity.HasOne(d => d.MobileBusinessEmployeeFkNavigation)
                    .WithMany(p => p.RetailCustomerServicerPreference)
                    .HasForeignKey(d => d.MobileBusinessEmployeeFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_retail_customer_servicer_preference_mobile_business_employee");

                entity.HasOne(d => d.ProductRetailCategoryFkNavigation)
                    .WithMany(p => p.RetailCustomerServicerPreference)
                    .HasForeignKey(d => d.ProductRetailCategoryFk)
                    .HasConstraintName("fk_retail_customer_servicer_preference_product_category");

                entity.HasOne(d => d.ProfessionalServiceFkNavigation)
                    .WithMany(p => p.RetailCustomerServicerPreference)
                    .HasForeignKey(d => d.ProfessionalServiceFk)
                    .HasConstraintName("fk_retail_customer_servicer_preference_service");

                entity.HasOne(d => d.RetailCustomerFkNavigation)
                    .WithMany(p => p.RetailCustomerServicerPreference)
                    .HasForeignKey(d => d.RetailCustomerFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_retail_customer_servicer_preference_retail_customer");
            });

            modelBuilder.Entity<RetailCustomerTrustedTradePrompt>(entity =>
            {
                entity.ToTable("retail_customer_trusted_trade_prompt");

                entity.HasComment("An intersection between the retail customer and trusted trade prompt tables. The existence of a record indicates that the associated retail customer has be given the associated trusted trade prompt. This table amount to coupons in a change purse held a few decades back. NOTE: the retail_customer foerign key actually points to the person table since we need to give trusted trade prompts to newly invited prospects so that they have deals as soon as they join, as well as retail customers already in the game.");

                entity.HasIndex(e => new { e.RetailCustomerFk, e.TrustedTradePromptFk })
                    .HasName("ux_retail_customer_trusted_trade_prompt")
                    .IsUnique();

                entity.Property(e => e.RetailCustomerTrustedTradePromptId)
                    .HasColumnName("retail_customer_trusted_trade_prompt_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.DropDatetime)
                    .HasColumnName("drop_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExpirationDatetime)
                    .HasColumnName("expiration_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NumberOfTimesViewed).HasColumnName("number_of_times_viewed");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RetailCustomerFk)
                    .HasColumnName("retail_customer_fk")
                    .HasComment("Foreign key to associated retail customer.");

                entity.Property(e => e.TrustedTradePromptFk)
                    .HasColumnName("trusted_trade_prompt_fk")
                    .HasComment("Foreign key to associated trusted trade prompt");

                entity.Property(e => e.ViewDatetime)
                    .HasColumnName("view_datetime")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.RetailCustomerFkNavigation)
                    .WithMany(p => p.RetailCustomerTrustedTradePrompt)
                    .HasForeignKey(d => d.RetailCustomerFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_retail_customer_trusted_trade_prompt_retail_customer");

                entity.HasOne(d => d.TrustedTradePromptFkNavigation)
                    .WithMany(p => p.RetailCustomerTrustedTradePrompt)
                    .HasForeignKey(d => d.TrustedTradePromptFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_retail_customer_trusted_trade_prompt_trusted_trade_prompt");
            });

            modelBuilder.Entity<RetailCustomerVirtuePoints>(entity =>
            {
                entity.ToTable("retail_customer_virtue_points");

                entity.HasComment("A 3 way intersection between the retail customer, mobile business and virtues tables. Each record holds the current number of points that have been earned by the associated retail customer on the dimension of the associated virtue at the associated mobile business.");

                entity.HasIndex(e => new { e.RetailCustomerFk, e.MobileBusinessFk, e.VirtueFk })
                    .HasName("ux_retail_customer_virtue_points");

                entity.Property(e => e.RetailCustomerVirtuePointsId)
                    .HasColumnName("retail_customer_virtue_points_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.CurrentPointBalance)
                    .HasColumnName("current_point_balance")
                    .HasComment("The number of points the retail customer currently has in the caegory of the associated virtue.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MobileBusinessFk)
                    .HasColumnName("mobile_business_fk")
                    .HasComment("Foriegn key to associated mobile business. It must be kept in mnd that virtues, such as loyalty, only realy make sense for a retail customer in their relationship to a particular mobile business.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RetailCustomerFk)
                    .HasColumnName("retail_customer_fk")
                    .HasComment("Foriegn key to associated retail customer.");

                entity.Property(e => e.UniversalVirtueGradeFk)
                    .HasColumnName("universal_virtue_grade_fk")
                    .HasComment("Foreign key to the universal virtue grade applicable to the associated customer in the given virtue. NOTE: this field is really a dervied field, but making it explicit has the effect of grand fathering virtue grade  for retail customers that would otherwise be affected by rises in the point thresholds for virtue grades.");

                entity.Property(e => e.VirtueFk)
                    .HasColumnName("virtue_fk")
                    .HasComment("Foreign key to assocaited virtue.");

                entity.HasOne(d => d.MobileBusinessFkNavigation)
                    .WithMany(p => p.RetailCustomerVirtuePoints)
                    .HasForeignKey(d => d.MobileBusinessFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_retail_customer_virtue_points_mobile_business");

                entity.HasOne(d => d.RetailCustomerFkNavigation)
                    .WithMany(p => p.RetailCustomerVirtuePoints)
                    .HasForeignKey(d => d.RetailCustomerFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_retail_customer_virtue_points_retail_customer");

                entity.HasOne(d => d.UniversalVirtueGradeFkNavigation)
                    .WithMany(p => p.RetailCustomerVirtuePoints)
                    .HasForeignKey(d => d.UniversalVirtueGradeFk)
                    .HasConstraintName("Fk_retail_customer_virtue_points_universal_virtue_grade");

                entity.HasOne(d => d.VirtueFkNavigation)
                    .WithMany(p => p.RetailCustomerVirtuePoints)
                    .HasForeignKey(d => d.VirtueFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_retail_customer_virtue_points_virtue");
            });

            modelBuilder.Entity<ReverseAuction>(entity =>
            {
                entity.ToTable("reverse_auction");

                entity.HasComment("An auction in which the buyer posts a requirement and the bidders bid to fulfill that reirement.  This can be for a good or service and the buyer may have a reputation score threshold or may simply count reputation as part of counting the desirability of the bid.");

                entity.HasIndex(e => e.AuctionName)
                    .HasName("ux_reverse_auction")
                    .IsUnique();

                entity.Property(e => e.ReverseAuctionId)
                    .HasColumnName("reverse_auction_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.AuctionName)
                    .HasColumnName("auction_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Promotional text name of an auction.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ReverseAuctionItem>(entity =>
            {
                entity.ToTable("reverse_auction_item");

                entity.HasComment("A request up for bid on a reverse auction.");

                entity.HasIndex(e => new { e.ReverseAuctionFk, e.LotNumber })
                    .HasName("ux_reverse_auction_item")
                    .IsUnique();

                entity.Property(e => e.ReverseAuctionItemId)
                    .HasColumnName("reverse_auction_item_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.AuctionCloseTimestamp)
                    .HasColumnName("auction_close_timestamp")
                    .HasColumnType("datetime")
                    .HasComment("The moment the auction stops accepting bids for item fulfillment.");

                entity.Property(e => e.AuctionOpenTimestamp)
                    .HasColumnName("auction_open_timestamp")
                    .HasColumnType("datetime")
                    .HasComment("The moment the revverse aution request begins to accept bids.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.LotNumber)
                    .HasColumnName("lot_number")
                    .HasComment("The identifier of a auction item in auction order (low tech) or just a identification number.");

                entity.Property(e => e.MaximumPricePer)
                    .HasColumnName("maximum_price_per")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("The most the retail customer will pay for the reverse auction good(s).");

                entity.Property(e => e.QuantityRequested)
                    .HasColumnName("quantity_requested")
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("The number of items being requested.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ReverseAuctionFk)
                    .HasColumnName("reverse_auction_fk")
                    .HasComment("Foreign key to parent reverse auction.");

                entity.Property(e => e.UnitOfMeasure)
                    .HasColumnName("unit_of_measure")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("Unit of measure for the item such as kilo gram, box, each.");

                entity.Property(e => e.UniversalItemFk)
                    .HasColumnName("universal_item_fk")
                    .HasComment("Foreign key to universal item.");

                entity.Property(e => e.WinningBid)
                    .HasColumnName("winning_bid")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("Dollar amount (per unit) of the winning bid.");

                entity.Property(e => e.WinningBidderFk)
                    .HasColumnName("winning_bidder_fk")
                    .HasComment("Foriegn key to mobile vendor who won the auction - the right to fulfill the request with their instance of the universal item and the bid price. NOTE: this field is nullable since it might be the case that no vendor in the game with a qualifying product was willing to taker as little as the retail customers maximum price.");

                entity.HasOne(d => d.ReverseAuctionFkNavigation)
                    .WithMany(p => p.ReverseAuctionItem)
                    .HasForeignKey(d => d.ReverseAuctionFk)
                    .HasConstraintName("fk_reverse_auction_item_reverse_auction");

                entity.HasOne(d => d.UniversalItemFkNavigation)
                    .WithMany(p => p.ReverseAuctionItem)
                    .HasForeignKey(d => d.UniversalItemFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_reverse_auction_item_universal_item");

                entity.HasOne(d => d.WinningBidderFkNavigation)
                    .WithMany(p => p.ReverseAuctionItem)
                    .HasForeignKey(d => d.WinningBidderFk)
                    .HasConstraintName("fk_reverse_auction_item_mobile_business");
            });

            modelBuilder.Entity<RoleOperationalFunction>(entity =>
            {
                entity.ToTable("role_operational_function");

                entity.HasComment("An interscetion table betweeen the role and operatioinal function tables. The existence of a record indicates that the associated role is authorized to perform the associated platform operational function.");

                entity.HasIndex(e => new { e.PlatformRoleFk, e.PlatformOperationalFunctionFk })
                    .HasName("ux_role_operational_function")
                    .IsUnique();

                entity.Property(e => e.RoleOperationalFunctionId)
                    .HasColumnName("role_operational_function_id")
                    .HasComment("System geenerated surrogate priimary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.PlatformOperationalFunctionFk)
                    .HasColumnName("platform_operational_function_fk")
                    .HasComment("Foreign key to platform_operational function.");

                entity.Property(e => e.PlatformRoleFk)
                    .HasColumnName("platform_role_fk")
                    .HasComment("Foreign key to parent platform role.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.PlatformOperationalFunctionFkNavigation)
                    .WithMany(p => p.RoleOperationalFunction)
                    .HasForeignKey(d => d.PlatformOperationalFunctionFk)
                    .HasConstraintName("fk_role_operational_function_operational_function");

                entity.HasOne(d => d.PlatformRoleFkNavigation)
                    .WithMany(p => p.RoleOperationalFunction)
                    .HasForeignKey(d => d.PlatformRoleFk)
                    .HasConstraintName("fk_role_operational_function_role");
            });

            modelBuilder.Entity<Shipment>(entity =>
            {
                entity.ToTable("shipment");

                entity.HasComment("The Shipment table contains all of the associated shipments associated with a Cart.");

                entity.HasIndex(e => new { e.CartFk, e.DeliveryId })
                    .HasName("ux_shipment")
                    .IsUnique();

                entity.Property(e => e.ShipmentId)
                    .HasColumnName("shipment_id")
                    .HasComment("System generated surrogate primry key.");

                entity.Property(e => e.CartFk)
                    .HasColumnName("cart_fk")
                    .HasComment("Foreign key to parent cart.");

                entity.Property(e => e.DeliveryId)
                    .HasColumnName("delivery_id")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("Exstenal Delivery ID provided by a carrier to tie to shipment.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ShipmentStatus)
                    .HasColumnName("shipment_status")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentTypeCd)
                    .HasColumnName("shipment_type_cd")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("Shipment_type_cd: Same Day Delivery  = Standard Shipping = Pick-up");

                entity.HasOne(d => d.CartFkNavigation)
                    .WithMany(p => p.Shipment)
                    .HasForeignKey(d => d.CartFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_shipment_cart");
            });

            modelBuilder.Entity<Smartphone>(entity =>
            {
                entity.ToTable("smartphone");

                entity.HasComment("The following table contains the telephone number assigned to parties.");

                entity.HasIndex(e => new { e.CountryCode, e.PhoneNumber })
                    .HasName("ux_telephone")
                    .IsUnique();

                entity.Property(e => e.SmartphoneId)
                    .HasColumnName("smartphone_id")
                    .HasComment("Primary key and a foreign key to devise. This means that a smart phone is a kind of a device.")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasColumnName("country_code")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("((1))")
                    .HasComment("The telephone number prefix.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phone_number")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("Actual number to \"dial\"");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.SmartphoneNavigation)
                    .WithOne(p => p.Smartphone)
                    .HasForeignKey<Smartphone>(d => d.SmartphoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_smaret_phone_device");
            });

            modelBuilder.Entity<StateOrProvince>(entity =>
            {
                entity.ToTable("state_or_province");

                entity.HasComment("Sub-division of a country such as the states or the united states or India; or the provinces of Canada.");

                entity.Property(e => e.StateOrProvinceId)
                    .HasColumnName("state_or_province_id")
                    .HasComment("System generated surrogate primay key.");

                entity.Property(e => e.CountryFk)
                    .HasColumnName("country_fk")
                    .HasComment("Foreign key to parent country.");

                entity.Property(e => e.LastUpdateTimeStamp)
                    .HasColumnName("last_update_time_stamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.PostalAbbreviation)
                    .IsRequired()
                    .HasColumnName("postal_abbreviation")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasComment("Abbreviuation as used on international mail, such as NY.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.StateOrProvinceName)
                    .IsRequired()
                    .HasColumnName("state_or_province_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Human readabl e name of state of province.");

                entity.Property(e => e.TimeZoneGreenwichOffset).HasColumnName("time_zone_greenwich_offset");

                entity.HasOne(d => d.CountryFkNavigation)
                    .WithMany(p => p.StateOrProvince)
                    .HasForeignKey(d => d.CountryFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_state_or_province_country");
            });

            modelBuilder.Entity<SubsriptionModification>(entity =>
            {
                entity.HasKey(e => e.SubscriptionModificationId)
                    .HasName("pk_subsription_modification_subscription_modification_id");

                entity.ToTable("subsription_modification");

                entity.HasComment("A modification to a subscription for a product; either the price or the periodicity.");

                entity.HasIndex(e => new { e.ProductSubscriptionFk, e.StartDate })
                    .HasName("idx_subsription_modification")
                    .IsUnique();

                entity.Property(e => e.SubscriptionModificationId)
                    .HasColumnName("subscription_modification_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.NewPrice)
                    .HasColumnName("new_price")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("The new price for the subscription");

                entity.Property(e => e.PeriodicPurchaseRate)
                    .HasColumnName("periodic_purchase_rate")
                    .HasComment("The days between each purchase.");

                entity.Property(e => e.ProductSubscriptionFk)
                    .HasColumnName("product_subscription_fk")
                    .HasComment("Foreign key to parent product subscription.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("date")
                    .HasComment("The date the new subscription parameters come to be effective.");

                entity.HasOne(d => d.ProductSubscriptionFkNavigation)
                    .WithMany(p => p.SubsriptionModification)
                    .HasForeignKey(d => d.ProductSubscriptionFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_subsription_modification_product_subscription");
            });

            modelBuilder.Entity<Survey>(entity =>
            {
                entity.ToTable("survey");

                entity.HasComment("A survey given to a retail customer, an employee of a mobile business or revive or even a mobile business - thus, if effect, the owner.");

                entity.HasIndex(e => e.SurveyName)
                    .HasName("ux_survey")
                    .IsUnique();

                entity.Property(e => e.SurveyId)
                    .HasColumnName("survey_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.AppliesByDefaultFlag)
                    .IsRequired()
                    .HasColumnName("applies_by_default_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("'Y'es / 'N'o flag to indicate if the survey should be applied to all mobile business customers. NOTE: where the test is not a default one, then the mobile businesses to which the survey applies are documented in a detail table platform_customer_survey_mobile_business.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SponsorFk)
                    .HasColumnName("sponsor_fk")
                    .HasComment("Who is giving the survey - a mobile business or perhaps ReVyvv. Null means we are giving the survey.");

                entity.Property(e => e.SurveyName)
                    .IsRequired()
                    .HasColumnName("survey_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SurveyTrigger)
                    .HasColumnName("survey_trigger")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("How often should the survey arise? Upon every check out. Upon the user reporting receipt of goods, etc.");

                entity.Property(e => e.TargetIndicator)
                    .HasColumnName("target_indicator")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Who is taking the survey - retail customers or perhaps business owners. 'OWN' means owner and \"RC\" mean retail customer.");
            });

            modelBuilder.Entity<SurveyQuestion>(entity =>
            {
                entity.ToTable("survey_question");

                entity.HasComment("A question to be asked on a given parent survey.");

                entity.HasIndex(e => new { e.SurveyFk, e.TextOfQuestion })
                    .HasName("ux_survey_question")
                    .IsUnique();

                entity.Property(e => e.SurveyQuestionId)
                    .HasColumnName("survey_question_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ResponseTypeIndicator)
                    .HasColumnName("response_type_indicator")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComment("Scale - such as 1 to 5, or\\nOpen text or \\npick from a predefined set of answers");

                entity.Property(e => e.ScaleMaximum)
                    .HasColumnName("scale_maximum")
                    .HasComment("The max integer response to a question with a scale answer, such as 5 or 10");

                entity.Property(e => e.ScaleMinimum)
                    .HasColumnName("scale_minimum")
                    .HasComment("Minimum scale of scale answers such as 1.");

                entity.Property(e => e.SurveyFk)
                    .HasColumnName("survey_fk")
                    .HasComment("Foriegn key to parent survey.");

                entity.Property(e => e.TextOfQuestion)
                    .HasColumnName("text_of_question")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("Human readable question test.");

                entity.HasOne(d => d.SurveyFkNavigation)
                    .WithMany(p => p.SurveyQuestion)
                    .HasForeignKey(d => d.SurveyFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_survey_question_survey");
            });

            modelBuilder.Entity<SurveyQuestionPredefinedReponse>(entity =>
            {
                entity.ToTable("survey_question_predefined_reponse");

                entity.HasComment("FOr a given survey question a set of predefined answers. For example, what is your income?\\n0 - $25k - $25k to $50k - $50K to $100K - $100K and up");

                entity.HasIndex(e => e.SurveyQuestionPredefinedReponseId)
                    .HasName("Unq_survet_question_predefined_reponse_alternative_survet_question_predefined_reponse_alternative")
                    .IsUnique();

                entity.Property(e => e.SurveyQuestionPredefinedReponseId)
                    .HasColumnName("survey_question_predefined_reponse_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.AnswerChoiceText)
                    .HasColumnName("answer_choice_text")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("The answer choice text the survey participant selects.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SurveyQuestionFk)
                    .HasColumnName("survey_question_fk")
                    .HasComment("Foreign key to parnet survey question.");

                entity.HasOne(d => d.SurveyQuestionFkNavigation)
                    .WithMany(p => p.SurveyQuestionPredefinedReponse)
                    .HasForeignKey(d => d.SurveyQuestionFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_survet_question_predefined_reponse_alternative_sq");
            });

            modelBuilder.Entity<SurveyResponse>(entity =>
            {
                entity.HasKey(e => e.CusotmerSurveyResponseId)
                    .HasName("pk_cusotmer_survey_response_cusotmer_survey_response_id");

                entity.ToTable("survey_response");

                entity.HasComment("A record of the answers to survey questions given by woners or retail customer sor who ever took the survey.");

                entity.HasIndex(e => e.SurveyQuestionFk)
                    .HasName("ux_customer_survey_response")
                    .IsUnique();

                entity.Property(e => e.CusotmerSurveyResponseId)
                    .HasColumnName("cusotmer_survey_response_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ScaledAnswer)
                    .HasColumnName("scaled_answer")
                    .HasComment("Answer such as 3 in the context of a scale of 1 to 5.");

                entity.Property(e => e.SurvetQuestionPredefinedReponseFk)
                    .HasColumnName("survet_question_predefined_reponse_fk")
                    .HasComment("A foreign key to the selected predefined answer. NOTE: the feld is nullable since not all questions have a predefined set of answers.");

                entity.Property(e => e.SurveyQuestionFk)
                    .HasColumnName("survey_question_fk")
                    .HasComment("Foreign key to associated survey question.");

                entity.Property(e => e.TextAnswer)
                    .HasColumnName("text_answer")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("Answer to open ended question.");

                entity.HasOne(d => d.SurvetQuestionPredefinedReponseFkNavigation)
                    .WithMany(p => p.SurveyResponse)
                    .HasForeignKey(d => d.SurvetQuestionPredefinedReponseFk)
                    .HasConstraintName("fk_survey_response_survey_question_predefined_reponse");

                entity.HasOne(d => d.SurveyQuestionFkNavigation)
                    .WithOne(p => p.SurveyResponse)
                    .HasForeignKey<SurveyResponse>(d => d.SurveyQuestionFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_customer_survey_response_survey_question");
            });

            modelBuilder.Entity<Tablet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tablet");

                entity.HasComment("A cross between a smart phone and a laptop. Execelent for the use of our platform, especially for mobile business owners. The tablet has no incremenal attributes over and above those of the inherentence hierarchy parent - device. Therefore the table simply has a foerign key to device which indicates that the device is a tablet - as apposed to being something else.");

                entity.Property(e => e.TabletId)
                    .HasColumnName("tablet_id")
                    .HasComment("System generated surrogate primary key and a foriegn key to the inheritence hierarchy parent - device.");

                entity.HasOne(d => d.TabletNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.TabletId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_tablet_device");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.ToTable("tag");

                entity.HasComment("A property or tag to be attached to any number of products and product retail categories. For Example, 50% or more cotton.");

                entity.HasIndex(e => e.TagText)
                    .HasName("ux_tag")
                    .IsUnique();

                entity.Property(e => e.TagId)
                    .HasColumnName("tag_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TagText)
                    .IsRequired()
                    .HasColumnName("tag_text")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("Actual tag such as silk.");
            });

            modelBuilder.Entity<TaxItemType>(entity =>
            {
                entity.ToTable("tax_item_type");

                entity.HasComment("A list of goods and services categories. The point of having the list is that these types are taxed differently ornot taxed in the different states of the United States. As each mobile business signs up that business needs to specify what type its offered items fall into.");

                entity.HasIndex(e => e.TaxTypeName)
                    .HasName("ux_tax_item_type")
                    .IsUnique();

                entity.Property(e => e.TaxItemTypeId)
                    .HasColumnName("tax_item_type_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TaxTypeName)
                    .IsRequired()
                    .HasColumnName("tax_type_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Text name of the type. Values are \"general Taxable\", \"clothing\", \"food\", \"candy\", \"freight\", \"Pro Services\", \"supplements\", \"Installation Services\", \"Exempt Service\", \"Meeals\", \"Nontax\".");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test", "dbo");

                entity.Property(e => e.SqlString)
                    .HasColumnName("sql_string")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TestSql>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TestSQL");

                entity.Property(e => e.Sqlstring)
                    .HasColumnName("SQLString")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ThirdPartyServiceProvider>(entity =>
            {
                entity.ToTable("third_party_service_provider");

                entity.HasComment("A vendor who provides some auxiliary service within the platform. For example, a vendor might clean or repair or do scheduled maintenance on a serialized rentable product on behalf of a mobile business.");

                entity.Property(e => e.ThirdPartyServiceProviderId)
                    .HasColumnName("third_party_service_provider_id")
                    .HasComment("System genrated surrogate primry key.")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ThirdPartyServiceProviderNavigation)
                    .WithOne(p => p.ThirdPartyServiceProvider)
                    .HasForeignKey<ThirdPartyServiceProvider>(d => d.ThirdPartyServiceProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_maintenance_vendor_organization");
            });

            modelBuilder.Entity<TokenExchangeRate>(entity =>
            {
                entity.ToTable("token_exchange_rate");

                entity.HasComment("The current exchange rates for platform tokens");

                entity.HasIndex(e => e.OutsideCurrencyCode)
                    .HasName("ux_token_exchange_rate")
                    .IsUnique();

                entity.Property(e => e.TokenExchangeRateId)
                    .HasColumnName("token_exchange_rate_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.OutsideCurrencyCode)
                    .IsRequired()
                    .HasColumnName("outside_currency_code")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("The code for the outside currency such as USD.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TokenAsk)
                    .HasColumnName("token_ask")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("The number of outside currency units ( such as US dollars) we will sell tokens for.");

                entity.Property(e => e.TokenBid)
                    .HasColumnName("token_bid")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("The number of units of the outside currency (such as US dollars) we will buy tokens for.");
            });

            modelBuilder.Entity<TrustedTradePrompt>(entity =>
            {
                entity.ToTable("trusted_trade_prompt");

                entity.HasComment("The net of an offer for agiven retail customer. I say net since this bakes in the included and excluded geographies, as well as perhaps different amounts of dicount for different customer segments. NOTE: !!! this is a dervied table.");

                entity.Property(e => e.TrustedTradePromptId)
                    .HasColumnName("trusted_trade_prompt_id")
                    .HasComment("System generated surrogate primary key.")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdCopy)
                    .HasColumnName("ad_copy")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("The text for the user to see that communicates the offer.");

                entity.Property(e => e.DurationInMinutes).HasColumnName("duration_in_minutes");

                entity.Property(e => e.GoodsOrServicesIndicator)
                    .IsRequired()
                    .HasColumnName("goods_or_services_indicator")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("'G' mean sthe trusted trade prompt is primarily about / should be calssified as being about goods\\n'S' mean sthe trusted trade prompt is primarily about / should be calssified as being about services");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(12, 2)")
                    .HasComment("The offered price on this truted trade prompt. NOTE: the row is at the retail customer level.");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .HasColumnName("row_version")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TrustedTradeTypeFk)
                    .HasColumnName("trusted_trade_type_fk")
                    .HasComment("Foreign key to trusted trade type - classification of trusted trade prompts.");

                entity.Property(e => e.UpdateTimestamp)
                    .HasColumnName("update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WeightingFactor)
                    .HasColumnName("weighting_factor")
                    .HasDefaultValueSql("((100))")
                    .HasComment("A sorting factor to drive the order of appearance of the trusted trade prompt on the deal board screen for the retail customer. The idea is that resource balancing deals would get a higher wieght and so forth. Furthermore, weight is not the only factor. The time till expiration will also determine the final caluclated weight. NOTE: is established as the ideal-mean score.");

                entity.HasOne(d => d.TrustedTradeTypeFkNavigation)
                    .WithMany(p => p.TrustedTradePrompt)
                    .HasForeignKey(d => d.TrustedTradeTypeFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_trusted_trade_prompt_trusted_trade_type");
            });

            modelBuilder.Entity<TrustedTradePromptProduct>(entity =>
            {
                entity.ToTable("trusted_trade_prompt_product");

                entity.HasComment("The detail for a trusted trade prompt, each row represent a product that is on offer as part of the parent trusted trade prompt. NOTE: a trusted trade prompt can have more than one product in this detail table; also, a product may appear here in qualtity 3 and the add copy may be 3 for the price of 2 and the price maatched the indiivudal proce times 2 - that would be a sensible and convertional trausted trade prompt.");

                entity.HasIndex(e => new { e.TrustedTradePromptFk, e.ProductFk })
                    .HasName("ux_trusted_trade_prompt_product")
                    .IsUnique();

                entity.Property(e => e.TrustedTradePromptProductId)
                    .HasColumnName("trusted_trade_prompt_product_id")
                    .HasComment("System generated surrogate primpry key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.ProductFk)
                    .HasColumnName("product_fk")
                    .HasComment("Foreign key to associated mobile business product.");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasComment("The number of product to purchase to particpate in the trusted trade prompt - as a deal.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TrustedTradePromptFk)
                    .HasColumnName("trusted_trade_prompt_fk")
                    .HasComment("Fopreign key to parent trusted trade prompt.");

                entity.HasOne(d => d.ProductFkNavigation)
                    .WithMany(p => p.TrustedTradePromptProduct)
                    .HasForeignKey(d => d.ProductFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_trusted_trade_prompt_product_product");

                entity.HasOne(d => d.TrustedTradePromptFkNavigation)
                    .WithMany(p => p.TrustedTradePromptProduct)
                    .HasForeignKey(d => d.TrustedTradePromptFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_trusted_trade_prompt_product_trusted_trade_prompt");
            });

            modelBuilder.Entity<TrustedTradePromptProductRetailCategory>(entity =>
            {
                entity.HasKey(e => e.TrustedTradePromptProductId)
                    .HasName("Pk_trusted_trade_prompt_product_trusted_trade_prompt_product_id_0");

                entity.ToTable("trusted_trade_prompt_product_retail_category");

                entity.HasComment("The detail for a trusted trade prompt, each row represent a product retail category that is on offer as part of the parent trusted trade prompt. NOTE: a trusted trade prompt can have more than one product in this detail table; also, a product may appear here in qualtity 3 and the add copy may be 3 for the price of 2 and the price maatched the indiivudal proce times 2 - that would be a sensible and convertional trausted trade prompt.");

                entity.HasIndex(e => new { e.TrustedTradePromptFk, e.ProductRetailCategoryFk })
                    .HasName("ux_trusted_trade_prompt_product_retail_category")
                    .IsUnique();

                entity.Property(e => e.TrustedTradePromptProductId)
                    .HasColumnName("trusted_trade_prompt_product_id")
                    .HasComment("System generated surrogate primpry key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.ProductRetailCategoryFk)
                    .HasColumnName("product_retail_category_fk")
                    .HasComment("Foreign key to associated mobile business product retail category.");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasComment("The number of product to purchase to particpate in the trusted trade prompt - as a deal.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TrustedTradePromptFk)
                    .HasColumnName("trusted_trade_prompt_fk")
                    .HasComment("Fopreign key to parent trusted trade prompt.");

                entity.HasOne(d => d.ProductRetailCategoryFkNavigation)
                    .WithMany(p => p.TrustedTradePromptProductRetailCategory)
                    .HasForeignKey(d => d.ProductRetailCategoryFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_trusted_trade_prompt_product_retail_category_product_retail_category");

                entity.HasOne(d => d.TrustedTradePromptFkNavigation)
                    .WithMany(p => p.TrustedTradePromptProductRetailCategory)
                    .HasForeignKey(d => d.TrustedTradePromptFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_trusted_trade_prompt_product_retail_category_trusted_trade_prompt");
            });

            modelBuilder.Entity<TrustedTradeType>(entity =>
            {
                entity.ToTable("trusted_trade_type");

                entity.HasComment("A classification of trusted trade primpts. For example, Deal of the day, Hot deal, VIP deal, Most popular deal.");

                entity.HasIndex(e => e.TextDescription)
                    .HasName("ux_trusted_trade_type")
                    .IsUnique();

                entity.HasIndex(e => e.TextName)
                    .HasName("ux_trusted_trade_type2")
                    .IsUnique();

                entity.Property(e => e.TrustedTradeTypeId)
                    .HasColumnName("trusted_trade_type_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TextDescription)
                    .IsRequired()
                    .HasColumnName("text_description")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("Human readable text description of the type such as \"Hot Deal\".");

                entity.Property(e => e.TextName)
                    .IsRequired()
                    .HasColumnName("text_name")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("Label for the type.");
            });

            modelBuilder.Entity<UniversalBadge>(entity =>
            {
                entity.ToTable("universal_badge");

                entity.HasComment("A list of 10 badges that can be earned by the retail customer. NOTE: A retail customer can trade five badges for a  personal black friday.");

                entity.HasIndex(e => new { e.BadgeTypeIndicator, e.QualificationThreshold })
                    .HasName("ux_universal_badge")
                    .IsUnique();

                entity.Property(e => e.UniversalBadgeId)
                    .HasColumnName("universal_badge_id")
                    .HasComment("System generated surrogate primey key.");

                entity.Property(e => e.BadgeTypeIndicator)
                    .IsRequired()
                    .HasColumnName("badge_type_indicator")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("'D' days in a row with at least one purchse\\n'W' weeks in a row with at least one purchase\\n'P' purchases in one day");

                entity.Property(e => e.QualificationThreshold)
                    .HasColumnName("qualification_threshold")
                    .HasComment("The number of purchases or number of days or weeks need to qualify for the badge.");
            });

            modelBuilder.Entity<UniversalItem>(entity =>
            {
                entity.ToTable("universal_item");

                entity.HasComment("A item that has been identified as available from multiple mobile businesses.");

                entity.HasIndex(e => e.ItemName)
                    .HasName("idx_universal_item")
                    .IsUnique();

                entity.Property(e => e.UniversalItemId)
                    .HasColumnName("universal_item_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.ItemName)
                    .HasColumnName("item_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Human readable text of univeral item.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<UniversalItemSource>(entity =>
            {
                entity.ToTable("universal_item_source");

                entity.HasComment("For a given universal item this table holds the list of sources for that item. That is, the mobile business products or bundles that count as a legitimate fulfillment of the given universal item.");

                entity.HasIndex(e => new { e.UniversalItemFk, e.ProductFk })
                    .HasName("ux_universal_item_source")
                    .IsUnique();

                entity.Property(e => e.UniversalItemSourceId)
                    .HasColumnName("universal_item_source_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.ProductFk)
                    .HasColumnName("product_fk")
                    .HasComment("Foreign key to product that constitutes a legitimate instance of this universal item. NOTE: nullable since the record may point to a bundle.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UniversalItemFk)
                    .HasColumnName("universal_item_fk")
                    .HasComment("Foreign key to associated universal item.");

                entity.HasOne(d => d.ProductFkNavigation)
                    .WithMany(p => p.UniversalItemSource)
                    .HasForeignKey(d => d.ProductFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_universal_item_source");

                entity.HasOne(d => d.UniversalItemFkNavigation)
                    .WithMany(p => p.UniversalItemSource)
                    .HasForeignKey(d => d.UniversalItemFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_universal_item_source_universal_item");
            });

            modelBuilder.Entity<UniversalVirtueGrade>(entity =>
            {
                entity.HasKey(e => e.UniversalLoyaltyGradeId)
                    .HasName("pk_universal_loyalty_grade_universal_loyalty_grade_id");

                entity.ToTable("universal_virtue_grade");

                entity.HasComment("A set of retail customer grades or ranking that they are classified into due to their different balances of points in one or another of the virtues.");

                entity.HasIndex(e => new { e.VirtueFk, e.GradeName })
                    .HasName("ux_universal_virtue_grade")
                    .IsUnique();

                entity.Property(e => e.UniversalLoyaltyGradeId)
                    .HasColumnName("universal_loyalty_grade_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.GradeName)
                    .HasColumnName("grade_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Human readable text name of grade - like bronze.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.PointThreshold)
                    .HasColumnName("point_threshold")
                    .HasComment("The number of points it takes to be in the loyalty_grade.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.VirtueFk)
                    .HasColumnName("virtue_fk")
                    .HasComment("Foreign key to the parent virtue such as loyalty.");

                entity.HasOne(d => d.VirtueFkNavigation)
                    .WithMany(p => p.UniversalVirtueGrade)
                    .HasForeignKey(d => d.VirtueFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_universal_virtue_grade_virtue");
            });

            modelBuilder.Entity<VendorProgram>(entity =>
            {
                entity.ToTable("vendor_program");

                entity.HasComment("The platform facilitates the mobile business in securing a broad set of business to business services. In some cases the services are of a complex nature and require a level of sophsitication that the mobile business owner may lack such as aquiring the right specialized kinds of business liability insurance. In other case it could be items such as HVAC service.");

                entity.HasIndex(e => e.ServiceCategory)
                    .HasName("ux_vendor_program")
                    .IsUnique();

                entity.Property(e => e.VendorProgramId)
                    .HasColumnName("vendor_program_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ServiceCategory)
                    .HasColumnName("service_category")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("Human readable name of service catrgory such as busines insurnace or inventory financing.");
            });

            modelBuilder.Entity<VendorProgramContractTemplate>(entity =>
            {
                entity.ToTable("vendor_program_contract_template");

                entity.HasComment("A boiler plate contract to be entered into by a vendor program service provider and mobile business as appropriate; that is, as they choose.");

                entity.HasIndex(e => new { e.VendorProgramFk, e.StandardContractName, e.ContractVersionNumber })
                    .HasName("ux_vendor_program_contract_template")
                    .IsUnique();

                entity.Property(e => e.VendorProgramContractTemplateId)
                    .HasColumnName("vendor_program_contract_template_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.ContractTemplate)
                    .HasColumnName("contract_template")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Boilder plate contract.");

                entity.Property(e => e.ContractVersionNumber)
                    .HasColumnName("contract_version_number")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("A version number to allow boiler templates to evolve.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.StandardContractName)
                    .HasColumnName("standard_contract_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Human readable name of the boiler plate contract so that a human knows when to use it.");

                entity.Property(e => e.VendorProgramFk)
                    .HasColumnName("vendor_program_fk")
                    .HasComment("Foreign key to the associated vendor program.");

                entity.HasOne(d => d.VendorProgramFkNavigation)
                    .WithMany(p => p.VendorProgramContractTemplate)
                    .HasForeignKey(d => d.VendorProgramFk)
                    .HasConstraintName("fk_vendor_contract_template_vendor_program");
            });

            modelBuilder.Entity<VendorProgramExecutedContract>(entity =>
            {
                entity.ToTable("vendor_program_executed_contract");

                entity.HasComment("A contract entered into by a platform mobile business and vendor program service provider (who could also be a platform mobile business) -- all filled out, signed and dated.");

                entity.HasIndex(e => new { e.VendorProgramContractTemplateFk, e.VendorProgramServiceProviderFk, e.VendorProgramServiceRecipientFk, e.ContractExecutionDate })
                    .HasName("ux_vendor_program_executed_contract")
                    .IsUnique();

                entity.Property(e => e.VendorProgramExecutedContractId)
                    .HasColumnName("vendor_program_executed_contract_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.ContractExecutionDate)
                    .HasColumnName("contract_execution_date")
                    .HasColumnType("date")
                    .HasComment("The date the contract was entered into by the two parties.");

                entity.Property(e => e.ExecutedContract)
                    .HasColumnName("executed_contract")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("The signed contract.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.VendorProgramContractTemplateFk)
                    .HasColumnName("vendor_program_contract_template_fk")
                    .HasComment("A foreign key to the contract boiler plate that served to drive the creation of the attached executed contract.");

                entity.Property(e => e.VendorProgramServiceProviderFk)
                    .HasColumnName("vendor_program_service_provider_fk")
                    .HasComment("Foreign key to associated vendor program service provider; the party providing the goods and or services.");

                entity.Property(e => e.VendorProgramServiceRecipientFk)
                    .HasColumnName("vendor_program_service_recipient_fk")
                    .HasComment("Foreign key to the mobile business who is receiving the vendor service.");

                entity.HasOne(d => d.VendorProgramContractTemplateFkNavigation)
                    .WithMany(p => p.VendorProgramExecutedContract)
                    .HasForeignKey(d => d.VendorProgramContractTemplateFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_vendor_program_executed_contract_contract_boiler_plate");

                entity.HasOne(d => d.VendorProgramServiceProviderFkNavigation)
                    .WithMany(p => p.VendorProgramExecutedContract)
                    .HasForeignKey(d => d.VendorProgramServiceProviderFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_vendor_program_executed_contract_service_provider");

                entity.HasOne(d => d.VendorProgramServiceRecipientFkNavigation)
                    .WithMany(p => p.VendorProgramExecutedContract)
                    .HasForeignKey(d => d.VendorProgramServiceRecipientFk)
                    .HasConstraintName("fk_vendor_program_executed_contract_recipient");
            });

            modelBuilder.Entity<VendorProgramServiceFeedback>(entity =>
            {
                entity.ToTable("vendor_program_service_feedback");

                entity.HasComment("For a given contract, a record of the service recipient feedback to drive vendor reputation.");

                entity.HasIndex(e => e.VendorProgramExecutedContractFk)
                    .HasName("ux_vendor_program_service_feedback")
                    .IsUnique();

                entity.Property(e => e.VendorProgramServiceFeedbackId)
                    .HasColumnName("vendor_program_service_feedback_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.Rating)
                    .HasColumnName("rating")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("A rating of 1 to 5 an contract execution / service.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TextFeedback)
                    .HasColumnName("text_feedback")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Free form text feedback to be, in due time, mined for sentiment.");

                entity.Property(e => e.VendorProgramExecutedContractFk)
                    .HasColumnName("vendor_program_executed _contract_fk")
                    .HasComment("Foreign key to parent executed contract.");

                entity.HasOne(d => d.VendorProgramExecutedContractFkNavigation)
                    .WithOne(p => p.VendorProgramServiceFeedback)
                    .HasForeignKey<VendorProgramServiceFeedback>(d => d.VendorProgramExecutedContractFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_vendor_program_service_feedback_executed_contract");
            });

            modelBuilder.Entity<VendorProgramServiceProvider>(entity =>
            {
                entity.ToTable("vendor_program_service_provider");

                entity.HasComment("Each record is a service provider for vendor service for one or another vendor programs. NOTE: these service providers can be third party service providers or actual platform participants.");

                entity.HasIndex(e => new { e.VendorProgramFk, e.OrganizationFk, e.DateStarted })
                    .HasName("ux_vendor_program_service_provider");

                entity.Property(e => e.VendorProgramServiceProviderId)
                    .HasColumnName("vendor_program_service_provider_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.AverageRating)
                    .HasColumnName("average_rating")
                    .HasColumnType("decimal(3, 2)")
                    .HasComment("The sum of the executed contract rating divided by the number of executed contracts - that got rated.");

                entity.Property(e => e.DateStarted)
                    .HasColumnName("date_started")
                    .HasColumnType("date")
                    .HasComment("Date the service provider began offering service under the given vendor program.");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("date")
                    .HasComment("The date the vendor stopped participation in the vendor program. NOTE: this field can obviously be null since the a vendor can be a current participant in a given vendor program.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.OrganizationFk)
                    .HasColumnName("organization_fk")
                    .HasComment("Foreign key to vendor program service provider such as a thrid_party_service_provider or a platform mobile business.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Reputation)
                    .HasColumnName("reputation")
                    .HasColumnType("decimal(3, 2)")
                    .HasComment("A service score calculated from rating, feedback, number of executed contracts and time in place providing the service.");

                entity.Property(e => e.VendorProgramFk)
                    .HasColumnName("vendor_program_fk")
                    .HasComment("Foreign key to parent vendor program.");

                entity.HasOne(d => d.VendorProgramFkNavigation)
                    .WithMany(p => p.VendorProgramServiceProvider)
                    .HasForeignKey(d => d.VendorProgramFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_vendor_program_service_provider_vendor_program");
            });

            modelBuilder.Entity<Virtue>(entity =>
            {
                entity.ToTable("virtue");

                entity.HasComment("A list of qualities a mobile business, retail customer or employee can have that makes continued work with them desirable or not so much. The prefined set is [credibility, loyalty, risk, trust and profitability. NOTE: it might be thought that this table could exist only in level 2 of the data lake and the magic DB - but since mobile bsuinesses get to rank virtues for purposes of grading employees then the virtues themselves are legitimate here.");

                entity.HasIndex(e => e.TextName)
                    .HasName("ux_virtue")
                    .IsUnique();

                entity.Property(e => e.VirtueId)
                    .HasColumnName("virtue_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.PlatformEmployeeRanking)
                    .HasColumnName("platform_employee_ranking")
                    .HasComment("Ranking given to the given virtue as among all the virtue by ecnoic for purposes of evaluating platform employees.");

                entity.Property(e => e.PlatformEmployeeWeight)
                    .HasColumnName("platform_employee_weight")
                    .HasColumnType("decimal(5, 4)")
                    .HasComment("Weight given to the given virtue as among all the virtue by ecnoic for purposes of evaluating platform employees.");

                entity.Property(e => e.PlatformMobileBusinessRanking)
                    .HasColumnName("platform_mobile_business_ranking")
                    .HasComment("Ranking given to the given virtue as among all the virtue by ecnoic for purposes of evaluating platform member mobile businesses.");

                entity.Property(e => e.PlatformMobileBusinessWeight)
                    .HasColumnName("platform_mobile_business_weight")
                    .HasColumnType("decimal(5, 4)")
                    .HasComment("Weight given to the given virtue as among all the virtue by ecnoic for purposes of evaluating platform mobile businesses.");

                entity.Property(e => e.PlatformRetailCustomerRanking)
                    .HasColumnName("platform_retail_customer_ranking")
                    .HasComment("Ranking given to the given virtue as among all the virtue by ecnoic for purposes of evaluating platform retail customers.");

                entity.Property(e => e.PlatformRetailCustomerWeight)
                    .HasColumnName("platform_retail_customer_weight")
                    .HasColumnType("decimal(5, 4)")
                    .HasComment("Weight given to the given virtue as among all the virtue by ecnoic for purposes of evaluating platform retail customers.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TextName)
                    .IsRequired()
                    .HasColumnName("text_name")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("Human readable text fname for virtue.");
            });

            modelBuilder.Entity<VwCartDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_cart_detail");

                entity.Property(e => e.CartId).HasColumnName("cart_id");

                entity.Property(e => e.MobileBusinessId).HasColumnName("mobile_business_id");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ProductDescription)
                    .HasColumnName("product_description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductPrice)
                    .HasColumnName("product_price")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.RetailCusotmerId).HasColumnName("retail_cusotmer_id");

                entity.Property(e => e.StartTimestamp)
                    .HasColumnName("start_timestamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.TrustedTradePromptId).HasColumnName("trusted_trade_prompt_id");
            });

            modelBuilder.Entity<VwGoods>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_goods", "dbo");

                entity.Property(e => e.CommissionAmount)
                    .HasColumnName("commission_amount")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CommissionRatio)
                    .HasColumnName("commission_ratio")
                    .HasColumnType("decimal(5, 4)");

                entity.Property(e => e.DefaultPurchaseMode)
                    .HasColumnName("default_purchase_mode")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dislikes).HasColumnName("dislikes");

                entity.Property(e => e.Likes).HasColumnName("likes");

                entity.Property(e => e.LoyaltyPointsToAccrue).HasColumnName("loyalty_points_to_accrue");

                entity.Property(e => e.MaximumPrice)
                    .HasColumnName("maximum_price")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.MinimumPrice)
                    .HasColumnName("minimum_price")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.MobileBusinessFk).HasColumnName("mobile_business_fk");

                entity.Property(e => e.OkForDeliveryFlag)
                    .IsRequired()
                    .HasColumnName("ok_for_delivery_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OkForPickupFlag)
                    .IsRequired()
                    .HasColumnName("ok_for_pickup_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OkForShipFlag)
                    .IsRequired()
                    .HasColumnName("ok_for_ship_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PhysicalOrVirtualIndicator)
                    .IsRequired()
                    .HasColumnName("physical_or_virtual_indicator")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlatformGetsAllInventoryFlag)
                    .IsRequired()
                    .HasColumnName("platform_gets_all_inventory_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QuantityAvailable).HasColumnName("quantity_available");

                entity.Property(e => e.QuantityOnHand).HasColumnName("quantity_on_hand");

                entity.Property(e => e.ServiceLifeExactOrCategoryFlag).HasColumnName("service_life_exact_or_category_flag");

                entity.Property(e => e.ServiceLifeInDays).HasColumnName("service_life_in_days");

                entity.Property(e => e.TaxItemTypeFk).HasColumnName("tax_item_type_fk");

                entity.Property(e => e.TextDescription)
                    .HasColumnName("text_description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UnitOfMeasure)
                    .HasColumnName("unit_of_measure")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VisableFlag)
                    .HasColumnName("visable_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwGoods1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_goods");

                entity.Property(e => e.CommissionAmount)
                    .HasColumnName("commission_amount")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CommissionRatio)
                    .HasColumnName("commission_ratio")
                    .HasColumnType("decimal(5, 4)");

                entity.Property(e => e.DefaultPurchaseMode)
                    .HasColumnName("default_purchase_mode")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dislikes).HasColumnName("dislikes");

                entity.Property(e => e.Likes).HasColumnName("likes");

                entity.Property(e => e.LoyaltyPointsToAccrue).HasColumnName("loyalty_points_to_accrue");

                entity.Property(e => e.MaximumPrice)
                    .HasColumnName("maximum_price")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.MinimumPrice)
                    .HasColumnName("minimum_price")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.MobileBusinessFk).HasColumnName("mobile_business_fk");

                entity.Property(e => e.OkForDeliveryFlag)
                    .IsRequired()
                    .HasColumnName("ok_for_delivery_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OkForPickupFlag)
                    .IsRequired()
                    .HasColumnName("ok_for_pickup_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OkForShipFlag)
                    .IsRequired()
                    .HasColumnName("ok_for_ship_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PhysicalOrVirtualIndicator)
                    .IsRequired()
                    .HasColumnName("physical_or_virtual_indicator")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlatformGetsAllInventoryFlag)
                    .IsRequired()
                    .HasColumnName("platform_gets_all_inventory_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QuantityAvailable).HasColumnName("quantity_available");

                entity.Property(e => e.QuantityOnHand).HasColumnName("quantity_on_hand");

                entity.Property(e => e.ServiceLifeExactOrCategoryFlag).HasColumnName("service_life_exact_or_category_flag");

                entity.Property(e => e.ServiceLifeInDays).HasColumnName("service_life_in_days");

                entity.Property(e => e.TaxItemTypeFk).HasColumnName("tax_item_type_fk");

                entity.Property(e => e.TextDescription)
                    .HasColumnName("text_description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UnitOfMeasure)
                    .HasColumnName("unit_of_measure")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VisableFlag)
                    .HasColumnName("visable_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwMobileBusiness>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_mobile_business");

                entity.Property(e => e.AcceptsAchFlag)
                    .IsRequired()
                    .HasColumnName("accepts_ach_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AcceptsCreditCardFlag)
                    .IsRequired()
                    .HasColumnName("accepts_credit_card_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HeadquartersAddressLine1)
                    .HasColumnName("headquarters_address_line_1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeadquartersAddressLine2)
                    .HasColumnName("headquarters_address_line_2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeadquartersAddressLine3)
                    .HasColumnName("headquarters_address_line_3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeadquartersCity)
                    .HasColumnName("headquarters_city")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeadquartersStatePostalCode)
                    .HasColumnName("headquarters_state_postal_code")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HeadquartersZipCode)
                    .HasColumnName("headquarters_zip_code")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MobileBusinessId).HasColumnName("mobile_business_id");

                entity.Property(e => e.MonthlyVolumeBracketFk).HasColumnName("monthly_volume_bracket_fk");

                entity.Property(e => e.OffersAssetsFlag)
                    .IsRequired()
                    .HasColumnName("offers_assets_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OffersGoodsFlag)
                    .IsRequired()
                    .HasColumnName("offers_goods_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OffersServicesFlag)
                    .IsRequired()
                    .HasColumnName("offers_services_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrganizationName)
                    .HasColumnName("organization_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerTitle)
                    .IsRequired()
                    .HasColumnName("owner_title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SelectedColorFk).HasColumnName("selected_color_fk");

                entity.Property(e => e.SelectedThemeFk).HasColumnName("selected_theme_fk");

                entity.Property(e => e.ShipsGoodsFlag)
                    .IsRequired()
                    .HasColumnName("ships_goods_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwMobileBusinessEmpoloyee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_mobile_business_empoloyee");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("full_name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IncomeStructureIndicator)
                    .HasColumnName("income_structure_indicator")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MobileBusinessEmployeeId).HasColumnName("mobile_business_employee_id");

                entity.Property(e => e.MobileBusinessId).HasColumnName("mobile_business_id");
            });

            modelBuilder.Entity<VwMobileBusinessOfferingCategories>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_mobile_business_offering_categories");

                entity.Property(e => e.BusinessCategoryId).HasColumnName("business_category_id");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("category_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MobileBusinessId).HasColumnName("mobile_business_id");

                entity.Property(e => e.OfferMode)
                    .IsRequired()
                    .HasColumnName("offer_mode")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrganizationName)
                    .HasColumnName("organization_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwServiceSlots>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_service_slots");

                entity.Property(e => e.AppointmentEndTime).HasColumnName("appointment_end_time");

                entity.Property(e => e.AppointmentStartTime).HasColumnName("appointment_start_time");

                entity.Property(e => e.MobileBusinessEmployeeId).HasColumnName("mobile_business_employee_id");

                entity.Property(e => e.ProfessionalServiceId).HasColumnName("professional_service_id");

                entity.Property(e => e.ScheduleDate)
                    .HasColumnName("schedule_date")
                    .HasColumnType("date");

                entity.Property(e => e.TextDescription)
                    .HasColumnName("text_description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TimeSlotIndex).HasColumnName("time_slot_index");
            });

            modelBuilder.Entity<VwServices>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_services", "dbo");

                entity.Property(e => e.CommissionAmount)
                    .HasColumnName("commission_amount")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CommissionRatio)
                    .HasColumnName("commission_ratio")
                    .HasColumnType("decimal(5, 4)");

                entity.Property(e => e.DefaultPurchaseMode)
                    .HasColumnName("default_purchase_mode")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dislikes).HasColumnName("dislikes");

                entity.Property(e => e.ExpectedDurationInMinutes).HasColumnName("expected_duration_in_minutes");

                entity.Property(e => e.Likes).HasColumnName("likes");

                entity.Property(e => e.LoyaltyPointsToAccrue).HasColumnName("loyalty_points_to_accrue");

                entity.Property(e => e.MaximumPrice)
                    .HasColumnName("maximum_price")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.MinimumPrice)
                    .HasColumnName("minimum_price")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.MobileBusinessFk).HasColumnName("mobile_business_fk");

                entity.Property(e => e.OkForDeliveryFlag)
                    .IsRequired()
                    .HasColumnName("ok_for_delivery_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OkForPickupFlag)
                    .IsRequired()
                    .HasColumnName("ok_for_pickup_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OkForShipFlag)
                    .IsRequired()
                    .HasColumnName("ok_for_ship_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PhysicalOrVirtualIndicator)
                    .IsRequired()
                    .HasColumnName("physical_or_virtual_indicator")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ServiceLifeExactOrCategoryFlag).HasColumnName("service_life_exact_or_category_flag");

                entity.Property(e => e.ServiceLifeInDays).HasColumnName("service_life_in_days");

                entity.Property(e => e.ServiceType)
                    .IsRequired()
                    .HasColumnName("service_type")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TaxItemTypeFk).HasColumnName("tax_item_type_fk");

                entity.Property(e => e.TextDescription)
                    .HasColumnName("text_description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UnitOfMeasure)
                    .HasColumnName("unit_of_measure")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VisableFlag)
                    .HasColumnName("visable_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwServices1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_services");

                entity.Property(e => e.CommissionAmount)
                    .HasColumnName("commission_amount")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CommissionRatio)
                    .HasColumnName("commission_ratio")
                    .HasColumnType("decimal(5, 4)");

                entity.Property(e => e.DefaultPurchaseMode)
                    .HasColumnName("default_purchase_mode")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dislikes).HasColumnName("dislikes");

                entity.Property(e => e.ExpectedDurationInMinutes).HasColumnName("expected_duration_in_minutes");

                entity.Property(e => e.Likes).HasColumnName("likes");

                entity.Property(e => e.LoyaltyPointsToAccrue).HasColumnName("loyalty_points_to_accrue");

                entity.Property(e => e.MaximumPrice)
                    .HasColumnName("maximum_price")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.MinimumPrice)
                    .HasColumnName("minimum_price")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.MobileBusinessFk).HasColumnName("mobile_business_fk");

                entity.Property(e => e.OkForDeliveryFlag)
                    .IsRequired()
                    .HasColumnName("ok_for_delivery_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OkForPickupFlag)
                    .IsRequired()
                    .HasColumnName("ok_for_pickup_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OkForShipFlag)
                    .IsRequired()
                    .HasColumnName("ok_for_ship_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PhysicalOrVirtualIndicator)
                    .IsRequired()
                    .HasColumnName("physical_or_virtual_indicator")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ServiceLifeExactOrCategoryFlag).HasColumnName("service_life_exact_or_category_flag");

                entity.Property(e => e.ServiceLifeInDays).HasColumnName("service_life_in_days");

                entity.Property(e => e.ServiceType)
                    .IsRequired()
                    .HasColumnName("service_type")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TaxItemTypeFk).HasColumnName("tax_item_type_fk");

                entity.Property(e => e.TextDescription)
                    .HasColumnName("text_description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UnitOfMeasure)
                    .HasColumnName("unit_of_measure")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VisableFlag)
                    .HasColumnName("visable_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwUserDevice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_user_device");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("full_name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phone_number")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.SmartphoneDeviceType)
                    .HasColumnName("smartphone_device_type")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.SmartphoneManufacturer)
                    .HasColumnName("smartphone_manufacturer")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.SmartphoneModel)
                    .HasColumnName("smartphone_model")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.SmartphoneModelNumber)
                    .HasColumnName("smartphone_model_number")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SmartphoneOs)
                    .HasColumnName("smartphone_os")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.SmartphoneOsVersion)
                    .HasColumnName("smartphone_os_version")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SmartphoneSerialNumber)
                    .HasColumnName("smartphone_serial_number")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.TabletDeviceType)
                    .HasColumnName("tablet_device_type")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.TabletManufacturer)
                    .HasColumnName("tablet_manufacturer")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.TabletModel)
                    .HasColumnName("tablet_model")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.TabletModelNumber)
                    .HasColumnName("tablet_model_number")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TabletOs)
                    .HasColumnName("tablet_os")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.TabletOsVersion)
                    .HasColumnName("tablet_os_version")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TabletSerialNumber)
                    .HasColumnName("tablet_serial_number")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WeeklySchedule>(entity =>
            {
                entity.ToTable("weekly_schedule");

                entity.HasComment("A inheritance hierarchy parent class to hold instances of weekly schedules for things like hours of operation or availability.");

                entity.Property(e => e.WeeklyScheduleId)
                    .HasColumnName("weekly_schedule_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.FridayBegin)
                    .HasColumnName("friday_begin")
                    .HasComment("The time of day (minutes after mid-night Greenwich time) the the business retail locations opens on Fridays.");

                entity.Property(e => e.FridayEnd)
                    .HasColumnName("friday_end")
                    .HasComment("The time of day (minutes after mid-night Greenwich time) the the business retail locations closes on Fridays.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MondayBegin)
                    .HasColumnName("monday_begin")
                    .HasComment("The time of day (minutes after mid-night Greenwich time) the the business retail locations opens on Mondays.");

                entity.Property(e => e.MondayEnd)
                    .HasColumnName("monday_end")
                    .HasComment("The time of day (minutes after mid-night Greenwich time) the the business retail locations closes on Mondays.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SaturdayBegin)
                    .HasColumnName("saturday_begin")
                    .HasComment("The time of day (minutes after mid-night Greenwich time) the the business retail locations opens on Saturdays.");

                entity.Property(e => e.SaturdayEnd)
                    .HasColumnName("saturday_end")
                    .HasComment("The time of day (minutes after mid-night Greenwich time) the the business retail locations closes on Saturdays.");

                entity.Property(e => e.SundayBegin)
                    .HasColumnName("sunday_begin")
                    .HasComment("The time of day (minutes after mid-night Greenwich time) the the business retail location opens on Sundays.");

                entity.Property(e => e.SundayEnd)
                    .HasColumnName("sunday_end")
                    .HasComment("The time of day minutes after mid-night Greenwich time) the the business retail locations closes on Sundays.");

                entity.Property(e => e.ThursdayBegin)
                    .HasColumnName("thursday_begin")
                    .HasComment("The time of day (minutes after mid-night Greenwich time) the the business retail locations opens on Thursdays.");

                entity.Property(e => e.ThursdayEnd)
                    .HasColumnName("thursday_end")
                    .HasComment("The time of day (minutes after mid-night Greenwich time) the the business retail locations closes on Thursdays.");

                entity.Property(e => e.TuesdayBegin)
                    .HasColumnName("tuesday_begin")
                    .HasComment("The time of day (minutes after mid-night Greenwich time) the the business retail locations opens on Tuesdays.");

                entity.Property(e => e.TuesdayEnd)
                    .HasColumnName("tuesday_end")
                    .HasComment("The time of day (minutes after mid-night Greenwich time) the the business retail locations closes on Tuesdays.");

                entity.Property(e => e.Uuid)
                    .IsRequired()
                    .HasColumnName("uuid")
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WednesdayBegin)
                    .HasColumnName("wednesday_begin")
                    .HasComment("The time of day (minutes after mid-night Greenwich time) the the business retail locations opens on Wednesdays.");

                entity.Property(e => e.WednesdayEnd)
                    .HasColumnName("wednesday_end")
                    .HasComment("The time of day (minutes after mid-night Greenwich time) the the business retail locations closes on Wednesdays.");
            });

            modelBuilder.Entity<Wishlist>(entity =>
            {
                entity.ToTable("wishlist");

                entity.HasComment("A list of products and services desired by a retail customer not yet purchased. A retail customer adds items to their wish list and can exlicitly remove or implicitly remove them by purchases those items.");

                entity.HasIndex(e => new { e.RetailCustomerFk, e.ProductFk, e.ExlicitImplicitIndicator, e.DateAdded })
                    .HasName("ux_wishlist");

                entity.Property(e => e.WishlistId)
                    .HasColumnName("wishlist_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.ActiveFlag)
                    .HasColumnName("active_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("'Y' - means yes and 'N' means no. A wish list item becomes inactive if the retail customer does, in due time, acquire the item or if the explicitly remove the item from their wish list.");

                entity.Property(e => e.DateAdded)
                    .HasColumnName("date_added")
                    .HasColumnType("date")
                    .HasComment("The date the wished for product was added to the wish list, or in the case of the implicit entries the date the retail customer abandoned the cart.");

                entity.Property(e => e.ExlicitImplicitIndicator)
                    .HasColumnName("exlicit_implicit_indicator")
                    .HasComment("'E' means explicit - the retail customer added the item to the  wish list. 'I' means implicit - the retail customer left the item sitting in their cart and abandoned the cart.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.ProductFk)
                    .HasColumnName("product_fk")
                    .HasComment("Foreign key to desired product. NOTE: this field can be null since the retail customer may desire a bundle.");

                entity.Property(e => e.QuantityDesired)
                    .HasColumnName("quantity_desired")
                    .HasComment("Number of items that the retail customer is interested in buying.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RetailCustomerFk)
                    .HasColumnName("retail_customer_fk")
                    .HasComment("Foreign key to wishful retail customer.");

                entity.HasOne(d => d.ProductFkNavigation)
                    .WithMany(p => p.Wishlist)
                    .HasForeignKey(d => d.ProductFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_wishlist_product");

                entity.HasOne(d => d.RetailCustomerFkNavigation)
                    .WithMany(p => p.Wishlist)
                    .HasForeignKey(d => d.RetailCustomerFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_wishlist_retail_customer");
            });

            modelBuilder.Entity<WorkBreakCategory>(entity =>
            {
                entity.ToTable("work_break_category");

                entity.HasComment("The kinds of breaks that get scheduled, such as lunch and morning breaks.");

                entity.HasIndex(e => e.CategoryName)
                    .HasName("ux_work_break_category_work_break_category_id")
                    .IsUnique();

                entity.Property(e => e.WorkBreakCategoryId)
                    .HasColumnName("work_break_category_id")
                    .HasComment("System generated surrogate primary key.");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("category_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Human readable text name of break category such as - lunch.");

                entity.Property(e => e.LastUpdateTimestamp)
                    .HasColumnName("last_update_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The last time any attribute of this record was updated / the timestampt when the record was inserted. NOTE: timestamps are alwayd expressed in terms of Greenich standard time.");

                entity.Property(e => e.RecordVersion)
                    .IsRequired()
                    .HasColumnName("record_version")
                    .HasComment("A support for 100% optimisitic locking. Incremented on each record update.")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
