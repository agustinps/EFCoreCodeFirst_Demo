using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappers
{
    public class UserMapperProfile : Profile
    {
        public UserMapperProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserCreateDto>().ReverseMap();
        }
    }
}
