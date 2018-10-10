using ENG.Lily.Domain.Repositories;
using ENG.Lily.Infaestructure.Repository;
using ENG.Lily.Infrastructure.Repository.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ENG.Lily.Infraestructure.DependecyInjection
{
    public static class Repository
    {
        public static void Setup(IServiceCollection services)
        {
            services.AddScoped(serviceProvider => new DatabaseContext());

            services.AddTransient<IDeveloperRepository, DeveloperRepository>();
        }
    }
}
