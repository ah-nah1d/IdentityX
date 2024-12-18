using AutoMapper;
using IdentityX.Dto;
using IdentityX.Interfaces;
using IdentityX.Models;
using Microsoft.AspNetCore.Identity;

namespace IdentityX.Services
{
    public class UserService:IUserService
    {
        private readonly PasswordHasher<User>_passwordHasher;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;


        public UserService(
            IUserRepository userRepository,
            PasswordHasher<User> passwordHasher,
            IMapper mapper
        ){
            _userRepository = userRepository;
            _passwordHasher=passwordHasher;
            _mapper = mapper;
        }
        public async Task RegisterUserAsync(RegisterUserDto registerUserDto){
            var hashedPassword = _passwordHasher.HashPassword(new User(),registerUserDto.Password);
            var user = _mapper.Map<User>(registerUserDto);
            user.PasswordHash = hashedPassword;
            await _userRepository.AddUserAsync(user);
        }
    }
}