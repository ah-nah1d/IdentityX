namespace IdentityX.Models
{
    public class UserSessions
    {
        public long SessionId { get; set; }
        public string DeviceInfo { get; set; }
        public string IpAddress { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime LastActiveTime { get; set; }
        public bool IsActive { get; set; }

        
        public long UserId { get; set; }
        public User user { get; set; }
    }
}