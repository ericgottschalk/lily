using AutoMapper;
using ENG.Lily.Application.Mapping.Model;
using ENG.Lily.Domain.Entities;

namespace ENG.Lily.Application.Mapping.Profiles
{
    internal class MediaProfile : Profile
    {
        internal MediaProfile()
        {
            this.CreateMap<Media, MediaModel>();
            this.CreateMap<MediaModel, Media>();
        }
    }
}
