using Microsoft.Extensions.DependencyInjection;

namespace ENG.Lily.Infrastructure.DependencyInjection
{
    public static class DependencyInjectionConfiguration
    {
        public static void Setup(IServiceCollection services)
        {
            Application.Setup(services);
            Repository.Setup(services);
            Service.Setup(services);
        }
    }
}
