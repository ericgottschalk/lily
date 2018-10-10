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

        T Get(Expression<Func<T, bool>> expression);

        T Get<TProp>(Expression<Func<T, bool>> expression, params Expression<Func<T, TProp>>[] includePaths);

        List<T> Find();

        List<T> Find(Expression<Func<T, bool>> expression);

        List<T> Find<TProp>(Expression<Func<T, bool>> expression, params Expression<Func<T, TProp>>[] includePaths);
    }
}
