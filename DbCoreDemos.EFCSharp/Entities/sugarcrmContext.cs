using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFCoreDemos.EFCSharp.Entities
{
    public partial class SugarcrmContext : DbContext
    {
        public SugarcrmContext()
        {
        }

        public SugarcrmContext(DbContextOptions<SugarcrmContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<AccountsAudit> AccountsAudit { get; set; }
        public virtual DbSet<AccountsBugs> AccountsBugs { get; set; }
        public virtual DbSet<AccountsCases> AccountsCases { get; set; }
        public virtual DbSet<AccountsContacts> AccountsContacts { get; set; }
        public virtual DbSet<AccountsOpportunities> AccountsOpportunities { get; set; }
        public virtual DbSet<AclActions> AclActions { get; set; }
        public virtual DbSet<AclRoles> AclRoles { get; set; }
        public virtual DbSet<AclRolesActions> AclRolesActions { get; set; }
        public virtual DbSet<AclRolesUsers> AclRolesUsers { get; set; }
        public virtual DbSet<Bugs> Bugs { get; set; }
        public virtual DbSet<BugsAudit> BugsAudit { get; set; }
        public virtual DbSet<Calls> Calls { get; set; }
        public virtual DbSet<CallsContacts> CallsContacts { get; set; }
        public virtual DbSet<CallsLeads> CallsLeads { get; set; }
        public virtual DbSet<CallsUsers> CallsUsers { get; set; }
        public virtual DbSet<CampaignLog> CampaignLog { get; set; }
        public virtual DbSet<Campaigns> Campaigns { get; set; }
        public virtual DbSet<CampaignsAudit> CampaignsAudit { get; set; }
        public virtual DbSet<CampaignTrkrs> CampaignTrkrs { get; set; }
        public virtual DbSet<Cases> Cases { get; set; }
        public virtual DbSet<CasesAudit> CasesAudit { get; set; }
        public virtual DbSet<CasesBugs> CasesBugs { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<ContactsAudit> ContactsAudit { get; set; }
        public virtual DbSet<ContactsBugs> ContactsBugs { get; set; }
        public virtual DbSet<ContactsCases> ContactsCases { get; set; }
        public virtual DbSet<ContactsUsers> ContactsUsers { get; set; }
        public virtual DbSet<CronRemoveDocuments> CronRemoveDocuments { get; set; }
        public virtual DbSet<Currencies> Currencies { get; set; }
        public virtual DbSet<DocumentRevisions> DocumentRevisions { get; set; }
        public virtual DbSet<Documents> Documents { get; set; }
        public virtual DbSet<DocumentsAccounts> DocumentsAccounts { get; set; }
        public virtual DbSet<DocumentsBugs> DocumentsBugs { get; set; }
        public virtual DbSet<DocumentsCases> DocumentsCases { get; set; }
        public virtual DbSet<DocumentsContacts> DocumentsContacts { get; set; }
        public virtual DbSet<DocumentsOpportunities> DocumentsOpportunities { get; set; }
        public virtual DbSet<Eapm> Eapm { get; set; }
        public virtual DbSet<EmailAddrBeanRel> EmailAddrBeanRel { get; set; }
        public virtual DbSet<EmailAddresses> EmailAddresses { get; set; }
        public virtual DbSet<Emailman> Emailman { get; set; }
        public virtual DbSet<EmailMarketing> EmailMarketing { get; set; }
        public virtual DbSet<EmailMarketingProspectLists> EmailMarketingProspectLists { get; set; }
        public virtual DbSet<Emails> Emails { get; set; }
        public virtual DbSet<EmailsBeans> EmailsBeans { get; set; }
        public virtual DbSet<EmailsEmailAddrRel> EmailsEmailAddrRel { get; set; }
        public virtual DbSet<EmailsText> EmailsText { get; set; }
        public virtual DbSet<EmailTemplates> EmailTemplates { get; set; }
        public virtual DbSet<FieldsMetaData> FieldsMetaData { get; set; }
        public virtual DbSet<Folders> Folders { get; set; }
        public virtual DbSet<FoldersRel> FoldersRel { get; set; }
        public virtual DbSet<FoldersSubscriptions> FoldersSubscriptions { get; set; }
        public virtual DbSet<ImportMaps> ImportMaps { get; set; }
        public virtual DbSet<InboundEmail> InboundEmail { get; set; }
        public virtual DbSet<InboundEmailAutoreply> InboundEmailAutoreply { get; set; }
        public virtual DbSet<InboundEmailCacheTs> InboundEmailCacheTs { get; set; }
        public virtual DbSet<JobQueue> JobQueue { get; set; }
        public virtual DbSet<Leads> Leads { get; set; }
        public virtual DbSet<LeadsAudit> LeadsAudit { get; set; }
        public virtual DbSet<LinkedDocuments> LinkedDocuments { get; set; }
        public virtual DbSet<Meetings> Meetings { get; set; }
        public virtual DbSet<MeetingsContacts> MeetingsContacts { get; set; }
        public virtual DbSet<MeetingsLeads> MeetingsLeads { get; set; }
        public virtual DbSet<MeetingsUsers> MeetingsUsers { get; set; }
        public virtual DbSet<Notes> Notes { get; set; }
        public virtual DbSet<OauthConsumer> OauthConsumer { get; set; }
        public virtual DbSet<OauthNonce> OauthNonce { get; set; }
        public virtual DbSet<OauthTokens> OauthTokens { get; set; }
        public virtual DbSet<Opportunities> Opportunities { get; set; }
        public virtual DbSet<OpportunitiesAudit> OpportunitiesAudit { get; set; }
        public virtual DbSet<OpportunitiesContacts> OpportunitiesContacts { get; set; }
        public virtual DbSet<OutboundEmail> OutboundEmail { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<ProjectsAccounts> ProjectsAccounts { get; set; }
        public virtual DbSet<ProjectsBugs> ProjectsBugs { get; set; }
        public virtual DbSet<ProjectsCases> ProjectsCases { get; set; }
        public virtual DbSet<ProjectsContacts> ProjectsContacts { get; set; }
        public virtual DbSet<ProjectsOpportunities> ProjectsOpportunities { get; set; }
        public virtual DbSet<ProjectsProducts> ProjectsProducts { get; set; }
        public virtual DbSet<ProjectTask> ProjectTask { get; set; }
        public virtual DbSet<ProjectTaskAudit> ProjectTaskAudit { get; set; }
        public virtual DbSet<ProspectListCampaigns> ProspectListCampaigns { get; set; }
        public virtual DbSet<ProspectLists> ProspectLists { get; set; }
        public virtual DbSet<ProspectListsProspects> ProspectListsProspects { get; set; }
        public virtual DbSet<Prospects> Prospects { get; set; }
        public virtual DbSet<Relationships> Relationships { get; set; }
        public virtual DbSet<Releases> Releases { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<RolesModules> RolesModules { get; set; }
        public virtual DbSet<RolesUsers> RolesUsers { get; set; }
        public virtual DbSet<SavedSearch> SavedSearch { get; set; }
        public virtual DbSet<Schedulers> Schedulers { get; set; }
        public virtual DbSet<Sugarfeed> Sugarfeed { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }
        public virtual DbSet<Tracker> Tracker { get; set; }
        public virtual DbSet<UpgradeHistory> UpgradeHistory { get; set; }
        public virtual DbSet<UserPreferences> UserPreferences { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersLastImport> UsersLastImport { get; set; }
        public virtual DbSet<UsersPasswordLink> UsersPasswordLink { get; set; }
        public virtual DbSet<UsersSignatures> UsersSignatures { get; set; }
        public virtual DbSet<Vcals> Vcals { get; set; }
        public virtual DbSet<Versions> Versions { get; set; }

        // Unable to generate entity type for table 'address_book'. Please see the warning messages.
        // Unable to generate entity type for table 'config'. Please see the warning messages.
        // Unable to generate entity type for table 'custom_fields'. Please see the warning messages.
        // Unable to generate entity type for table 'email_cache'. Please see the warning messages.
        // Unable to generate entity type for table 'users_feeds'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = Environment.GetEnvironmentVariable("ConnectionStrings:MysqlSugarCrm");
                optionsBuilder.UseMySql(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accounts>(entity =>
            {
                entity.ToTable("accounts");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_accnt_parent_id");

                entity.HasIndex(e => new { e.Deleted, e.AssignedUserId })
                    .HasName("idx_accnt_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_accnt_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_accnt_name_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.AnnualRevenue)
                    .HasColumnName("annual_revenue")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.BillingAddressCity)
                    .HasColumnName("billing_address_city")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.BillingAddressCountry)
                    .HasColumnName("billing_address_country")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.BillingAddressPostalcode)
                    .HasColumnName("billing_address_postalcode")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.BillingAddressState)
                    .HasColumnName("billing_address_state")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.BillingAddressStreet)
                    .HasColumnName("billing_address_street")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.Employees)
                    .HasColumnName("employees")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Industry)
                    .HasColumnName("industry")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Ownership)
                    .HasColumnName("ownership")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.PhoneAlternate)
                    .HasColumnName("phone_alternate")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PhoneFax)
                    .HasColumnName("phone_fax")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PhoneOffice)
                    .HasColumnName("phone_office")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Rating)
                    .HasColumnName("rating")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ShippingAddressCity)
                    .HasColumnName("shipping_address_city")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ShippingAddressCountry)
                    .HasColumnName("shipping_address_country")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingAddressPostalcode)
                    .HasColumnName("shipping_address_postalcode")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ShippingAddressState)
                    .HasColumnName("shipping_address_state")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ShippingAddressStreet)
                    .HasColumnName("shipping_address_street")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.SicCode)
                    .HasColumnName("sic_code")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.TickerSymbol)
                    .HasColumnName("ticker_symbol")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<AccountsAudit>(entity =>
            {
                entity.ToTable("accounts_audit");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_accounts_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.AfterValueText)
                    .HasColumnName("after_value_text")
                    .HasColumnType("text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.BeforeValueText)
                    .HasColumnName("before_value_text")
                    .HasColumnType("text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("char(36)");
            });

            modelBuilder.Entity<AccountsBugs>(entity =>
            {
                entity.ToTable("accounts_bugs");

                entity.HasIndex(e => e.AccountId)
                    .HasName("idx_acc_bug_acc");

                entity.HasIndex(e => e.BugId)
                    .HasName("idx_acc_bug_bug");

                entity.HasIndex(e => new { e.AccountId, e.BugId })
                    .HasName("idx_account_bug");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.BugId)
                    .HasColumnName("bug_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<AccountsCases>(entity =>
            {
                entity.ToTable("accounts_cases");

                entity.HasIndex(e => e.AccountId)
                    .HasName("idx_acc_case_acc");

                entity.HasIndex(e => e.CaseId)
                    .HasName("idx_acc_acc_case");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.CaseId)
                    .HasColumnName("case_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<AccountsContacts>(entity =>
            {
                entity.ToTable("accounts_contacts");

                entity.HasIndex(e => new { e.AccountId, e.ContactId })
                    .HasName("idx_account_contact");

                entity.HasIndex(e => new { e.ContactId, e.Deleted, e.AccountId })
                    .HasName("idx_contid_del_accid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<AccountsOpportunities>(entity =>
            {
                entity.ToTable("accounts_opportunities");

                entity.HasIndex(e => new { e.AccountId, e.OpportunityId })
                    .HasName("idx_account_opportunity");

                entity.HasIndex(e => new { e.OpportunityId, e.Deleted, e.AccountId })
                    .HasName("idx_oppid_del_accid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OpportunityId)
                    .HasColumnName("opportunity_id")
                    .HasColumnType("varchar(36)");
            });

            modelBuilder.Entity<AclActions>(entity =>
            {
                entity.ToTable("acl_actions");

                entity.HasIndex(e => new { e.Category, e.Name })
                    .HasName("idx_category_name");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_aclaction_id_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Aclaccess)
                    .HasColumnName("aclaccess")
                    .HasColumnType("int(3)");

                entity.Property(e => e.Acltype)
                    .HasColumnName("acltype")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(150)");
            });

            modelBuilder.Entity<AclRoles>(entity =>
            {
                entity.ToTable("acl_roles");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_aclrole_id_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(150)");
            });

            modelBuilder.Entity<AclRolesActions>(entity =>
            {
                entity.ToTable("acl_roles_actions");

                entity.HasIndex(e => e.ActionId)
                    .HasName("idx_acl_action_id");

                entity.HasIndex(e => e.RoleId)
                    .HasName("idx_acl_role_id");

                entity.HasIndex(e => new { e.RoleId, e.ActionId })
                    .HasName("idx_aclrole_action");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.AccessOverride)
                    .HasColumnName("access_override")
                    .HasColumnType("int(3)");

                entity.Property(e => e.ActionId)
                    .HasColumnName("action_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .HasColumnType("varchar(36)");
            });

            modelBuilder.Entity<AclRolesUsers>(entity =>
            {
                entity.ToTable("acl_roles_users");

                entity.HasIndex(e => e.RoleId)
                    .HasName("idx_aclrole_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("idx_acluser_id");

                entity.HasIndex(e => new { e.RoleId, e.UserId })
                    .HasName("idx_aclrole_user");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("varchar(36)");
            });

            modelBuilder.Entity<Bugs>(entity =>
            {
                entity.ToTable("bugs");

                entity.HasIndex(e => e.AssignedUserId)
                    .HasName("idx_bugs_assigned_user");

                entity.HasIndex(e => e.BugNumber)
                    .HasName("bug_number");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_bug_name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.BugNumber)
                    .HasColumnName("bug_number")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.FixedInRelease)
                    .HasColumnName("fixed_in_release")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.FoundInRelease)
                    .HasColumnName("found_in_release")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ProductCategory)
                    .HasColumnName("product_category")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Resolution)
                    .HasColumnName("resolution")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.WorkLog)
                    .HasColumnName("work_log")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<BugsAudit>(entity =>
            {
                entity.ToTable("bugs_audit");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_bugs_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.AfterValueText)
                    .HasColumnName("after_value_text")
                    .HasColumnType("text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.BeforeValueText)
                    .HasColumnName("before_value_text")
                    .HasColumnType("text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("char(36)");
            });

            modelBuilder.Entity<Calls>(entity =>
            {
                entity.ToTable("calls");

                entity.HasIndex(e => e.DateStart)
                    .HasName("idx_calls_date_start");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_call_name");

                entity.HasIndex(e => e.Status)
                    .HasName("idx_status");

                entity.HasIndex(e => new { e.Deleted, e.AssignedUserId })
                    .HasName("idx_calls_assigned_del");

                entity.HasIndex(e => new { e.ParentId, e.ParentType, e.Deleted })
                    .HasName("idx_calls_par_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEnd)
                    .HasColumnName("date_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateStart)
                    .HasColumnName("date_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.Direction)
                    .HasColumnName("direction")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.DurationHours)
                    .HasColumnName("duration_hours")
                    .HasColumnType("int(2)");

                entity.Property(e => e.DurationMinutes)
                    .HasColumnName("duration_minutes")
                    .HasColumnType("int(2)");

                entity.Property(e => e.EmailReminderSent)
                    .HasColumnName("email_reminder_sent")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EmailReminderTime)
                    .HasColumnName("email_reminder_time")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.OutlookId)
                    .HasColumnName("outlook_id")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.ParentType)
                    .HasColumnName("parent_type")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.RecurringSource)
                    .HasColumnName("recurring_source")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.ReminderTime)
                    .HasColumnName("reminder_time")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.RepeatCount)
                    .HasColumnName("repeat_count")
                    .HasColumnType("int(7)");

                entity.Property(e => e.RepeatDow)
                    .HasColumnName("repeat_dow")
                    .HasColumnType("varchar(7)");

                entity.Property(e => e.RepeatInterval)
                    .HasColumnName("repeat_interval")
                    .HasColumnType("int(3)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.RepeatParentId)
                    .HasColumnName("repeat_parent_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.RepeatType)
                    .HasColumnName("repeat_type")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.RepeatUntil)
                    .HasColumnName("repeat_until")
                    .HasColumnType("date");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'Planned'");
            });

            modelBuilder.Entity<CallsContacts>(entity =>
            {
                entity.ToTable("calls_contacts");

                entity.HasIndex(e => e.CallId)
                    .HasName("idx_con_call_call");

                entity.HasIndex(e => e.ContactId)
                    .HasName("idx_con_call_con");

                entity.HasIndex(e => new { e.CallId, e.ContactId })
                    .HasName("idx_call_contact");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.AcceptStatus)
                    .HasColumnName("accept_status")
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("'none'");

                entity.Property(e => e.CallId)
                    .HasColumnName("call_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Required)
                    .HasColumnName("required")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<CallsLeads>(entity =>
            {
                entity.ToTable("calls_leads");

                entity.HasIndex(e => e.CallId)
                    .HasName("idx_lead_call_call");

                entity.HasIndex(e => e.LeadId)
                    .HasName("idx_lead_call_lead");

                entity.HasIndex(e => new { e.CallId, e.LeadId })
                    .HasName("idx_call_lead");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.AcceptStatus)
                    .HasColumnName("accept_status")
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("'none'");

                entity.Property(e => e.CallId)
                    .HasColumnName("call_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LeadId)
                    .HasColumnName("lead_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.Required)
                    .HasColumnName("required")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<CallsUsers>(entity =>
            {
                entity.ToTable("calls_users");

                entity.HasIndex(e => e.CallId)
                    .HasName("idx_usr_call_call");

                entity.HasIndex(e => e.UserId)
                    .HasName("idx_usr_call_usr");

                entity.HasIndex(e => new { e.CallId, e.UserId })
                    .HasName("idx_call_users");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.AcceptStatus)
                    .HasColumnName("accept_status")
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("'none'");

                entity.Property(e => e.CallId)
                    .HasColumnName("call_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Required)
                    .HasColumnName("required")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("varchar(36)");
            });

            modelBuilder.Entity<CampaignLog>(entity =>
            {
                entity.ToTable("campaign_log");

                entity.HasIndex(e => e.CampaignId)
                    .HasName("idx_camp_campaign_id");

                entity.HasIndex(e => e.MoreInformation)
                    .HasName("idx_camp_more_info");

                entity.HasIndex(e => e.TargetId)
                    .HasName("idx_target_id");

                entity.HasIndex(e => e.TargetTrackerKey)
                    .HasName("idx_camp_tracker");

                entity.HasIndex(e => new { e.TargetId, e.Deleted })
                    .HasName("idx_target_id_deleted");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.ActivityDate)
                    .HasColumnName("activity_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ActivityType)
                    .HasColumnName("activity_type")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Archived)
                    .HasColumnName("archived")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Hits)
                    .HasColumnName("hits")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ListId)
                    .HasColumnName("list_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.MarketingId)
                    .HasColumnName("marketing_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.MoreInformation)
                    .HasColumnName("more_information")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.RelatedId)
                    .HasColumnName("related_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.RelatedType)
                    .HasColumnName("related_type")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.TargetId)
                    .HasColumnName("target_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.TargetTrackerKey)
                    .HasColumnName("target_tracker_key")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.TargetType)
                    .HasColumnName("target_type")
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<Campaigns>(entity =>
            {
                entity.ToTable("campaigns");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_campaign_name");

                entity.HasIndex(e => e.TrackerKey)
                    .HasName("camp_auto_tracker_key");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.ActualCost).HasColumnName("actual_cost");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Budget).HasColumnName("budget");

                entity.Property(e => e.CampaignType)
                    .HasColumnName("campaign_type")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("currency_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("date");

                entity.Property(e => e.ExpectedCost).HasColumnName("expected_cost");

                entity.Property(e => e.ExpectedRevenue).HasColumnName("expected_revenue");

                entity.Property(e => e.Frequency)
                    .HasColumnName("frequency")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Impressions)
                    .HasColumnName("impressions")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Objective)
                    .HasColumnName("objective")
                    .HasColumnType("text");

                entity.Property(e => e.ReferUrl)
                    .HasColumnName("refer_url")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'http://'");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("date");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.TrackerCount)
                    .HasColumnName("tracker_count")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TrackerKey)
                    .HasColumnName("tracker_key")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TrackerText)
                    .HasColumnName("tracker_text")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<CampaignsAudit>(entity =>
            {
                entity.ToTable("campaigns_audit");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_campaigns_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.AfterValueText)
                    .HasColumnName("after_value_text")
                    .HasColumnType("text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.BeforeValueText)
                    .HasColumnName("before_value_text")
                    .HasColumnType("text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("char(36)");
            });

            modelBuilder.Entity<CampaignTrkrs>(entity =>
            {
                entity.ToTable("campaign_trkrs");

                entity.HasIndex(e => e.TrackerKey)
                    .HasName("campaign_tracker_key_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsOptout)
                    .HasColumnName("is_optout")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.TrackerKey)
                    .HasColumnName("tracker_key")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TrackerName)
                    .HasColumnName("tracker_name")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.TrackerUrl)
                    .HasColumnName("tracker_url")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'http://'");
            });

            modelBuilder.Entity<Cases>(entity =>
            {
                entity.ToTable("cases");

                entity.HasIndex(e => e.AccountId)
                    .HasName("idx_account_id");

                entity.HasIndex(e => e.CaseNumber)
                    .HasName("case_number");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_case_name");

                entity.HasIndex(e => new { e.AssignedUserId, e.Status, e.Deleted })
                    .HasName("idx_cases_stat_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.CaseNumber)
                    .HasColumnName("case_number")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Resolution)
                    .HasColumnName("resolution")
                    .HasColumnType("text");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.WorkLog)
                    .HasColumnName("work_log")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<CasesAudit>(entity =>
            {
                entity.ToTable("cases_audit");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_cases_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.AfterValueText)
                    .HasColumnName("after_value_text")
                    .HasColumnType("text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.BeforeValueText)
                    .HasColumnName("before_value_text")
                    .HasColumnType("text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("char(36)");
            });

            modelBuilder.Entity<CasesBugs>(entity =>
            {
                entity.ToTable("cases_bugs");

                entity.HasIndex(e => e.BugId)
                    .HasName("idx_cas_bug_bug");

                entity.HasIndex(e => e.CaseId)
                    .HasName("idx_cas_bug_cas");

                entity.HasIndex(e => new { e.CaseId, e.BugId })
                    .HasName("idx_case_bug");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.BugId)
                    .HasColumnName("bug_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.CaseId)
                    .HasColumnName("case_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Contacts>(entity =>
            {
                entity.ToTable("contacts");

                entity.HasIndex(e => e.AssignedUserId)
                    .HasName("idx_cont_assigned");

                entity.HasIndex(e => e.ReportsToId)
                    .HasName("idx_reports_to_id");

                entity.HasIndex(e => new { e.Deleted, e.LastName })
                    .HasName("idx_contacts_del_last");

                entity.HasIndex(e => new { e.Deleted, e.Id, e.AssignedUserId })
                    .HasName("idx_del_id_user");

                entity.HasIndex(e => new { e.Deleted, e.ReportsToId, e.LastName })
                    .HasName("idx_cont_del_reports");

                entity.HasIndex(e => new { e.LastName, e.FirstName, e.Deleted })
                    .HasName("idx_cont_last_first");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AltAddressCity)
                    .HasColumnName("alt_address_city")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.AltAddressCountry)
                    .HasColumnName("alt_address_country")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.AltAddressPostalcode)
                    .HasColumnName("alt_address_postalcode")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.AltAddressState)
                    .HasColumnName("alt_address_state")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.AltAddressStreet)
                    .HasColumnName("alt_address_street")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Assistant)
                    .HasColumnName("assistant")
                    .HasColumnType("varchar(75)");

                entity.Property(e => e.AssistantPhone)
                    .HasColumnName("assistant_phone")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Birthdate)
                    .HasColumnName("birthdate")
                    .HasColumnType("date");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.DoNotCall)
                    .HasColumnName("do_not_call")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.LeadSource)
                    .HasColumnName("lead_source")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.PhoneFax)
                    .HasColumnName("phone_fax")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PhoneHome)
                    .HasColumnName("phone_home")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PhoneMobile)
                    .HasColumnName("phone_mobile")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PhoneOther)
                    .HasColumnName("phone_other")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PhoneWork)
                    .HasColumnName("phone_work")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PrimaryAddressCity)
                    .HasColumnName("primary_address_city")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PrimaryAddressCountry)
                    .HasColumnName("primary_address_country")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PrimaryAddressPostalcode)
                    .HasColumnName("primary_address_postalcode")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PrimaryAddressState)
                    .HasColumnName("primary_address_state")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PrimaryAddressStreet)
                    .HasColumnName("primary_address_street")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.ReportsToId)
                    .HasColumnName("reports_to_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Salutation)
                    .HasColumnName("salutation")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<ContactsAudit>(entity =>
            {
                entity.ToTable("contacts_audit");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_contacts_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.AfterValueText)
                    .HasColumnName("after_value_text")
                    .HasColumnType("text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.BeforeValueText)
                    .HasColumnName("before_value_text")
                    .HasColumnType("text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("char(36)");
            });

            modelBuilder.Entity<ContactsBugs>(entity =>
            {
                entity.ToTable("contacts_bugs");

                entity.HasIndex(e => e.BugId)
                    .HasName("idx_con_bug_bug");

                entity.HasIndex(e => e.ContactId)
                    .HasName("idx_con_bug_con");

                entity.HasIndex(e => new { e.ContactId, e.BugId })
                    .HasName("idx_contact_bug");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.BugId)
                    .HasColumnName("bug_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.ContactRole)
                    .HasColumnName("contact_role")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ContactsCases>(entity =>
            {
                entity.ToTable("contacts_cases");

                entity.HasIndex(e => e.CaseId)
                    .HasName("idx_con_case_case");

                entity.HasIndex(e => e.ContactId)
                    .HasName("idx_con_case_con");

                entity.HasIndex(e => new { e.ContactId, e.CaseId })
                    .HasName("idx_contacts_cases");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.CaseId)
                    .HasColumnName("case_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.ContactRole)
                    .HasColumnName("contact_role")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ContactsUsers>(entity =>
            {
                entity.ToTable("contacts_users");

                entity.HasIndex(e => e.ContactId)
                    .HasName("idx_con_users_con");

                entity.HasIndex(e => e.UserId)
                    .HasName("idx_con_users_user");

                entity.HasIndex(e => new { e.ContactId, e.UserId })
                    .HasName("idx_contacts_users");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("varchar(36)");
            });

            modelBuilder.Entity<CronRemoveDocuments>(entity =>
            {
                entity.ToTable("cron_remove_documents");

                entity.HasIndex(e => e.BeanId)
                    .HasName("idx_cron_remove_document_bean_id");

                entity.HasIndex(e => e.DateModified)
                    .HasName("idx_cron_remove_document_stamp");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.BeanId)
                    .HasColumnName("bean_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Module)
                    .HasColumnName("module")
                    .HasColumnType("varchar(25)");
            });

            modelBuilder.Entity<Currencies>(entity =>
            {
                entity.ToTable("currencies");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_currency_name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.ConversionRate)
                    .HasColumnName("conversion_rate")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Iso4217)
                    .HasColumnName("iso4217")
                    .HasColumnType("varchar(3)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Symbol)
                    .HasColumnName("symbol")
                    .HasColumnType("varchar(36)");
            });

            modelBuilder.Entity<DocumentRevisions>(entity =>
            {
                entity.ToTable("document_revisions");

                entity.HasIndex(e => e.FileMimeType)
                    .HasName("documentrevision_mimetype");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.ChangeLog)
                    .HasColumnName("change_log")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DocId)
                    .HasColumnName("doc_id")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.DocType)
                    .HasColumnName("doc_type")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.DocUrl)
                    .HasColumnName("doc_url")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.DocumentId)
                    .HasColumnName("document_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.FileExt)
                    .HasColumnName("file_ext")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.FileMimeType)
                    .HasColumnName("file_mime_type")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Revision)
                    .HasColumnName("revision")
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<Documents>(entity =>
            {
                entity.ToTable("documents");

                entity.HasIndex(e => new { e.CategoryId, e.SubcategoryId })
                    .HasName("idx_doc_cat");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.ActiveDate)
                    .HasColumnName("active_date")
                    .HasColumnType("date");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.DocId)
                    .HasColumnName("doc_id")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.DocType)
                    .HasColumnName("doc_type")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'Sugar'");

                entity.Property(e => e.DocUrl)
                    .HasColumnName("doc_url")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.DocumentName)
                    .HasColumnName("document_name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.DocumentRevisionId)
                    .HasColumnName("document_revision_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.ExpDate)
                    .HasColumnName("exp_date")
                    .HasColumnType("date");

                entity.Property(e => e.IsTemplate)
                    .HasColumnName("is_template")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.RelatedDocId)
                    .HasColumnName("related_doc_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.RelatedDocRevId)
                    .HasColumnName("related_doc_rev_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.StatusId)
                    .HasColumnName("status_id")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.SubcategoryId)
                    .HasColumnName("subcategory_id")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.TemplateType)
                    .HasColumnName("template_type")
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<DocumentsAccounts>(entity =>
            {
                entity.ToTable("documents_accounts");

                entity.HasIndex(e => new { e.AccountId, e.DocumentId })
                    .HasName("documents_accounts_account_id");

                entity.HasIndex(e => new { e.DocumentId, e.AccountId })
                    .HasName("documents_accounts_document_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DocumentId)
                    .HasColumnName("document_id")
                    .HasColumnType("varchar(36)");
            });

            modelBuilder.Entity<DocumentsBugs>(entity =>
            {
                entity.ToTable("documents_bugs");

                entity.HasIndex(e => new { e.BugId, e.DocumentId })
                    .HasName("documents_bugs_bug_id");

                entity.HasIndex(e => new { e.DocumentId, e.BugId })
                    .HasName("documents_bugs_document_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.BugId)
                    .HasColumnName("bug_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DocumentId)
                    .HasColumnName("document_id")
                    .HasColumnType("varchar(36)");
            });

            modelBuilder.Entity<DocumentsCases>(entity =>
            {
                entity.ToTable("documents_cases");

                entity.HasIndex(e => new { e.CaseId, e.DocumentId })
                    .HasName("documents_cases_case_id");

                entity.HasIndex(e => new { e.DocumentId, e.CaseId })
                    .HasName("documents_cases_document_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.CaseId)
                    .HasColumnName("case_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DocumentId)
                    .HasColumnName("document_id")
                    .HasColumnType("varchar(36)");
            });

            modelBuilder.Entity<DocumentsContacts>(entity =>
            {
                entity.ToTable("documents_contacts");

                entity.HasIndex(e => new { e.ContactId, e.DocumentId })
                    .HasName("documents_contacts_contact_id");

                entity.HasIndex(e => new { e.DocumentId, e.ContactId })
                    .HasName("documents_contacts_document_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DocumentId)
                    .HasColumnName("document_id")
                    .HasColumnType("varchar(36)");
            });

            modelBuilder.Entity<DocumentsOpportunities>(entity =>
            {
                entity.ToTable("documents_opportunities");

                entity.HasIndex(e => new { e.DocumentId, e.OpportunityId })
                    .HasName("idx_docu_oppo_docu_id");

                entity.HasIndex(e => new { e.OpportunityId, e.DocumentId })
                    .HasName("idx_docu_opps_oppo_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DocumentId)
                    .HasColumnName("document_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.OpportunityId)
                    .HasColumnName("opportunity_id")
                    .HasColumnType("varchar(36)");
            });

            modelBuilder.Entity<Eapm>(entity =>
            {
                entity.ToTable("eapm");

                entity.HasIndex(e => new { e.AssignedUserId, e.Application, e.Validated })
                    .HasName("idx_app_active");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.ApiData)
                    .HasColumnName("api_data")
                    .HasColumnType("text");

                entity.Property(e => e.Application)
                    .HasColumnName("application")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'webex'");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.ConsumerKey)
                    .HasColumnName("consumer_key")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ConsumerSecret)
                    .HasColumnName("consumer_secret")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.OauthSecret)
                    .HasColumnName("oauth_secret")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.OauthToken)
                    .HasColumnName("oauth_token")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Validated)
                    .HasColumnName("validated")
                    .HasColumnType("tinyint(1)");
            });

            modelBuilder.Entity<EmailAddrBeanRel>(entity =>
            {
                entity.ToTable("email_addr_bean_rel");

                entity.HasIndex(e => e.EmailAddressId)
                    .HasName("idx_email_address_id");

                entity.HasIndex(e => new { e.BeanId, e.BeanModule })
                    .HasName("idx_bean_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.BeanId)
                    .IsRequired()
                    .HasColumnName("bean_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.BeanModule)
                    .HasColumnName("bean_module")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EmailAddressId)
                    .IsRequired()
                    .HasColumnName("email_address_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.PrimaryAddress)
                    .HasColumnName("primary_address")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ReplyToAddress)
                    .HasColumnName("reply_to_address")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<EmailAddresses>(entity =>
            {
                entity.ToTable("email_addresses");

                entity.HasIndex(e => new { e.EmailAddress, e.OptOut, e.InvalidEmail })
                    .HasName("idx_ea_opt_out_invalid");

                entity.HasIndex(e => new { e.EmailAddressCaps, e.OptOut, e.InvalidEmail })
                    .HasName("idx_ea_caps_opt_out_invalid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("email_address")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.EmailAddressCaps)
                    .HasColumnName("email_address_caps")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.InvalidEmail)
                    .HasColumnName("invalid_email")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OptOut)
                    .HasColumnName("opt_out")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Emailman>(entity =>
            {
                entity.ToTable("emailman");

                entity.HasIndex(e => e.CampaignId)
                    .HasName("idx_eman_campaign_id");

                entity.HasIndex(e => new { e.ListId, e.UserId, e.Deleted })
                    .HasName("idx_eman_list");

                entity.HasIndex(e => new { e.RelatedId, e.RelatedType, e.CampaignId })
                    .HasName("idx_eman_relid_reltype_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.InQueue)
                    .HasColumnName("in_queue")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.InQueueDate)
                    .HasColumnName("in_queue_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ListId)
                    .HasColumnName("list_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.MarketingId)
                    .HasColumnName("marketing_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.RelatedId)
                    .HasColumnName("related_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.RelatedType)
                    .HasColumnName("related_type")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.SendAttempts)
                    .HasColumnName("send_attempts")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SendDateTime)
                    .HasColumnName("send_date_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("char(36)");
            });

            modelBuilder.Entity<EmailMarketing>(entity =>
            {
                entity.ToTable("email_marketing");

                entity.HasIndex(e => e.Deleted)
                    .HasName("idx_emmkit_del");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_emmkt_name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AllProspectLists)
                    .HasColumnName("all_prospect_lists")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateStart)
                    .HasColumnName("date_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.FromAddr)
                    .HasColumnName("from_addr")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.FromName)
                    .HasColumnName("from_name")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.InboundEmailId)
                    .HasColumnName("inbound_email_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ReplyToAddr)
                    .HasColumnName("reply_to_addr")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ReplyToName)
                    .HasColumnName("reply_to_name")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.TemplateId)
                    .IsRequired()
                    .HasColumnName("template_id")
                    .HasColumnType("char(36)");
            });

            modelBuilder.Entity<EmailMarketingProspectLists>(entity =>
            {
                entity.ToTable("email_marketing_prospect_lists");

                entity.HasIndex(e => new { e.EmailMarketingId, e.ProspectListId })
                    .HasName("email_mp_prospects");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EmailMarketingId)
                    .HasColumnName("email_marketing_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.ProspectListId)
                    .HasColumnName("prospect_list_id")
                    .HasColumnType("varchar(36)");
            });

            modelBuilder.Entity<Emails>(entity =>
            {
                entity.ToTable("emails");

                entity.HasIndex(e => e.MessageId)
                    .HasName("idx_message_id");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_email_name");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_email_parent_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Type, e.Status })
                    .HasName("idx_email_assigned");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateSent)
                    .HasColumnName("date_sent")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Flagged)
                    .HasColumnName("flagged")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Intent)
                    .HasColumnName("intent")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'pick'");

                entity.Property(e => e.MailboxId)
                    .HasColumnName("mailbox_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.MessageId)
                    .HasColumnName("message_id")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.ParentType)
                    .HasColumnName("parent_type")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ReplyToStatus)
                    .HasColumnName("reply_to_status")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<EmailsBeans>(entity =>
            {
                entity.ToTable("emails_beans");

                entity.HasIndex(e => e.BeanId)
                    .HasName("idx_emails_beans_bean_id");

                entity.HasIndex(e => new { e.EmailId, e.BeanId, e.Deleted })
                    .HasName("idx_emails_beans_email_bean");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.BeanId)
                    .HasColumnName("bean_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.BeanModule)
                    .HasColumnName("bean_module")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.CampaignData)
                    .HasColumnName("campaign_data")
                    .HasColumnType("text");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EmailId)
                    .HasColumnName("email_id")
                    .HasColumnType("char(36)");
            });

            modelBuilder.Entity<EmailsEmailAddrRel>(entity =>
            {
                entity.ToTable("emails_email_addr_rel");

                entity.HasIndex(e => e.EmailAddressId)
                    .HasName("idx_eearl_address_id");

                entity.HasIndex(e => new { e.EmailId, e.AddressType })
                    .HasName("idx_eearl_email_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AddressType)
                    .HasColumnName("address_type")
                    .HasColumnType("varchar(4)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EmailAddressId)
                    .IsRequired()
                    .HasColumnName("email_address_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("email_id")
                    .HasColumnType("char(36)");
            });

            modelBuilder.Entity<EmailsText>(entity =>
            {
                entity.HasKey(e => e.EmailId);

                entity.ToTable("emails_text");

                entity.HasIndex(e => e.FromAddr)
                    .HasName("emails_textfromaddr");

                entity.Property(e => e.EmailId)
                    .HasColumnName("email_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.BccAddrs)
                    .HasColumnName("bcc_addrs")
                    .HasColumnType("text");

                entity.Property(e => e.CcAddrs)
                    .HasColumnName("cc_addrs")
                    .HasColumnType("text");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("longtext");

                entity.Property(e => e.DescriptionHtml)
                    .HasColumnName("description_html")
                    .HasColumnType("longtext");

                entity.Property(e => e.FromAddr)
                    .HasColumnName("from_addr")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.RawSource)
                    .HasColumnName("raw_source")
                    .HasColumnType("longtext");

                entity.Property(e => e.ReplyToAddr)
                    .HasColumnName("reply_to_addr")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ToAddrs)
                    .HasColumnName("to_addrs")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<EmailTemplates>(entity =>
            {
                entity.ToTable("email_templates");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_email_template_name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Body)
                    .HasColumnName("body")
                    .HasColumnType("text");

                entity.Property(e => e.BodyHtml)
                    .HasColumnName("body_html")
                    .HasColumnType("text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Published)
                    .HasColumnName("published")
                    .HasColumnType("varchar(3)");

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.TextOnly)
                    .HasColumnName("text_only")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<FieldsMetaData>(entity =>
            {
                entity.ToTable("fields_meta_data");

                entity.HasIndex(e => new { e.CustomModule, e.Deleted })
                    .HasName("idx_meta_cm_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_meta_id_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Audited)
                    .HasColumnName("audited")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CustomModule)
                    .HasColumnName("custom_module")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefaultValue)
                    .HasColumnName("default_value")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DuplicateMerge)
                    .HasColumnName("duplicate_merge")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Ext1)
                    .HasColumnName("ext1")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Ext2)
                    .HasColumnName("ext2")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Ext3)
                    .HasColumnName("ext3")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Ext4)
                    .HasColumnName("ext4")
                    .HasColumnType("text");

                entity.Property(e => e.Help)
                    .HasColumnName("help")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Importable)
                    .HasColumnName("importable")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Len)
                    .HasColumnName("len")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Massupdate)
                    .HasColumnName("massupdate")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Reportable)
                    .HasColumnName("reportable")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Required)
                    .HasColumnName("required")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Vname)
                    .HasColumnName("vname")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Folders>(entity =>
            {
                entity.ToTable("folders");

                entity.HasIndex(e => e.ParentFolder)
                    .HasName("idx_parent_folder");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AssignToId)
                    .HasColumnName("assign_to_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DynamicQuery)
                    .HasColumnName("dynamic_query")
                    .HasColumnType("text");

                entity.Property(e => e.FolderType)
                    .HasColumnName("folder_type")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.HasChild)
                    .HasColumnName("has_child")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsDynamic)
                    .HasColumnName("is_dynamic")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsGroup)
                    .HasColumnName("is_group")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnName("modified_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.ParentFolder)
                    .HasColumnName("parent_folder")
                    .HasColumnType("char(36)");
            });

            modelBuilder.Entity<FoldersRel>(entity =>
            {
                entity.ToTable("folders_rel");

                entity.HasIndex(e => new { e.PolymorphicModule, e.PolymorphicId })
                    .HasName("idx_poly_module_poly_id");

                entity.HasIndex(e => new { e.FolderId, e.Deleted, e.PolymorphicId })
                    .HasName("idx_fr_id_deleted_poly");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FolderId)
                    .IsRequired()
                    .HasColumnName("folder_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.PolymorphicId)
                    .IsRequired()
                    .HasColumnName("polymorphic_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.PolymorphicModule)
                    .HasColumnName("polymorphic_module")
                    .HasColumnType("varchar(25)");
            });

            modelBuilder.Entity<FoldersSubscriptions>(entity =>
            {
                entity.ToTable("folders_subscriptions");

                entity.HasIndex(e => new { e.FolderId, e.AssignedUserId })
                    .HasName("idx_folder_id_assigned_user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AssignedUserId)
                    .IsRequired()
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.FolderId)
                    .IsRequired()
                    .HasColumnName("folder_id")
                    .HasColumnType("char(36)");
            });

            modelBuilder.Entity<ImportMaps>(entity =>
            {
                entity.ToTable("import_maps");

                entity.HasIndex(e => new { e.AssignedUserId, e.Module, e.Name, e.Deleted })
                    .HasName("idx_owner_module_name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("text");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefaultValues)
                    .HasColumnName("default_values")
                    .HasColumnType("text");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Delimiter)
                    .HasColumnName("delimiter")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("','");

                entity.Property(e => e.Enclosure)
                    .HasColumnName("enclosure")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("' '");

                entity.Property(e => e.HasHeader)
                    .HasColumnName("has_header")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IsPublished)
                    .HasColumnName("is_published")
                    .HasColumnType("varchar(3)")
                    .HasDefaultValueSql("'no'");

                entity.Property(e => e.Module)
                    .HasColumnName("module")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(254)");

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasColumnType("varchar(36)");
            });

            modelBuilder.Entity<InboundEmail>(entity =>
            {
                entity.ToTable("inbound_email");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeleteSeen)
                    .HasColumnName("delete_seen")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EmailPassword)
                    .HasColumnName("email_password")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.EmailUser)
                    .HasColumnName("email_user")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.GroupfolderId)
                    .HasColumnName("groupfolder_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.IsPersonal)
                    .HasColumnName("is_personal")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Mailbox)
                    .HasColumnName("mailbox")
                    .HasColumnType("text");

                entity.Property(e => e.MailboxType)
                    .HasColumnName("mailbox_type")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Port)
                    .HasColumnName("port")
                    .HasColumnType("int(5)");

                entity.Property(e => e.ServerUrl)
                    .HasColumnName("server_url")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Service)
                    .HasColumnName("service")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'Active'");

                entity.Property(e => e.StoredOptions)
                    .HasColumnName("stored_options")
                    .HasColumnType("text");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("char(36)");
            });

            modelBuilder.Entity<InboundEmailAutoreply>(entity =>
            {
                entity.ToTable("inbound_email_autoreply");

                entity.HasIndex(e => e.AutorepliedTo)
                    .HasName("idx_ie_autoreplied_to");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AutorepliedTo)
                    .HasColumnName("autoreplied_to")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IeId)
                    .IsRequired()
                    .HasColumnName("ie_id")
                    .HasColumnType("char(36)");
            });

            modelBuilder.Entity<InboundEmailCacheTs>(entity =>
            {
                entity.ToTable("inbound_email_cache_ts");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.IeTimestamp).HasColumnName("ie_timestamp");
            });

            modelBuilder.Entity<JobQueue>(entity =>
            {
                entity.ToTable("job_queue");

                entity.HasIndex(e => new { e.Status, e.DateEntered })
                    .HasName("idx_status_entered");

                entity.HasIndex(e => new { e.Status, e.DateModified })
                    .HasName("idx_status_modified");

                entity.HasIndex(e => new { e.Status, e.SchedulerId })
                    .HasName("idx_status_scheduler");

                entity.HasIndex(e => new { e.Status, e.ExecuteTime, e.DateEntered })
                    .HasName("idx_status_time");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Client)
                    .HasColumnName("client")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("text");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ExecuteTime)
                    .HasColumnName("execute_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.FailureCount)
                    .HasColumnName("failure_count")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.JobDelay)
                    .HasColumnName("job_delay")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PercentComplete)
                    .HasColumnName("percent_complete")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Requeue)
                    .HasColumnName("requeue")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Resolution)
                    .HasColumnName("resolution")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.RetryCount)
                    .HasColumnName("retry_count")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.SchedulerId)
                    .HasColumnName("scheduler_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Target)
                    .HasColumnName("target")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Leads>(entity =>
            {
                entity.ToTable("leads");

                entity.HasIndex(e => e.AssignedUserId)
                    .HasName("idx_lead_assigned");

                entity.HasIndex(e => e.ContactId)
                    .HasName("idx_lead_contact");

                entity.HasIndex(e => e.PhoneWork)
                    .HasName("idx_lead_phone_work");

                entity.HasIndex(e => e.ReportsToId)
                    .HasName("idx_reports_to");

                entity.HasIndex(e => new { e.AccountId, e.Deleted })
                    .HasName("idx_leads_acct_del");

                entity.HasIndex(e => new { e.AccountName, e.Deleted })
                    .HasName("idx_lead_acct_name_first");

                entity.HasIndex(e => new { e.Deleted, e.AssignedUserId })
                    .HasName("idx_del_user");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_leads_id_del");

                entity.HasIndex(e => new { e.OpportunityId, e.Deleted })
                    .HasName("idx_lead_opp_del");

                entity.HasIndex(e => new { e.LastName, e.FirstName, e.Deleted })
                    .HasName("idx_lead_last_first");

                entity.HasIndex(e => new { e.LastName, e.Status, e.Deleted, e.FirstName })
                    .HasName("idx_lead_del_stat");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AccountDescription)
                    .HasColumnName("account_description")
                    .HasColumnType("text");

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.AltAddressCity)
                    .HasColumnName("alt_address_city")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.AltAddressCountry)
                    .HasColumnName("alt_address_country")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.AltAddressPostalcode)
                    .HasColumnName("alt_address_postalcode")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.AltAddressState)
                    .HasColumnName("alt_address_state")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.AltAddressStreet)
                    .HasColumnName("alt_address_street")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Assistant)
                    .HasColumnName("assistant")
                    .HasColumnType("varchar(75)");

                entity.Property(e => e.AssistantPhone)
                    .HasColumnName("assistant_phone")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Birthdate)
                    .HasColumnName("birthdate")
                    .HasColumnType("date");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Converted)
                    .HasColumnName("converted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.DoNotCall)
                    .HasColumnName("do_not_call")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.LeadSource)
                    .HasColumnName("lead_source")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.LeadSourceDescription)
                    .HasColumnName("lead_source_description")
                    .HasColumnType("text");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.OpportunityAmount)
                    .HasColumnName("opportunity_amount")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.OpportunityId)
                    .HasColumnName("opportunity_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.OpportunityName)
                    .HasColumnName("opportunity_name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PhoneFax)
                    .HasColumnName("phone_fax")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PhoneHome)
                    .HasColumnName("phone_home")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PhoneMobile)
                    .HasColumnName("phone_mobile")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PhoneOther)
                    .HasColumnName("phone_other")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PhoneWork)
                    .HasColumnName("phone_work")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PortalApp)
                    .HasColumnName("portal_app")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PortalName)
                    .HasColumnName("portal_name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PrimaryAddressCity)
                    .HasColumnName("primary_address_city")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PrimaryAddressCountry)
                    .HasColumnName("primary_address_country")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PrimaryAddressPostalcode)
                    .HasColumnName("primary_address_postalcode")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PrimaryAddressState)
                    .HasColumnName("primary_address_state")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PrimaryAddressStreet)
                    .HasColumnName("primary_address_street")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.ReferedBy)
                    .HasColumnName("refered_by")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ReportsToId)
                    .HasColumnName("reports_to_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Salutation)
                    .HasColumnName("salutation")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.StatusDescription)
                    .HasColumnName("status_description")
                    .HasColumnType("text");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<LeadsAudit>(entity =>
            {
                entity.ToTable("leads_audit");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_leads_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.AfterValueText)
                    .HasColumnName("after_value_text")
                    .HasColumnType("text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.BeforeValueText)
                    .HasColumnName("before_value_text")
                    .HasColumnType("text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("char(36)");
            });

            modelBuilder.Entity<LinkedDocuments>(entity =>
            {
                entity.ToTable("linked_documents");

                entity.HasIndex(e => new { e.ParentType, e.ParentId, e.DocumentId })
                    .HasName("idx_parent_document");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DocumentId)
                    .HasColumnName("document_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DocumentRevisionId)
                    .HasColumnName("document_revision_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.ParentType)
                    .HasColumnName("parent_type")
                    .HasColumnType("varchar(25)");
            });

            modelBuilder.Entity<Meetings>(entity =>
            {
                entity.ToTable("meetings");

                entity.HasIndex(e => e.DateStart)
                    .HasName("idx_meet_date_start");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_mtg_name");

                entity.HasIndex(e => new { e.AssignedUserId, e.Status, e.Deleted })
                    .HasName("idx_meet_stat_del");

                entity.HasIndex(e => new { e.ParentId, e.ParentType, e.Deleted })
                    .HasName("idx_meet_par_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Creator)
                    .HasColumnName("creator")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.DateEnd)
                    .HasColumnName("date_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateStart)
                    .HasColumnName("date_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.DisplayedUrl)
                    .HasColumnName("displayed_url")
                    .HasColumnType("varchar(400)");

                entity.Property(e => e.DurationHours)
                    .HasColumnName("duration_hours")
                    .HasColumnType("int(3)");

                entity.Property(e => e.DurationMinutes)
                    .HasColumnName("duration_minutes")
                    .HasColumnType("int(2)");

                entity.Property(e => e.EmailReminderSent)
                    .HasColumnName("email_reminder_sent")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EmailReminderTime)
                    .HasColumnName("email_reminder_time")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.ExternalId)
                    .HasColumnName("external_id")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.HostUrl)
                    .HasColumnName("host_url")
                    .HasColumnType("varchar(400)");

                entity.Property(e => e.JoinUrl)
                    .HasColumnName("join_url")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.OutlookId)
                    .HasColumnName("outlook_id")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.ParentType)
                    .HasColumnName("parent_type")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.RecurringSource)
                    .HasColumnName("recurring_source")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.ReminderTime)
                    .HasColumnName("reminder_time")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.RepeatCount)
                    .HasColumnName("repeat_count")
                    .HasColumnType("int(7)");

                entity.Property(e => e.RepeatDow)
                    .HasColumnName("repeat_dow")
                    .HasColumnType("varchar(7)");

                entity.Property(e => e.RepeatInterval)
                    .HasColumnName("repeat_interval")
                    .HasColumnType("int(3)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.RepeatParentId)
                    .HasColumnName("repeat_parent_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.RepeatType)
                    .HasColumnName("repeat_type")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.RepeatUntil)
                    .HasColumnName("repeat_until")
                    .HasColumnType("date");

                entity.Property(e => e.Sequence)
                    .HasColumnName("sequence")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'Planned'");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'Sugar'");
            });

            modelBuilder.Entity<MeetingsContacts>(entity =>
            {
                entity.ToTable("meetings_contacts");

                entity.HasIndex(e => e.ContactId)
                    .HasName("idx_con_mtg_con");

                entity.HasIndex(e => e.MeetingId)
                    .HasName("idx_con_mtg_mtg");

                entity.HasIndex(e => new { e.MeetingId, e.ContactId })
                    .HasName("idx_meeting_contact");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.AcceptStatus)
                    .HasColumnName("accept_status")
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("'none'");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MeetingId)
                    .HasColumnName("meeting_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.Required)
                    .HasColumnName("required")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<MeetingsLeads>(entity =>
            {
                entity.ToTable("meetings_leads");

                entity.HasIndex(e => e.LeadId)
                    .HasName("idx_lead_meeting_lead");

                entity.HasIndex(e => e.MeetingId)
                    .HasName("idx_lead_meeting_meeting");

                entity.HasIndex(e => new { e.MeetingId, e.LeadId })
                    .HasName("idx_meeting_lead");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.AcceptStatus)
                    .HasColumnName("accept_status")
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("'none'");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LeadId)
                    .HasColumnName("lead_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.MeetingId)
                    .HasColumnName("meeting_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.Required)
                    .HasColumnName("required")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<MeetingsUsers>(entity =>
            {
                entity.ToTable("meetings_users");

                entity.HasIndex(e => e.MeetingId)
                    .HasName("idx_usr_mtg_mtg");

                entity.HasIndex(e => e.UserId)
                    .HasName("idx_usr_mtg_usr");

                entity.HasIndex(e => new { e.MeetingId, e.UserId })
                    .HasName("idx_meeting_users");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.AcceptStatus)
                    .HasColumnName("accept_status")
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("'none'");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MeetingId)
                    .HasColumnName("meeting_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.Required)
                    .HasColumnName("required")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("varchar(36)");
            });

            modelBuilder.Entity<Notes>(entity =>
            {
                entity.ToTable("notes");

                entity.HasIndex(e => e.ContactId)
                    .HasName("idx_note_contact");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_note_name");

                entity.HasIndex(e => new { e.Deleted, e.AssignedUserId })
                    .HasName("idx_notes_assigned_del");

                entity.HasIndex(e => new { e.ParentId, e.ParentType })
                    .HasName("idx_notes_parent");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.EmbedFlag)
                    .HasColumnName("embed_flag")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FileMimeType)
                    .HasColumnName("file_mime_type")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.ParentType)
                    .HasColumnName("parent_type")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PortalFlag)
                    .HasColumnName("portal_flag")
                    .HasColumnType("tinyint(1)");
            });

            modelBuilder.Entity<OauthConsumer>(entity =>
            {
                entity.ToTable("oauth_consumer");

                entity.HasIndex(e => e.CKey)
                    .HasName("ckey")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.CKey)
                    .HasColumnName("c_key")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CSecret)
                    .HasColumnName("c_secret")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<OauthNonce>(entity =>
            {
                entity.HasKey(e => new { e.Conskey, e.Nonce });

                entity.ToTable("oauth_nonce");

                entity.HasIndex(e => new { e.Conskey, e.NonceTs })
                    .HasName("oauth_nonce_keyts");

                entity.Property(e => e.Conskey)
                    .HasColumnName("conskey")
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.Nonce)
                    .HasColumnName("nonce")
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.NonceTs)
                    .HasColumnName("nonce_ts")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<OauthTokens>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Deleted });

                entity.ToTable("oauth_tokens");

                entity.HasIndex(e => e.Consumer)
                    .HasName("constoken_key");

                entity.HasIndex(e => new { e.Tstate, e.TokenTs })
                    .HasName("oauth_state_ts");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.CallbackUrl)
                    .HasColumnName("callback_url")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Consumer)
                    .IsRequired()
                    .HasColumnName("consumer")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Secret)
                    .HasColumnName("secret")
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.TokenTs)
                    .HasColumnName("token_ts")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Tstate)
                    .HasColumnName("tstate")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.Verify)
                    .HasColumnName("verify")
                    .HasColumnType("varchar(32)");
            });

            modelBuilder.Entity<Opportunities>(entity =>
            {
                entity.ToTable("opportunities");

                entity.HasIndex(e => e.AssignedUserId)
                    .HasName("idx_opp_assigned");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_opp_name");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_opp_id_deleted");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.AmountUsdollar).HasColumnName("amount_usdollar");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("currency_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateClosed)
                    .HasColumnName("date_closed")
                    .HasColumnType("date");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.LeadSource)
                    .HasColumnName("lead_source")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.NextStep)
                    .HasColumnName("next_step")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.OpportunityType)
                    .HasColumnName("opportunity_type")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Probability).HasColumnName("probability");

                entity.Property(e => e.SalesStage)
                    .HasColumnName("sales_stage")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<OpportunitiesAudit>(entity =>
            {
                entity.ToTable("opportunities_audit");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_opportunities_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.AfterValueText)
                    .HasColumnName("after_value_text")
                    .HasColumnType("text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.BeforeValueText)
                    .HasColumnName("before_value_text")
                    .HasColumnType("text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("char(36)");
            });

            modelBuilder.Entity<OpportunitiesContacts>(entity =>
            {
                entity.ToTable("opportunities_contacts");

                entity.HasIndex(e => e.ContactId)
                    .HasName("idx_con_opp_con");

                entity.HasIndex(e => e.OpportunityId)
                    .HasName("idx_con_opp_opp");

                entity.HasIndex(e => new { e.OpportunityId, e.ContactId })
                    .HasName("idx_opportunities_contacts");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.ContactRole)
                    .HasColumnName("contact_role")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OpportunityId)
                    .HasColumnName("opportunity_id")
                    .HasColumnType("varchar(36)");
            });

            modelBuilder.Entity<OutboundEmail>(entity =>
            {
                entity.ToTable("outbound_email");

                entity.HasIndex(e => new { e.Id, e.UserId })
                    .HasName("oe_user_id_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.MailSendtype)
                    .HasColumnName("mail_sendtype")
                    .HasColumnType("varchar(8)")
                    .HasDefaultValueSql("'smtp'");

                entity.Property(e => e.MailSmtpauthReq)
                    .HasColumnName("mail_smtpauth_req")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MailSmtppass)
                    .HasColumnName("mail_smtppass")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.MailSmtpport)
                    .HasColumnName("mail_smtpport")
                    .HasColumnType("int(5)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MailSmtpserver)
                    .HasColumnName("mail_smtpserver")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.MailSmtpssl)
                    .HasColumnName("mail_smtpssl")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MailSmtptype)
                    .HasColumnName("mail_smtptype")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'other'");

                entity.Property(e => e.MailSmtpuser)
                    .HasColumnName("mail_smtpuser")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("'user'");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("user_id")
                    .HasColumnType("char(36)");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("project");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.EstimatedEndDate)
                    .HasColumnName("estimated_end_date")
                    .HasColumnType("date");

                entity.Property(e => e.EstimatedStartDate)
                    .HasColumnName("estimated_start_date")
                    .HasColumnType("date");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<ProjectsAccounts>(entity =>
            {
                entity.ToTable("projects_accounts");

                entity.HasIndex(e => e.AccountId)
                    .HasName("idx_proj_acct_acct");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("idx_proj_acct_proj");

                entity.HasIndex(e => new { e.ProjectId, e.AccountId })
                    .HasName("projects_accounts_alt");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasColumnType("varchar(36)");
            });

            modelBuilder.Entity<ProjectsBugs>(entity =>
            {
                entity.ToTable("projects_bugs");

                entity.HasIndex(e => e.BugId)
                    .HasName("idx_proj_bug_bug");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("idx_proj_bug_proj");

                entity.HasIndex(e => new { e.ProjectId, e.BugId })
                    .HasName("projects_bugs_alt");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.BugId)
                    .HasColumnName("bug_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasColumnType("varchar(36)");
            });

            modelBuilder.Entity<ProjectsCases>(entity =>
            {
                entity.ToTable("projects_cases");

                entity.HasIndex(e => e.CaseId)
                    .HasName("idx_proj_case_case");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("idx_proj_case_proj");

                entity.HasIndex(e => new { e.ProjectId, e.CaseId })
                    .HasName("projects_cases_alt");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.CaseId)
                    .HasColumnName("case_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasColumnType("varchar(36)");
            });

            modelBuilder.Entity<ProjectsContacts>(entity =>
            {
                entity.ToTable("projects_contacts");

                entity.HasIndex(e => e.ContactId)
                    .HasName("idx_proj_con_con");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("idx_proj_con_proj");

                entity.HasIndex(e => new { e.ProjectId, e.ContactId })
                    .HasName("projects_contacts_alt");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasColumnType("varchar(36)");
            });

            modelBuilder.Entity<ProjectsOpportunities>(entity =>
            {
                entity.ToTable("projects_opportunities");

                entity.HasIndex(e => e.OpportunityId)
                    .HasName("idx_proj_opp_opp");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("idx_proj_opp_proj");

                entity.HasIndex(e => new { e.ProjectId, e.OpportunityId })
                    .HasName("projects_opportunities_alt");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OpportunityId)
                    .HasColumnName("opportunity_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasColumnType("varchar(36)");
            });

            modelBuilder.Entity<ProjectsProducts>(entity =>
            {
                entity.ToTable("projects_products");

                entity.HasIndex(e => e.ProductId)
                    .HasName("idx_proj_prod_product");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("idx_proj_prod_project");

                entity.HasIndex(e => new { e.ProjectId, e.ProductId })
                    .HasName("projects_products_alt");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasColumnType("varchar(36)");
            });

            modelBuilder.Entity<ProjectTask>(entity =>
            {
                entity.ToTable("project_task");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.ActualDuration)
                    .HasColumnName("actual_duration")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActualEffort)
                    .HasColumnName("actual_effort")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateDue)
                    .HasColumnName("date_due")
                    .HasColumnType("date");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateFinish)
                    .HasColumnName("date_finish")
                    .HasColumnType("date");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateStart)
                    .HasColumnName("date_start")
                    .HasColumnType("date");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.Duration)
                    .HasColumnName("duration")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DurationUnit)
                    .HasColumnName("duration_unit")
                    .HasColumnType("text");

                entity.Property(e => e.EstimatedEffort)
                    .HasColumnName("estimated_effort")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MilestoneFlag)
                    .HasColumnName("milestone_flag")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ParentTaskId)
                    .HasColumnName("parent_task_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PercentComplete)
                    .HasColumnName("percent_complete")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Predecessors)
                    .HasColumnName("predecessors")
                    .HasColumnType("text");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ProjectId)
                    .IsRequired()
                    .HasColumnName("project_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.ProjectTaskId)
                    .HasColumnName("project_task_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.TaskNumber)
                    .HasColumnName("task_number")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TimeDue)
                    .HasColumnName("time_due")
                    .HasColumnType("time");

                entity.Property(e => e.TimeFinish)
                    .HasColumnName("time_finish")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TimeStart)
                    .HasColumnName("time_start")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Utilization)
                    .HasColumnName("utilization")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'100'");
            });

            modelBuilder.Entity<ProjectTaskAudit>(entity =>
            {
                entity.ToTable("project_task_audit");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_project_task_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.AfterValueText)
                    .HasColumnName("after_value_text")
                    .HasColumnType("text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.BeforeValueText)
                    .HasColumnName("before_value_text")
                    .HasColumnType("text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("char(36)");
            });

            modelBuilder.Entity<ProspectListCampaigns>(entity =>
            {
                entity.ToTable("prospect_list_campaigns");

                entity.HasIndex(e => e.CampaignId)
                    .HasName("idx_cam_id");

                entity.HasIndex(e => e.ProspectListId)
                    .HasName("idx_pro_id");

                entity.HasIndex(e => new { e.ProspectListId, e.CampaignId })
                    .HasName("idx_prospect_list_campaigns");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ProspectListId)
                    .HasColumnName("prospect_list_id")
                    .HasColumnType("varchar(36)");
            });

            modelBuilder.Entity<ProspectLists>(entity =>
            {
                entity.ToTable("prospect_lists");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_prospect_list_name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.DomainName)
                    .HasColumnName("domain_name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ListType)
                    .HasColumnName("list_type")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ProspectListsProspects>(entity =>
            {
                entity.ToTable("prospect_lists_prospects");

                entity.HasIndex(e => e.ProspectListId)
                    .HasName("idx_plp_pro_id");

                entity.HasIndex(e => new { e.RelatedId, e.RelatedType, e.ProspectListId })
                    .HasName("idx_plp_rel_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ProspectListId)
                    .HasColumnName("prospect_list_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.RelatedId)
                    .HasColumnName("related_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.RelatedType)
                    .HasColumnName("related_type")
                    .HasColumnType("varchar(25)");
            });

            modelBuilder.Entity<Prospects>(entity =>
            {
                entity.ToTable("prospects");

                entity.HasIndex(e => e.AssignedUserId)
                    .HasName("idx_prospects_assigned");

                entity.HasIndex(e => e.TrackerKey)
                    .HasName("prospect_auto_tracker_key");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_prospects_id_del");

                entity.HasIndex(e => new { e.LastName, e.Deleted })
                    .HasName("idx_prospecs_del_last");

                entity.HasIndex(e => new { e.LastName, e.FirstName, e.Deleted })
                    .HasName("idx_prospects_last_first");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.AltAddressCity)
                    .HasColumnName("alt_address_city")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.AltAddressCountry)
                    .HasColumnName("alt_address_country")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.AltAddressPostalcode)
                    .HasColumnName("alt_address_postalcode")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.AltAddressState)
                    .HasColumnName("alt_address_state")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.AltAddressStreet)
                    .HasColumnName("alt_address_street")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Assistant)
                    .HasColumnName("assistant")
                    .HasColumnType("varchar(75)");

                entity.Property(e => e.AssistantPhone)
                    .HasColumnName("assistant_phone")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Birthdate)
                    .HasColumnName("birthdate")
                    .HasColumnType("date");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.DoNotCall)
                    .HasColumnName("do_not_call")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.LeadId)
                    .HasColumnName("lead_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.PhoneFax)
                    .HasColumnName("phone_fax")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PhoneHome)
                    .HasColumnName("phone_home")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PhoneMobile)
                    .HasColumnName("phone_mobile")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PhoneOther)
                    .HasColumnName("phone_other")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PhoneWork)
                    .HasColumnName("phone_work")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PrimaryAddressCity)
                    .HasColumnName("primary_address_city")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PrimaryAddressCountry)
                    .HasColumnName("primary_address_country")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PrimaryAddressPostalcode)
                    .HasColumnName("primary_address_postalcode")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PrimaryAddressState)
                    .HasColumnName("primary_address_state")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PrimaryAddressStreet)
                    .HasColumnName("primary_address_street")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Salutation)
                    .HasColumnName("salutation")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.TrackerKey)
                    .HasColumnName("tracker_key")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Relationships>(entity =>
            {
                entity.ToTable("relationships");

                entity.HasIndex(e => e.RelationshipName)
                    .HasName("idx_rel_name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.JoinKeyLhs)
                    .HasColumnName("join_key_lhs")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.JoinKeyRhs)
                    .HasColumnName("join_key_rhs")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.JoinTable)
                    .HasColumnName("join_table")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.LhsKey)
                    .HasColumnName("lhs_key")
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.LhsModule)
                    .HasColumnName("lhs_module")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.LhsTable)
                    .HasColumnName("lhs_table")
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.RelationshipName)
                    .HasColumnName("relationship_name")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.RelationshipRoleColumn)
                    .HasColumnName("relationship_role_column")
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.RelationshipRoleColumnValue)
                    .HasColumnName("relationship_role_column_value")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.RelationshipType)
                    .HasColumnName("relationship_type")
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.Reverse)
                    .HasColumnName("reverse")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RhsKey)
                    .HasColumnName("rhs_key")
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.RhsModule)
                    .HasColumnName("rhs_module")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.RhsTable)
                    .HasColumnName("rhs_table")
                    .HasColumnType("varchar(64)");
            });

            modelBuilder.Entity<Releases>(entity =>
            {
                entity.ToTable("releases");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_releases");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.ListOrder)
                    .HasColumnName("list_order")
                    .HasColumnType("int(4)");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.ToTable("roles");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_role_id_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Modules)
                    .HasColumnName("modules")
                    .HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(150)");
            });

            modelBuilder.Entity<RolesModules>(entity =>
            {
                entity.ToTable("roles_modules");

                entity.HasIndex(e => e.ModuleId)
                    .HasName("idx_module_id");

                entity.HasIndex(e => e.RoleId)
                    .HasName("idx_role_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.Allow)
                    .HasColumnName("allow")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModuleId)
                    .HasColumnName("module_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .HasColumnType("varchar(36)");
            });

            modelBuilder.Entity<RolesUsers>(entity =>
            {
                entity.ToTable("roles_users");

                entity.HasIndex(e => e.RoleId)
                    .HasName("idx_ru_role_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("idx_ru_user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("varchar(36)");
            });

            modelBuilder.Entity<SavedSearch>(entity =>
            {
                entity.ToTable("saved_search");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_desc");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Contents)
                    .HasColumnName("contents")
                    .HasColumnType("text");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.SearchModule)
                    .HasColumnName("search_module")
                    .HasColumnType("varchar(150)");
            });

            modelBuilder.Entity<Schedulers>(entity =>
            {
                entity.ToTable("schedulers");

                entity.HasIndex(e => new { e.DateTimeStart, e.Deleted })
                    .HasName("idx_schedule");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.CatchUp)
                    .HasColumnName("catch_up")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateTimeEnd)
                    .HasColumnName("date_time_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateTimeStart)
                    .HasColumnName("date_time_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Job)
                    .HasColumnName("job")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.JobInterval)
                    .HasColumnName("job_interval")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.LastRun)
                    .HasColumnName("last_run")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.TimeFrom)
                    .HasColumnName("time_from")
                    .HasColumnType("time");

                entity.Property(e => e.TimeTo)
                    .HasColumnName("time_to")
                    .HasColumnType("time");
            });

            modelBuilder.Entity<Sugarfeed>(entity =>
            {
                entity.ToTable("sugarfeed");

                entity.HasIndex(e => new { e.DateEntered, e.Deleted })
                    .HasName("sgrfeed_date");

                entity.HasIndex(e => new { e.RelatedModule, e.RelatedId, e.DateEntered })
                    .HasName("idx_sgrfeed_rmod_rid_date");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.LinkType)
                    .HasColumnName("link_type")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.LinkUrl)
                    .HasColumnName("link_url")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.RelatedId)
                    .HasColumnName("related_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.RelatedModule)
                    .HasColumnName("related_module")
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<Tasks>(entity =>
            {
                entity.ToTable("tasks");

                entity.HasIndex(e => e.AssignedUserId)
                    .HasName("idx_task_assigned");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_tsk_name");

                entity.HasIndex(e => e.Status)
                    .HasName("idx_task_status");

                entity.HasIndex(e => new { e.ContactId, e.Deleted })
                    .HasName("idx_task_con_del");

                entity.HasIndex(e => new { e.ParentId, e.ParentType, e.Deleted })
                    .HasName("idx_task_par_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateDue)
                    .HasColumnName("date_due")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateDueFlag)
                    .HasColumnName("date_due_flag")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateStart)
                    .HasColumnName("date_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateStartFlag)
                    .HasColumnName("date_start_flag")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.ParentType)
                    .HasColumnName("parent_type")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'Not Started'");
            });

            modelBuilder.Entity<Tracker>(entity =>
            {
                entity.ToTable("tracker");

                entity.HasIndex(e => e.DateModified)
                    .HasName("idx_tracker_date_modified");

                entity.HasIndex(e => e.ItemId)
                    .HasName("idx_tracker_iid");

                entity.HasIndex(e => e.MonitorId)
                    .HasName("idx_tracker_monitor_id");

                entity.HasIndex(e => new { e.UserId, e.ItemId, e.Visible })
                    .HasName("idx_tracker_userid_itemid_vis");

                entity.HasIndex(e => new { e.UserId, e.Visible, e.Id })
                    .HasName("idx_tracker_userid_vis_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Action)
                    .HasColumnName("action")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ItemId)
                    .HasColumnName("item_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.ItemSummary)
                    .HasColumnName("item_summary")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModuleName)
                    .HasColumnName("module_name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.MonitorId)
                    .IsRequired()
                    .HasColumnName("monitor_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.SessionId)
                    .HasColumnName("session_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.Visible)
                    .HasColumnName("visible")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<UpgradeHistory>(entity =>
            {
                entity.ToTable("upgrade_history");

                entity.HasIndex(e => e.Md5sum)
                    .HasName("upgrade_history_md5_uk")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.IdName)
                    .HasColumnName("id_name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Manifest)
                    .HasColumnName("manifest")
                    .HasColumnType("longtext");

                entity.Property(e => e.Md5sum)
                    .HasColumnName("md5sum")
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasColumnType("varchar(64)");
            });

            modelBuilder.Entity<UserPreferences>(entity =>
            {
                entity.ToTable("user_preferences");

                entity.HasIndex(e => new { e.AssignedUserId, e.Category })
                    .HasName("idx_userprefnamecat");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Contents)
                    .HasColumnName("contents")
                    .HasColumnType("longtext");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => new { e.UserName, e.IsGroup, e.Status, e.LastName, e.FirstName, e.Id })
                    .HasName("idx_user_name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AddressCity)
                    .HasColumnName("address_city")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.AddressCountry)
                    .HasColumnName("address_country")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.AddressPostalcode)
                    .HasColumnName("address_postalcode")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.AddressState)
                    .HasColumnName("address_state")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.AddressStreet)
                    .HasColumnName("address_street")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.AuthenticateId)
                    .HasColumnName("authenticate_id")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.EmployeeStatus)
                    .HasColumnName("employee_status")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ExternalAuthOnly)
                    .HasColumnName("external_auth_only")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.IsAdmin)
                    .HasColumnName("is_admin")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsGroup)
                    .HasColumnName("is_group")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.MessengerId)
                    .HasColumnName("messenger_id")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.MessengerType)
                    .HasColumnName("messenger_type")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.PhoneFax)
                    .HasColumnName("phone_fax")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PhoneHome)
                    .HasColumnName("phone_home")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PhoneMobile)
                    .HasColumnName("phone_mobile")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PhoneOther)
                    .HasColumnName("phone_other")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PhoneWork)
                    .HasColumnName("phone_work")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PortalOnly)
                    .HasColumnName("portal_only")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PwdLastChanged)
                    .HasColumnName("pwd_last_changed")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReceiveNotifications)
                    .HasColumnName("receive_notifications")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ReportsToId)
                    .HasColumnName("reports_to_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.ShowOnEmployees)
                    .HasColumnName("show_on_employees")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.SugarLogin)
                    .HasColumnName("sugar_login")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SystemGeneratedPassword)
                    .HasColumnName("system_generated_password")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UserHash)
                    .HasColumnName("user_hash")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasColumnType("varchar(60)");
            });

            modelBuilder.Entity<UsersLastImport>(entity =>
            {
                entity.ToTable("users_last_import");

                entity.HasIndex(e => e.AssignedUserId)
                    .HasName("idx_user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.BeanId)
                    .HasColumnName("bean_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.BeanType)
                    .HasColumnName("bean_type")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.ImportModule)
                    .HasColumnName("import_module")
                    .HasColumnType("varchar(36)");
            });

            modelBuilder.Entity<UsersPasswordLink>(entity =>
            {
                entity.ToTable("users_password_link");

                entity.HasIndex(e => e.Username)
                    .HasName("idx_username");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateGenerated)
                    .HasColumnName("date_generated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasColumnType("varchar(36)");
            });

            modelBuilder.Entity<UsersSignatures>(entity =>
            {
                entity.ToTable("users_signatures");

                entity.HasIndex(e => e.UserId)
                    .HasName("idx_usersig_uid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Signature)
                    .HasColumnName("signature")
                    .HasColumnType("text");

                entity.Property(e => e.SignatureHtml)
                    .HasColumnName("signature_html")
                    .HasColumnType("text");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("varchar(36)");
            });

            modelBuilder.Entity<Vcals>(entity =>
            {
                entity.ToTable("vcals");

                entity.HasIndex(e => new { e.Type, e.UserId })
                    .HasName("idx_vcal");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("text");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("user_id")
                    .HasColumnType("char(36)");
            });

            modelBuilder.Entity<Versions>(entity =>
            {
                entity.ToTable("versions");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_version");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("char(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.DbVersion)
                    .HasColumnName("db_version")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.FileVersion)
                    .HasColumnName("file_version")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");
            });
        }
    }
}
