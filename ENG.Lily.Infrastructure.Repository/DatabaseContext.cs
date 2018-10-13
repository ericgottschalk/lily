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

        public DbSet<User> Users { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Fund> Funds { get; set; }
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

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new FeedbackConfiguration());
            modelBuilder.ApplyConfiguration(new FundConfiguration());
            modelBuilder.ApplyConfiguration(new GameGenreConfiguration());
            modelBuilder.ApplyConfiguration(new MediaConfiguration());
            modelBuilder.ApplyConfiguration(new PlatformConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());    

            base.OnModelCreating(modelBuilder);
        }
    }
}
