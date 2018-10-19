using AutoMapper;
using ENG.Lily.Application.Mapping.Model;
using ENG.Lily.Domain.Entities.ManyToMany;

namespace ENG.Lily.Application.Mapping.Profiles
{
    internal class PlatformProjectModelProfile : Profile
    {
        internal PlatformProjectModelProfile()
        {
            this.CreateMap<PlatformProject, PlatformProjectModel>();
            this.CreateMap<PlatformProjectModel, PlatformProject>();
        }
    }
}
