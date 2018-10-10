using AutoMapper;
using ENG.Lily.Application.Mapping.Model;
using ENG.Lily.Domain.Entities;

namespace ENG.Lily.Application.Mapping.Profiles
{
    public class DeveloperProfile : Profile
    {
        public DeveloperProfile()
        {
            this.CreateMap<Developer, DeveloperModel>();
            this.CreateMap<DeveloperModel, Developer>();
        }
    }
}
