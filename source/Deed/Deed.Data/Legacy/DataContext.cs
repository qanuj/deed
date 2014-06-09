namespace Deed.Data.Legacy {
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataContext : DbContext {
        public DataContext()
            : base("name=LegacyDataContext") {
        }

        public virtual DbSet<BackupDetail> BackupDetails { get; set; }
        public virtual DbSet<BackupSchedule> BackupSchedules { get; set; }
        public virtual DbSet<BankPaymentStatusTrans> BankPaymentStatusTransactions { get; set; }
        public virtual DbSet<Cast> Casts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Cla> Clas { get; set; }
        public virtual DbSet<PaymentDetails> PaymentDetails { get; set; }
        public virtual DbSet<ClientPayments> ClientPayments { get; set; }
        public virtual DbSet<ClientProfile> ClientProfiles { get; set; }
        public virtual DbSet<ClientRemiders> ClientRemiders { get; set; }
        public virtual DbSet<ClientSettings> ClientSettings { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Cms> Cms { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Dashboard> Dashboard { get; set; }
        public virtual DbSet<Document> Docments { get; set; }
        public virtual DbSet<EmailTemplates> EmailTemplates { get; set; }
        public virtual DbSet<Feature> Features { get; set; }
        public virtual DbSet<Fee> Fees { get; set; }
        public virtual DbSet<ForgotPassRequest> ForgotPassRequests { get; set; }
        public virtual DbSet<GeneralSetting> GeneralSettings { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<InviteFriends> InviteFriends { get; set; }
        public virtual DbSet<ModuleAction> ModuleActions { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<PasswordRecoveries> PasswordRecoveries { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PhoneCodes> PhoneCodes { get; set; }
        public virtual DbSet<Plan> Plans { get; set; }
        public virtual DbSet<SMTPDetail> SMTPDetails { get; set; }
        public virtual DbSet<SMTP> SMTP { get; set; }
        public virtual DbSet<SponsorPaymentHistory> SponsorPaymentHistories { get; set; }
        public virtual DbSet<Sponsor> Sponsors { get; set; }
        public virtual DbSet<Sponsorship> Sponsorships { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Story> Stories { get; set; }
        public virtual DbSet<StudentHistory> StudentHistories { get; set; }
        public virtual DbSet<StudentImage> StudentImages { get; set; }
        public virtual DbSet<StudentPaymentDetails> StudentPaymentDetails { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<UserActions> UserActions { get; set; }
        public virtual DbSet<UserPermission> UserPermissions { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Volunteer> Volunteers { get; set; }
        public virtual DbSet<YouTubeVideos> YouTubeVideos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<BackupDetail>()
                .Property(e => e.serial_id)
                .IsUnicode(false);

            modelBuilder.Entity<BackupDetail>()
                .Property(e => e.db)
                .IsUnicode(false);

            modelBuilder.Entity<BackupDetail>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<BackupDetail>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<BackupSchedule>()
                .Property(e => e.schedule_time)
                .IsUnicode(false);

            modelBuilder.Entity<BackupSchedule>()
                .Property(e => e.db_to)
                .IsUnicode(false);

            modelBuilder.Entity<BackupSchedule>()
                .Property(e => e.image_from)
                .IsUnicode(false);

            modelBuilder.Entity<BackupSchedule>()
                .Property(e => e.image_to)
                .IsUnicode(false);

            modelBuilder.Entity<BackupSchedule>()
                .Property(e => e.code_from)
                .IsUnicode(false);

            modelBuilder.Entity<BackupSchedule>()
                .Property(e => e.code_to)
                .IsUnicode(false);

            modelBuilder.Entity<BankPaymentStatusTrans>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<BankPaymentStatusTrans>()
                .Property(e => e.bank_type)
                .IsUnicode(false);

            modelBuilder.Entity<BankPaymentStatusTrans>()
                .Property(e => e.txnresult)
                .IsUnicode(false);

            modelBuilder.Entity<BankPaymentStatusTrans>()
                .Property(e => e.txnpaymentid)
                .IsUnicode(false);

            modelBuilder.Entity<BankPaymentStatusTrans>()
                .Property(e => e.txnref)
                .IsUnicode(false);

            modelBuilder.Entity<BankPaymentStatusTrans>()
                .Property(e => e.txntranid)
                .IsUnicode(false);

            modelBuilder.Entity<BankPaymentStatusTrans>()
                .Property(e => e.txnamount)
                .IsUnicode(false);

            modelBuilder.Entity<BankPaymentStatusTrans>()
                .Property(e => e.txnerror)
                .IsUnicode(false);

            modelBuilder.Entity<BankPaymentStatusTrans>()
                .Property(e => e.terminalid)
                .IsUnicode(false);

            modelBuilder.Entity<Cast>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Cla>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<ClientPayments>()
                .Property(e => e.transaction_number)
                .IsUnicode(false);

            modelBuilder.Entity<ClientPayments>()
                .Property(e => e.payment_mode)
                .IsUnicode(false);

            modelBuilder.Entity<ClientPayments>()
                .Property(e => e.currency)
                .IsUnicode(false);

            modelBuilder.Entity<ClientPayments>()
                .Property(e => e.payment_type)
                .IsUnicode(false);

            modelBuilder.Entity<ClientPayments>()
                .Property(e => e.bank_name)
                .IsUnicode(false);

            modelBuilder.Entity<ClientPayments>()
                .Property(e => e.cheque_no)
                .IsUnicode(false);

            modelBuilder.Entity<ClientPayments>()
                .Property(e => e.reciept)
                .IsUnicode(false);

            modelBuilder.Entity<ClientPayments>()
                .Property(e => e.client_type)
                .IsUnicode(false);

            modelBuilder.Entity<ClientProfile>()
                .Property(e => e.secondry_email)
                .IsUnicode(false);

            modelBuilder.Entity<ClientProfile>()
                .Property(e => e.office_phone)
                .IsUnicode(false);

            modelBuilder.Entity<ClientProfile>()
                .Property(e => e.home_phone)
                .IsUnicode(false);

            modelBuilder.Entity<ClientProfile>()
                .Property(e => e.address_line1)
                .IsUnicode(false);

            modelBuilder.Entity<ClientProfile>()
                .Property(e => e.address_line2)
                .IsUnicode(false);

            modelBuilder.Entity<ClientProfile>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<ClientProfile>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<ClientProfile>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<ClientProfile>()
                .Property(e => e.zip)
                .IsUnicode(false);

            modelBuilder.Entity<ClientProfile>()
                .Property(e => e.photo)
                .IsUnicode(false);

            modelBuilder.Entity<ClientProfile>()
                .Property(e => e.pledge)
                .IsUnicode(false);

            modelBuilder.Entity<ClientRemiders>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<ClientRemiders>()
                .Property(e => e.primary_email)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.primary_email)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.login_user_id)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.pdaccept)
                .IsUnicode(false);

            modelBuilder.Entity<Cms>()
                .Property(e => e.alias)
                .IsUnicode(false);

            modelBuilder.Entity<Cms>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<Cms>()
                .Property(e => e.tags)
                .IsUnicode(false);

            modelBuilder.Entity<Cms>()
                .Property(e => e.permalink)
                .IsUnicode(false);

            modelBuilder.Entity<Cms>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<Cms>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<Cms>()
                .Property(e => e.token)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.message)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.iso_code_2)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.iso_code_3)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.address_format)
                .IsUnicode(false);

            modelBuilder.Entity<Currency>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<Currency>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Currency>()
                .Property(e => e.symbol)
                .IsUnicode(false);

            modelBuilder.Entity<Dashboard>()
                .Property(e => e.subject)
                .IsUnicode(false);

            modelBuilder.Entity<Dashboard>()
                .Property(e => e.subject2)
                .IsUnicode(false);

            modelBuilder.Entity<Dashboard>()
                .Property(e => e.percentage)
                .IsUnicode(false);

            modelBuilder.Entity<Document>()
                .Property(e => e.document1)
                .IsUnicode(false);

            modelBuilder.Entity<EmailTemplates>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<EmailTemplates>()
                .Property(e => e.subject)
                .IsUnicode(false);

            modelBuilder.Entity<EmailTemplates>()
                .Property(e => e.details)
                .IsUnicode(false);

            modelBuilder.Entity<Feature>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Fee>()
                .Property(e => e.admin_percent)
                .IsUnicode(false);

            modelBuilder.Entity<ForgotPassRequest>()
                .Property(e => e.login_id)
                .IsUnicode(false);

            modelBuilder.Entity<ForgotPassRequest>()
                .Property(e => e.request_ip)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralSetting>()
                .Property(e => e.module)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralSetting>()
                .Property(e => e.alias)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralSetting>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<GeneralSetting>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<Group>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<InviteFriends>()
                .Property(e => e.email1)
                .IsUnicode(false);

            modelBuilder.Entity<InviteFriends>()
                .Property(e => e.email2)
                .IsUnicode(false);

            modelBuilder.Entity<InviteFriends>()
                .Property(e => e.email3)
                .IsUnicode(false);

            modelBuilder.Entity<InviteFriends>()
                .Property(e => e.email4)
                .IsUnicode(false);

            modelBuilder.Entity<InviteFriends>()
                .Property(e => e.email5)
                .IsUnicode(false);

            modelBuilder.Entity<InviteFriends>()
                .Property(e => e.message)
                .IsUnicode(false);

            modelBuilder.Entity<Module>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<PasswordRecoveries>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<PasswordRecoveries>()
                .Property(e => e.authentication_code)
                .IsUnicode(false);

            modelBuilder.Entity<PasswordRecoveries>()
                .Property(e => e.ip)
                .IsUnicode(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.payment_status)
                .IsUnicode(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.currency)
                .IsUnicode(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.payer_email)
                .IsUnicode(false);

            modelBuilder.Entity<PhoneCodes>()
                .Property(e => e.iso)
                .IsUnicode(false);

            modelBuilder.Entity<PhoneCodes>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<PhoneCodes>()
                .Property(e => e.nicename)
                .IsUnicode(false);

            modelBuilder.Entity<PhoneCodes>()
                .Property(e => e.iso3)
                .IsUnicode(false);

            modelBuilder.Entity<Plan>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Plan>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<SMTPDetail>()
                .Property(e => e.port_no)
                .IsUnicode(false);

            modelBuilder.Entity<SMTPDetail>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<SMTPDetail>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<SMTPDetail>()
                .Property(e => e.host)
                .IsUnicode(false);

            modelBuilder.Entity<SMTPDetail>()
                .Property(e => e.server_adderss)
                .IsUnicode(false);

            modelBuilder.Entity<SMTP>()
                .Property(e => e.smtp_host)
                .IsUnicode(false);

            modelBuilder.Entity<SMTP>()
                .Property(e => e.smtp_user)
                .IsUnicode(false);

            modelBuilder.Entity<SMTP>()
                .Property(e => e.smtp_password)
                .IsUnicode(false);

            modelBuilder.Entity<SMTP>()
                .Property(e => e.smtp_port)
                .IsUnicode(false);

            modelBuilder.Entity<SMTP>()
                .Property(e => e.smtp_name)
                .IsUnicode(false);

            modelBuilder.Entity<SMTP>()
                .Property(e => e.smtp_reply)
                .IsUnicode(false);

            modelBuilder.Entity<SMTP>()
                .Property(e => e.smtp_bounce)
                .IsUnicode(false);

            modelBuilder.Entity<SponsorPaymentHistory>()
                .Property(e => e.transaction_id)
                .IsUnicode(false);

            modelBuilder.Entity<Sponsor>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<Sponsor>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<Sponsor>()
                .Property(e => e.address_line1)
                .IsUnicode(false);

            modelBuilder.Entity<Sponsor>()
                .Property(e => e.address_line2)
                .IsUnicode(false);

            modelBuilder.Entity<Sponsor>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<Sponsor>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<Sponsor>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<Sponsor>()
                .Property(e => e.zip)
                .IsUnicode(false);

            modelBuilder.Entity<Sponsor>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<Sponsor>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Sponsor>()
                .Property(e => e.amount_word)
                .IsUnicode(false);

            modelBuilder.Entity<Sponsor>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Sponsorship>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Sponsorship>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<Sponsorship>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<State>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Story>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<Story>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<Story>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<StudentHistory>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<StudentHistory>()
                .Property(e => e.desc)
                .IsUnicode(false);

            modelBuilder.Entity<StudentImage>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<StudentPaymentDetails>()
                .Property(e => e.payment_mode)
                .IsUnicode(false);

            modelBuilder.Entity<StudentPaymentDetails>()
                .Property(e => e.currency)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.address_line1)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.zip)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.middle_name)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.father_middle_name)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.mother_middle_name)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.father_first_name)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.father_last_name)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.mother_first_name)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.mother_last_name)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.phone1)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.phone2)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.family_history)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.religion)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.post_office)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.police_station)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.tehsil)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.village)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.district)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.address_line2)
                .IsUnicode(false);

            modelBuilder.Entity<Subscription>()
                .Property(e => e.pack_name)
                .IsUnicode(false);

            modelBuilder.Entity<Subscription>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<UserActions>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Volunteer>()
                .Property(e => e.subject)
                .IsUnicode(false);

            modelBuilder.Entity<Volunteer>()
                .Property(e => e.message)
                .IsUnicode(false);

            modelBuilder.Entity<Volunteer>()
                .Property(e => e.ip)
                .IsUnicode(false);

            modelBuilder.Entity<YouTubeVideos>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<YouTubeVideos>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<YouTubeVideos>()
                .Property(e => e.link)
                .IsUnicode(false);

            modelBuilder.Entity<YouTubeVideos>()
                .Property(e => e.show_on_home)
                .IsUnicode(false);
        }
    }
}
