using ENG.Lily.Infraestructure.Runtime;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(RuntimeContext.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
