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

        public Repository(DatabaseContext context)
        {
            this.context = context;
        }

        public void Add(T entity)
        {
            this.context.Set<T>().Add(entity);
            this.context.SaveChanges();
        }

        public bool Any()
        {
            return this.context.Set<T>().Any();
        }

        public bool Any(Expression<Func<T, bool>> expression)
        {
            return this.context.Set<T>().Any(expression);
        }

        public List<T> Find()
        {
            return this.context.Set<T>().AsNoTracking().ToList();
        }

        public List<T> Find(Expression<Func<T, bool>> expression)
        {
            return this.context.Set<T>().Where(expression).AsNoTracking().ToList();
        }

        public T Get(int id)
        {
            return this.context.Set<T>().FirstOrDefault(t => t.Id == id);
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            return this.context.Set<T>().FirstOrDefault(expression);
        }

        public void Update(T entity)
        {
            this.context.Update<T>(entity);
        }
    }
}
