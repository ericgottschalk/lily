using ENG.Lily.Service;
using ENG.Lily.Service.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace ENG.Lily.Infrastructure.DependencyInjection
{
    internal static class Service
    {
        internal static void Setup(IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IProjectService, ProjectService>();
        }
    }
}
