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
            
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IProjectRepository, ProjectRepository>();
            services.AddTransient<IPlatformRepository, PlatformRepository>();
            services.AddTransient<IGameGenreRepository, GameGenreRepository>();
            services.AddTransient<IPlatformProjectRepository, PlatformProjectRepository>();
            services.AddTransient<IFundRepository, FundRepository>();
            services.AddTransient<IFeedbackRepository, FeedbackRepository>();
        }
    }
}
