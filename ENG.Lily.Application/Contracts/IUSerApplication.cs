﻿using ENG.Lily.Application.Mapping.Model;

namespace ENG.Lily.Application.Contracts
{
    public interface IUserApplication
    {
        void Save(UserModel model);

        UserModel Login(LoginModel model);

        UserModel Get(int id);

        UserModel Get(string username);

        void SaveProfilePictureUrl(int idUser, string profilePictureUrl);
    }
}
