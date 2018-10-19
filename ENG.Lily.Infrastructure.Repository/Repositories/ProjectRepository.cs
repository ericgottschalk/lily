using ENG.Lily.Domain.Entities;
using ENG.Lily.Domain.Repositories;
using ENG.Lily.Infaestructure.Repository;
using ENG.Lily.Infaestructure.Repository.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

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

        public List<Project> FindWithPlatforms(Expression<Func<Project, bool>> expression)
        {
            return this.Set.Include(t => t.Platforms).ThenInclude(t => t.Platform).Where(expression).ToList();
        }

        public List<Project> FindWithPlatforms(Expression<Func<Project, bool>> expression, params Expression<Func<Project, object>>[] includePaths)
        {
            var set = this.IncludeSetWithPlatform(includePaths);

            return set.Where(expression).AsNoTracking().ToList();
        }

        public List<Project> FindWithPlatforms(Expression<Func<Project, bool>> expression, int page, int pageSize, params Expression<Func<Project, object>>[] includePaths)
        {
            var set = this.IncludeSetWithPlatform(includePaths);

            return set.Where(expression).AsNoTracking().Skip(page * pageSize).Take(pageSize).ToList();
        }

        public List<Project> FindWithPlatforms(params Expression<Func<Project, object>>[] includePaths)
        {
            var set = this.IncludeSetWithPlatform(includePaths);

            return set.AsNoTracking().ToList();
        }

        public List<Project> FindWithPlatforms(int page, int pageSize, params Expression<Func<Project, object>>[] includePaths)
        {
            var set = this.IncludeSetWithPlatform(includePaths);

            return set.AsNoTracking().Skip(page * pageSize).Take(pageSize).ToList();
        }

        private IQueryable<Project> IncludeSetWithPlatform(params Expression<Func<Project, object>>[] includePaths)
        {
            var set = this.Set.Include(t => t.Platforms).ThenInclude(t => t.Platform).AsQueryable();

            foreach (var include in includePaths)
            {
                set = set.Include(include);
            }

            return set;
        }
    }
}
