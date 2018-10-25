using ENG.Lily.Domain.Entities;
using ENG.Lily.Domain.Repositories;
using ENG.Lily.Infrastructure.Security;
using ENG.Lily.Service.Contracts;
using System;

namespace ENG.Lily.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void Save(User user)
        {
            if (user.IsNew())
            {
                user.Password = Encryption.Encrypt(user.Password);
                user.DateCreate = DateTime.Now;
                this.userRepository.Add(user);
                return;
            }

            var dbUser = this.Get(user.Id);

            dbUser.FirstName = user.FirstName;
            dbUser.LastName = user.LastName;
            dbUser.Phrase = user.Phrase;
            dbUser.ProfilePictureUrl = user.ProfilePictureUrl;
            dbUser.WebSite = user.WebSite;
            dbUser.City = user.City;
            dbUser.Country = user.Country;

            this.userRepository.Update(dbUser);
        }

        public User Login(string username, string password)
        {
            var user = this.userRepository.Get(t => t.Username == username);

            if (user != null)
            {
                var encryptedPassword = Encryption.Encrypt(password);

                return user.Password == encryptedPassword ? user : null;
            }

            return null;
        }

        public User Get(int id)
        {
            var user = this.userRepository.Get(id, t => t.Projects);

            user.Password = string.Empty;
            user.Email = string.Empty;

            return user;
        }

        public User Get(string username)
        {
            var user = this.userRepository.Get(t => t.Username == username, t => t.Projects);

            user.Password = string.Empty;
            user.Email = string.Empty;

            return user;
        }

        public void SaveProfilePictureUrl(int idUser, string profilePictureUrl)
        {
            var dbUser = this.Get(idUser);

            dbUser.ProfilePictureUrl = profilePictureUrl;


            this.userRepository.Update(dbUser);
        }
    }
}
