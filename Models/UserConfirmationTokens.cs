namespace IdentityX.Models
{
    public class UserConfirmationTokens
    {
        public long TokenId { get; set; }
        public string TokenValue { get; set; }
        public string TokenType { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsUsed { get; set; }

        
        public long UserId { get; set; }
        public User User { get; set; } 
    }
}