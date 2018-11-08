using ENG.Lily.Application.Mapping.Model;
using System.Collections.Generic;

namespace ENG.Lily.Application.Contracts
{
    public interface IUserApplication
    {
        void Save(UserModel model);

        UserModel Login(LoginModel model);

        UserModel Get(int id);

        UserModel Get(string username);

        void SaveProfilePictureUrl(int idUser, string profilePictureUrl);

        List<UserModel> GetTopUsers();
    }
}
