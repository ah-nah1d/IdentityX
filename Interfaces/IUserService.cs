using IdentityX.Dto;

namespace IdentityX.Interfaces
{
    public interface IUserService
    {
        Task RegisterUserAsync(RegisterUserDto registerUserDto);
    }
}