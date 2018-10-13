using AutoMapper;
using ENG.Lily.Application.Mapping.Model;
using ENG.Lily.Domain.Entities;

namespace ENG.Lily.Application.Mapping.Profiles
{
    internal class GameGenreProfile : Profile
    {
        internal GameGenreProfile()
        {
            this.CreateMap<GameGenre, GameGenreModel>();
            this.CreateMap<GameGenreModel, GameGenre>();
        }
    }
}
