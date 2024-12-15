namespace IdentityX.Models
{
    public class BackupCodes
    {
        public long CodeId { get; set; }
        public string BackupCode { get; set; }
        public DateTime UsedAt { get; set; }
        public DateTime CreatedAt { get; set; }

        
        public long UserId { get; set; }
        public User User { get; set; } 
    }
}