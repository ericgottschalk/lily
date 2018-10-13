using ENG.Lily.Domain.Entities;
using ENG.Lily.Domain.Entities.ManyToMany;
using ENG.Lily.Infraestructure.Runtime;
using ENG.Lily.Infrastructure.Repository.Extensions;
using ENG.Lily.Infrastructure.Repository.Mapping;
using Microsoft.EntityFrameworkCore;

namespace ENG.Lily.Infaestructure.Repository
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() 
        {
            this.DisableAutoDetectChanges();
        }

        protected void EnableAutoDetectChanges() => this.ChangeTracker.AutoDetectChangesEnabled = true;

        protected void DisableAutoDetectChanges() => this.ChangeTracker.AutoDetectChangesEnabled = false;

        public override int SaveChanges()
        {
            this.EnableAutoDetectChanges();
            var result = base.SaveChanges();
            this.DisableAutoDetectChanges();

            return result;
        }

        public DbSet<Developer> Developers { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Fund> Funds { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameGenre> Genres { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<PlatformProject> PlatformsProjects { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(RuntimeContext.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.RemovePluralizingTableNameConvention();

            modelBuilder.ApplyConfiguration(new DeveloperConfiguration());
            modelBuilder.ApplyConfiguration(new FeedbackConfiguration());
            modelBuilder.ApplyConfiguration(new FundConfiguration());
            modelBuilder.ApplyConfiguration(new GameConfiguration());
            modelBuilder.ApplyConfiguration(new GameGenreConfiguration());
            modelBuilder.ApplyConfiguration(new MediaConfiguration());
            modelBuilder.ApplyConfiguration(new PlatformConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new PublisherConfiguration());      

            base.OnModelCreating(modelBuilder);
        }
    }
}
