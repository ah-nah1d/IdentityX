using System.ComponentModel.DataAnnotations;

namespace IdentityX.Models
{
    public class UserRoles
    {
        [Key]
        public long RoleId { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }   
        public ICollection<UserRoleAssignments> UserRoleAssignments { get; set; }
    }
}