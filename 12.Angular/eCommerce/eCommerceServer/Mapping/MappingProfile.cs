using AutoMapper;
using eCommerceServer.DTOs;
using eCommerceServer.Models;

namespace eCommerceServer.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<RegisterDto, AppUser>();
    }
}
