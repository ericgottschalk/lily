using AutoMapper;
using ENG.Lily.Application.Mapping.Model;
using ENG.Lily.Domain.Entities;

namespace ENG.Lily.Application.Mapping.Profiles
{
    internal class PlatformProfile : Profile
    {
        internal PlatformProfile()
        {
            this.CreateMap<Platform, PlatformModel>();
            this.CreateMap<PlatformModel, Platform>();
        }
    }
}
