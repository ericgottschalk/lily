using ENG.Lily.Domain.Entities;

namespace ENG.Lily.Service.Contracts
{
    public interface IUserService
    {
        void Save(User user);

        User Login(string username, string Password);

        User Get(int id);

        User Get(string username);
        void SaveProfilePictureUrl(int idUser, string profilePictureUrl);
    }
}
