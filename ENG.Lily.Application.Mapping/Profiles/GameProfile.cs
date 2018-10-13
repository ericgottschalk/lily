using AutoMapper;
using ENG.Lily.Application.Mapping.Model;
using ENG.Lily.Domain.Entities;

namespace ENG.Lily.Application.Mapping.Profiles
{
    internal class GameProfile : Profile
    {
        internal GameProfile()
        {
            this.CreateMap<Game, GameModel>();
            this.CreateMap<GameModel, Game>();
        }
    }
}
