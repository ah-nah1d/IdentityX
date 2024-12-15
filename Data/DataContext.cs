
using IdentityX.Models;
using Microsoft.EntityFrameworkCore;

namespace IdentityX.Data
{
     public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<UserSessions> UserSessions { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<UserRoleAssignments> UserRoleAssignments { get; set; }
        public DbSet<UserConfirmationTokens> UserConfirmationTokens { get; set; }
        public DbSet<UserActivityLogs> UserActivityLogs { get; set; }
        public DbSet<BackupCodes> BackupCodes { get; set; }
        public DbSet<UserProfileSettings> UserProfileSettings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<BackupCodes>()
                .HasKey(bc => bc.CodeId);
            modelBuilder.Entity<UserActivityLogs>()
                .HasKey(ual => ual.LogId);
            modelBuilder.Entity<UserConfirmationTokens>()
                .HasKey(uct => uct.TokenId);
            modelBuilder.Entity<UserProfileSettings>()
                .HasKey(ups => ups.SettingsId);
            modelBuilder.Entity<UserRoleAssignments>()
                .HasKey(ura => ura.UserRoleId);
            modelBuilder.Entity<UserRoles>()
                .HasKey(ur => ur.RoleId);
            modelBuilder.Entity<UserSessions>()
                .HasKey(us => us.SessionId);
        }

    }
}