using ENG.Lily.Domain.Entities;

namespace ENG.Lily.Service.Contracts
{
    public interface IUserService
    {
        void Save(User user);

        User Login(string username, string Password);
    }
}
