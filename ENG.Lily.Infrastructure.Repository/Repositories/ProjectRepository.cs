using ENG.Lily.Domain.Entities;
using ENG.Lily.Domain.Repositories;
using ENG.Lily.Infaestructure.Repository;
using ENG.Lily.Infaestructure.Repository.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ENG.Lily.Infrastructure.Repository.Repositories
{
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        public ProjectRepository(DatabaseContext context) 
            : base(context)
        {
        }

        public List<Project> FindTopOrderedByDate(int top)
        {
            return this.Set.OrderBy(t => t.DateCreate).Take(top).ToList();
        }
    }
}
