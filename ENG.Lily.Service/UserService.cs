using ENG.Lily.Domain.Entities;
using ENG.Lily.Domain.Repositories;
using ENG.Lily.Infrastructure.Security;
using ENG.Lily.Service.Contracts;

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
                this.userRepository.Add(user);
                return;
            }

            this.userRepository.Update(user);
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
            user.Cpf = string.Empty;
            user.Email = string.Empty;

            return user;
        }
    }
}
