using AutoMapper;
using ENG.Lily.Application.Mapping.Model;
using ENG.Lily.Domain.Entities;

namespace ENG.Lily.Application.Mapping.Profiles
{
    internal class UserProfile : Profile
    {
        internal UserProfile()
        {
            this.CreateMap<User, UserModel>();
            this.CreateMap<UserModel, User>();
        }
    }
}
