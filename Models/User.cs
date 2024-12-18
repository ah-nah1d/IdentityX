namespace IdentityX.Models
{
    public class User
    {
        public long UserId { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Name { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsEmailVerified { get; set; }   
        public bool IsTwoFactorEnabled { get; set; }
        public string? TwoFactorSecret { get; set; }

        public ICollection<UserConfirmationTokens> UserConfirmationTokens { get; set; }
        public ICollection<UserSessions> UserSessions { get; set; }
        public ICollection<UserRoleAssignments> UserRoleAssignments { get; set; }
        public ICollection<UserProfileSettings> UserProfileSettings { get; set; }
        public ICollection<BackupCodes> BackupCodes { get; set; }
    }
}