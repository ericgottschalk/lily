using AutoMapper;
using ENG.Lily.Application.Mapping.Model;
using ENG.Lily.Domain.Entities;

namespace ENG.Lily.Application.Mapping.Profiles
{
    internal class ContribuitionProfile : Profile
    {
        internal ContribuitionProfile()
        {
            this.CreateMap<Contribuition, ContribuitionModel>();
            this.CreateMap<ContribuitionModel, Contribuition>();
        }
    }
}

