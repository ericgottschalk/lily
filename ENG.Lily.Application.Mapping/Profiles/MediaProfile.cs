using AutoMapper;
using ENG.Lily.Application.Mapping.Model;
using ENG.Lily.Domain.Entities;

namespace ENG.Lily.Application.Mapping.Profiles
{
    public class MediaProfile : Profile
    {
        public MediaProfile()
        {
            this.CreateMap<Media, MediaModel>();
            this.CreateMap<MediaModel, Media>();
        }
    }
}
