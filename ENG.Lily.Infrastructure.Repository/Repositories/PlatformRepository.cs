using ENG.Lily.Domain.Entities;
using ENG.Lily.Domain.Repositories;
using ENG.Lily.Infaestructure.Repository;
using ENG.Lily.Infaestructure.Repository.Repositories;

namespace ENG.Lily.Infrastructure.Repository.Repositories
{
    public class PlatformRepository : Repository<Platform>, IPlatformRepository
    {
        public PlatformRepository(DatabaseContext context) 
            : base(context)
        {
        }
    }
}
