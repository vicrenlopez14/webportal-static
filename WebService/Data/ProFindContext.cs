using Microsoft.EntityFrameworkCore;
using WebService.Models.Generated;

namespace WebService.Data
{
    public partial class ProFindContext : DbContext
    {
        public ProFindContext()
        {
        }

        public ProFindContext(DbContextOptions<ProFindContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Activity> Activities { get; set; } = null!;
        public virtual DbSet<Activitycomment> Activitycomments { get; set; } = null!;
        public virtual DbSet<Admin> Admins { get; set; } = null!;
        public virtual DbSet<Changepasswordcode> Changepasswordcodes { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Message> Messages { get; set; } = null!;
        public virtual DbSet<Notification> Notifications { get; set; } = null!;
        public virtual DbSet<Profession> Professions { get; set; } = null!;
        public virtual DbSet<Professional> Professionals { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<Projectpay> Projectpays { get; set; } = null!;
        public virtual DbSet<Projectpaytemplate> Projectpaytemplates { get; set; } = null!;
        public virtual DbSet<Projectstatus> Projectstatuses { get; set; } = null!;
        public virtual DbSet<Projecttemplate> Projecttemplates { get; set; } = null!;
        public virtual DbSet<Proposal> Proposals { get; set; } = null!;
        public virtual DbSet<Proposalnotification> Proposalnotifications { get; set; } = null!;
        public virtual DbSet<Rank> Ranks { get; set; } = null!;
        public virtual DbSet<Securityansweradmin> Securityansweradmins { get; set; } = null!;
        public virtual DbSet<Securityanswerclient> Securityanswerclients { get; set; } = null!;
        public virtual DbSet<Securityanswerprofessional> Securityanswerprofessionals { get; set; } = null!;
        public virtual DbSet<Securityquestion> Securityquestions { get; set; } = null!;
        public virtual DbSet<Supportticket> Supporttickets { get; set; } = null!;
        public virtual DbSet<Tag> Tags { get; set; } = null!;
        public virtual DbSet<Tagtemplate> Tagtemplates { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;user=root;database=ProFind", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.27-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Activity>(entity =>
            {
                entity.HasKey(e => e.IdA)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdA).IsFixedLength();

                entity.Property(e => e.IdPj1).IsFixedLength();

                entity.Property(e => e.IdT1).IsFixedLength();
            });

            modelBuilder.Entity<Activitycomment>(entity =>
            {
                entity.HasKey(e => e.IdAc)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdAc).IsFixedLength();

                entity.Property(e => e.IdA1).IsFixedLength();

                entity.Property(e => e.IdC5).IsFixedLength();

                entity.Property(e => e.IdP5).IsFixedLength();
            });

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => e.IdA)
                    .HasName("PRIMARY");

                entity.HasIndex(e => new { e.NameA, e.EmailA, e.TelA }, "NameA")
                    .HasAnnotation("MySql:FullTextIndex", true);

                entity.Property(e => e.IdA).IsFixedLength();

                entity.Property(e => e.IdR1).IsFixedLength();

