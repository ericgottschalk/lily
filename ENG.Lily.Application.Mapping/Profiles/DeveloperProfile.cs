using AutoMapper;
using ENG.Lily.Application.Mapping.Model;
using ENG.Lily.Domain.Entities;

namespace ENG.Lily.Application.Mapping.Profiles
{
    internal class DeveloperProfile : Profile
    {
        internal DeveloperProfile()
        {
            this.CreateMap<Developer, DeveloperModel>();
            this.CreateMap<DeveloperModel, Developer>();
        }
    }
}
