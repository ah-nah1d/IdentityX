using IdentityX.Models;

namespace IdentityX.Interfaces
{
    public interface IUserRepository
    {
        Task AddUserAsync(User user);
    }
}