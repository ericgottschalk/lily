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
                config.AddProfile(new DeveloperProfile());
                config.AddProfile(new FeedbackProfile());
                config.AddProfile(new GameGenreProfile());
                config.AddProfile(new GameProfile());
                config.AddProfile(new MediaProfile());
                config.AddProfile(new PlatformProfile());
                config.AddProfile(new ProjectProfile());
                config.AddProfile(new PublisherProfile());
            });

            var mapper = profiles.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
