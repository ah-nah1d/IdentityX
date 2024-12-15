using System.ComponentModel.DataAnnotations;

namespace IdentityX.Models
{
    public class UserActivityLogs
    {
        [Key]
        public long LogId { get; set; }
        public long UserId { get; set; }
        public string Action { get; set; }
        public string IpAddress { get; set; }
        public string DeviceInfo { get; set; }
        public DateTime Timestamp { get; set; }
    }
}