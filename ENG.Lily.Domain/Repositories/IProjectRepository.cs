using ENG.Lily.Domain.Common;
using ENG.Lily.Domain.Entities;
using System.Collections.Generic;

namespace ENG.Lily.Domain.Repositories
{
    public interface IProjectRepository : IRepository<Project>
    {
        List<Project> FindTopOrderedByDate(int top);
    }
}
