using ENG.Lily.Domain.Common;
using ENG.Lily.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ENG.Lily.Domain.Repositories
{
    public interface IProjectRepository : IRepository<Project>
    {
        List<Project> FindTopOrderedByDate(int top);

        List<Project> FindWithPlatforms(Expression<Func<Project, bool>> expression);

        List<Project> FindWithPlatforms(Expression<Func<Project, bool>> expression, params Expression<Func<Project, object>>[] includePaths);

        List<Project> FindWithPlatforms(Expression<Func<Project, bool>> expression, int page, int pageSize, params Expression<Func<Project, object>>[] includePaths);
    }
}
