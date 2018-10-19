using ENG.Lily.Application;
using ENG.Lily.Application.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace ENG.Lily.Infrastructure.DependencyInjection
{
    internal static class Application
    {
        internal static void Setup(IServiceCollection services)
        {
            services.AddTransient<IUserApplication, UserApplication>();
            services.AddTransient<IProjectApplication, ProjectApplication>();
        }
    }
}
