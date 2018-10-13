using ENG.Lily.Domain.Repositories;
using ENG.Lily.Infaestructure.Repository;
using ENG.Lily.Infrastructure.Repository.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ENG.Lily.Infrastructure.DependencyInjection
{
    internal static class Repository
    {
        internal static void Setup(IServiceCollection services)
        {
            services.AddScoped(serviceProvider => new DatabaseContext());

            services.AddTransient<IDeveloperRepository, DeveloperRepository>();
        }
    }
}
