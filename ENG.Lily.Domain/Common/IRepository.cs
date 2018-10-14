using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ENG.Lily.Domain.Common
{
    public interface IRepository<T> where T : Entity
    {
        void Add(T entity);

        void Update(T entity);

        bool Any();

        bool Any(Expression<Func<T, bool>> expression);

        T Get(int id);

        T Get(int id, params Expression<Func<T, object>>[] includePaths);
        
        T Get(Expression<Func<T, bool>> expression);

        T Get(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] includePaths);

        List<T> Find();

        List<T> Find(int page, int pageSize);

        List<T> Find(Expression<Func<T, bool>> expression);

        List<T> Find(Expression<Func<T, bool>> expression, int page, int pageSize);

        List<T> Find(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] includePaths);

        List<T> Find(Expression<Func<T, bool>> expression, int page, int pageSize, params Expression<Func<T, object>>[] includePaths);
    }
}