                entity.Property(e => e.PasswordA).IsFixedLength();
            });

            modelBuilder.Entity<Changepasswordcode>(entity =>
            {
                entity.HasKey(e => e.IdCpc)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdCpc).IsFixedLength();

                entity.Property(e => e.CodeCpc).IsFixedLength();

                entity.Property(e => e.IdC1).IsFixedLength();
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdC)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdC).IsFixedLength();

                entity.Property(e => e.PasswordC).IsFixedLength();
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.IdDp)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.HasKey(e => e.IdM)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdM).IsFixedLength();

                entity.Property(e => e.IdC4).IsFixedLength();

                entity.Property(e => e.IdP4).IsFixedLength();
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.HasKey(e => e.IdN)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdN).IsFixedLength();

                entity.Property(e => e.IdPj2).IsFixedLength();
            });

            modelBuilder.Entity<Profession>(entity =>
            {
                entity.HasKey(e => e.IdPfs)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<Professional>(entity =>
            {
                entity.HasKey(e => e.IdP)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdP).IsFixedLength();

                entity.Property(e => e.EmailP).IsFixedLength();

                entity.Property(e => e.NameP).IsFixedLength();

                entity.Property(e => e.PasswordP).IsFixedLength();
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.IdPj)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdPj).IsFixedLength();

                entity.Property(e => e.IdC1).IsFixedLength();

                entity.Property(e => e.IdP1).IsFixedLength();
            });

            modelBuilder.Entity<Projectpay>(entity =>
            {
                entity.HasKey(e => e.IdPpy)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdPpy).IsFixedLength();

                entity.Property(e => e.IdC3).IsFixedLength();

                entity.Property(e => e.IdP3).IsFixedLength();

                entity.Property(e => e.IdPj3).IsFixedLength();
            });

            modelBuilder.Entity<Projectpaytemplate>(entity =>
            {
                entity.HasKey(e => e.IdPpt)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdPpt).IsFixedLength();

                entity.Property(e => e.IdPt1).IsFixedLength();
            });

            modelBuilder.Entity<Projectstatus>(entity =>
            {
                entity.HasKey(e => e.IdPs)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdPs).IsFixedLength();

                entity.Property(e => e.IdPj3).IsFixedLength();
            });

            modelBuilder.Entity<Projecttemplate>(entity =>
            {
                entity.HasKey(e => e.IdPt)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdPt).IsFixedLength();

                entity.Property(e => e.IdP1).IsFixedLength();
            });

            modelBuilder.Entity<Proposal>(entity =>
            {
                entity.HasKey(e => e.IdPp)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdPp).IsFixedLength();

                entity.Property(e => e.IdC3).IsFixedLength();

                entity.Property(e => e.IdP3).IsFixedLength();
            });

            modelBuilder.Entity<Proposalnotification>(entity =>
            {
                entity.HasKey(e => e.IdPn)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdPn).IsFixedLength();

                entity.Property(e => e.IdC4).IsFixedLength();

                entity.Property(e => e.IdP4).IsFixedLength();

                entity.Property(e => e.IdPp1).IsFixedLength();
            });

            modelBuilder.Entity<Rank>(entity =>
            {
                entity.HasKey(e => e.IdR)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<Securityansweradmin>(entity =>
            {
                entity.HasKey(e => e.IdSa)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdSa).IsFixedLength();

                entity.Property(e => e.IdA1).IsFixedLength();

                entity.Property(e => e.IdSq1).IsFixedLength();
            });

            modelBuilder.Entity<Securityanswerclient>(entity =>
            {
                entity.HasKey(e => e.IdSa)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdSa).IsFixedLength();

                entity.Property(e => e.IdC1).IsFixedLength();

                entity.Property(e => e.IdSq1).IsFixedLength();
            });

            modelBuilder.Entity<Securityanswerprofessional>(entity =>
            {
                entity.HasKey(e => e.IdSa)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdSa).IsFixedLength();

                entity.Property(e => e.IdP1).IsFixedLength();

                entity.Property(e => e.IdSq1).IsFixedLength();
            });

            modelBuilder.Entity<Securityquestion>(entity =>
            {
                entity.HasKey(e => e.IdSq)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdSq).IsFixedLength();
            });

            modelBuilder.Entity<Supportticket>(entity =>
            {
                entity.HasKey(e => e.IdSt)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdSt).IsFixedLength();

                entity.Property(e => e.IdA2).IsFixedLength();

                entity.Property(e => e.IdAct1).IsFixedLength();

                entity.Property(e => e.IdC5).IsFixedLength();

                entity.Property(e => e.IdP5).IsFixedLength();

                entity.Property(e => e.IdPj4).IsFixedLength();

                entity.Property(e => e.IdPp2).IsFixedLength();

                entity.Property(e => e.IdPpy1).IsFixedLength();
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.HasKey(e => e.IdT)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdT).IsFixedLength();

                entity.Property(e => e.ColorT).IsFixedLength();

                entity.Property(e => e.IdPj1).IsFixedLength();
            });

            modelBuilder.Entity<Tagtemplate>(entity =>
            {
                entity.HasKey(e => e.IdTt)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdTt).IsFixedLength();

                entity.Property(e => e.ColorTt).IsFixedLength();

                entity.Property(e => e.IdPt1).IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
