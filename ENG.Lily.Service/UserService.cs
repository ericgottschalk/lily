using ENG.Lily.Domain.Entities;
using ENG.Lily.Domain.Repositories;
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
                this.userRepository.Add(user);
                return;
            }

            this.userRepository.Update(user);
        }

        public User Login(string username, string Password)
        {
            var user = this.userRepository.Get(t => t.Username == username);

            if (user != null)
            {

            }

            return null;
        }
    }
}
