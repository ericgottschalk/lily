using AutoMapper;
using ENG.Lily.Application.Mapping.Model;
using ENG.Lily.Domain.Entities;

namespace ENG.Lily.Application.Mapping.Profiles
{
    internal class PublisherProfile : Profile
    {
        internal PublisherProfile()
        {
            this.CreateMap<Publisher, PublisherModel>();
            this.CreateMap<PublisherModel, Publisher>();
        }
    }
}
