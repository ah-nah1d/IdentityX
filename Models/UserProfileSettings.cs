namespace IdentityX.Models
{
    public class UserProfileSettings
    {
        public long SettingsId { get; set; }
        public bool ShowPhoneNumber { get; set; }
        public bool ShowEmail { get; set; }
        public bool ShowProfilePicture { get; set; }
        public bool ReceiveEmailNotifications { get; set; }

        public long UserId { get; set; }
        public User User { get; set; } 

    }
}