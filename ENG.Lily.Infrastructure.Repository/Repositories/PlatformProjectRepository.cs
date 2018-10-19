using ENG.Lily.Domain.Entities.ManyToMany;
using ENG.Lily.Domain.Repositories;
using ENG.Lily.Infaestructure.Repository;
using ENG.Lily.Infaestructure.Repository.Repositories;

namespace ENG.Lily.Infrastructure.Repository.Repositories
{
    public class PlatformProjectRepository : Repository<PlatformProject>, IPlatformProjectRepository
    {
        public PlatformProjectRepository(DatabaseContext context) 
            : base(context)
        {
        }
    }
}
