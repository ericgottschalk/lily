using AutoMapper;
using ENG.Lily.Application.Mapping.Profiles;
using Microsoft.Extensions.DependencyInjection;

namespace ENG.Lily.Application.Mapping
{
    public static class MappingConfiguration
    {
        public static void Setup(IServiceCollection services)
        {
            var profiles = new MapperConfiguration(config =>
            {
                config.AddProfile(new UserProfile());
                config.AddProfile(new FeedbackProfile());
                config.AddProfile(new GameGenreProfile());
                config.AddProfile(new MediaProfile());
                config.AddProfile(new PlatformProfile());
                config.AddProfile(new ProjectProfile());
                config.AddProfile(new PlatformProjectModelProfile());
                config.AddProfile(new ContribuitionProfile());
            });

            var mapper = profiles.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
