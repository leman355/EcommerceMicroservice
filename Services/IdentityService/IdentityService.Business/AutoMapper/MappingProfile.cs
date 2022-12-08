using AutoMapper;
using CorePackage.Entities.Concrete;
using static IdentityService.Entities.DTOs.UserDTO;

namespace IdentityService.Business.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterDTO, User>();
            CreateMap<User, RegisterDTO>();

            CreateMap<UserByEmailDTO, User>();
            CreateMap<User, UserByEmailDTO>();

        }
    }
}