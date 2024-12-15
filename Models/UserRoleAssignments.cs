namespace IdentityX.Models
{
    public class UserRoleAssignments
    {
        public long UserRoleId { get; set; }
        public DateTime AssignedAt { get; set; }
        public long UserId { get; set; }
        public User User { get; set; } 
        public long RoleId { get; set; }
        public UserRoles Roles { get; set; } 
    }
}