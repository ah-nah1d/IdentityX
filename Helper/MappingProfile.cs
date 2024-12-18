using AutoMapper;
using IdentityX.Dto;
using IdentityX.Models;
namespace IdentityX.Helper
{
    public class MappingProfile:Profile
    {
        public MappingProfile(){
            CreateMap<RegisterUserDto,User>()
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => DateTime.UtcNow))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => DateTime.UtcNow))
                .ForMember(dest => dest.IsEmailVerified, opt => opt.MapFrom(src => false))
                .ForMember(dest => dest.IsTwoFactorEnabled, opt => opt.MapFrom(src => false));
        }
    }
}