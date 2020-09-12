using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Entities.Repositories
{
    public interface IRepository<T>
    {
        T Add(T entity);
        T Update(T entity);
        T Get(T entity);
        IEnumerable<T> FindAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        void SaveChanges();
    }
}
