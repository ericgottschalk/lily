using ENG.Lily.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ENG.Lily.Infaestructure.Repository.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly DatabaseContext context;

        protected DbSet<T> Set => this.context.Set<T>();

        public Repository(DatabaseContext context)
        {
            this.context = context;
        }

        public void Add(T entity)
        {
            this.Set.Add(entity);
            this.context.SaveChanges();
        }

        public bool Any()
        {
            return this.Set.Any();
        }

        public bool Any(Expression<Func<T, bool>> expression)
        {
            return this.Set.Any(expression);
        }

        public List<T> Find()
        {
            return this.Set.AsNoTracking().ToList();
        }

        public List<T> Find(Expression<Func<T, bool>> expression)
        {
            return this.Set.Where(expression).AsNoTracking().ToList();
        }

        public List<T> Find<TProp>(Expression<Func<T, bool>> expression, params Expression<Func<T, TProp>>[] includePaths)
        {
            var set = this.Set;

            foreach (var include in includePaths)
            {
                set.Include(include);
            }

            return set.Where(expression).AsNoTracking().ToList();
        }

        public T Get(int id)
        {
            return this.Set.FirstOrDefault(t => t.Id == id);
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            return this.Set.FirstOrDefault(expression);
        }

        public T Get<TProp>(Expression<Func<T, bool>> expression, params Expression<Func<T, TProp>>[] includePaths)
        {
            var set = this.Set;

            foreach (var include in includePaths)
            {
                set.Include(include);
            }

            return set.FirstOrDefault(expression);
        }

        public void Update(T entity)
        {
            this.context.Update<T>(entity);
        } 
    }
}
