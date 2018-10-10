using AutoMapper;
using ENG.Lily.Application.Mapping.Model;
using ENG.Lily.Domain.Entities;

namespace ENG.Lily.Application.Mapping.Profiles
{
    public class PublisherProfile : Profile
    {
        public PublisherProfile()
        {
            this.CreateMap<Publisher, PublisherModel>();
            this.CreateMap<PublisherModel, Publisher>();
        }
    }
}
