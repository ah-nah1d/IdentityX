using IdentityX.Data;
using IdentityX.Interfaces;
using IdentityX.Models;
using Microsoft.EntityFrameworkCore;

namespace IdentityX.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;
        }
        public async Task AddUserAsync(User user)
        {
            if (await _context.Users.AnyAsync(u=>u.Email==user.Email)){
                throw new ArgumentException("Email is already in Use.");
            }
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }
    }
}