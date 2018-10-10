using AutoMapper;
using ENG.Lily.Application.Mapping.Model;
using ENG.Lily.Domain.Entities;

namespace ENG.Lily.Application.Mapping.Profiles
{
    public class GameProfile : Profile
    {
        public GameProfile()
        {
            this.CreateMap<Game, GameModel>();
            this.CreateMap<GameModel, Game>();
        }
    }
}
