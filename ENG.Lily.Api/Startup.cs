using ENG.Lily.Application.Mapping;
using ENG.Lily.Infaestructure.Repository;
using ENG.Lily.Infraestructure.Runtime;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DependecyInjection = ENG.Lily.Infraestructure.DependecyInjection;

namespace ENG.Lily.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<GzipCompressionProviderOptions>(options => options.Level = System.IO.Compression.CompressionLevel.Optimal);
            services.AddResponseCompression();

            services.AddCors();

            MappingConfiguration.Setup(services);
            DependecyInjection.Service.Setup(services);
            DependecyInjection.Application.Setup(services);
            DependecyInjection.Repository.Setup(services);

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            RuntimeContext.ConnectionString = Configuration.GetConnectionString("ConnectionString");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseResponseCompression();

            app.UseCors(cors =>
            {
                cors.AllowAnyHeader();
                cors.AllowAnyMethod();
                cors.AllowAnyOrigin();
            });

            app.UseMvc();

            SetupDatabase(app);
        }

        private void SetupDatabase(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                using (var dataContext = serviceScope.ServiceProvider.GetService<DatabaseContext>())
                {
                    dataContext.Database.Migrate();
                }
            }
        }
    }
}
