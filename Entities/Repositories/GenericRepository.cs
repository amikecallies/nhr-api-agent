using Entities.nhrappdata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Entities.Repositories
{
    public abstract class GenericRepository<T>
        : IRepository<T> where T : class
    {

        protected nhrappdataContext context;

        protected GenericRepository(nhrappdataContext context)
        {
            this.context = context;
        }

        // TODO for P163 Servant
        public virtual T Add(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T> FindAll()
        {
            return context.Set<T>().ToArray();
        }

        // TODO for P163 Servant
        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        // TODO for P163 Servant
        public virtual T Get(T entity)
        {
            throw new NotImplementedException();
        }

        // TODO for P163 Servant
        public virtual void SaveChanges()
        {
            throw new NotImplementedException();
        }

        // TODO for P163 Servant
        public virtual T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
