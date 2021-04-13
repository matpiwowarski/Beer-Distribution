using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BeerMaker.Repository
{
    public interface IBeerMakerRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetItems(Expression<Func<T, bool>>[] predicate, string[] includes = null);
        Task<IEnumerable<T>> GetItems(Expression<Func<T, bool>> predicate = null, string[] includes = null);
        Task<T> GetItem(Expression<Func<T, bool>> predicate, string[] includes = null);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task Delete(T entity);
    }

    public class BeerMakerRepository<T> : IBeerMakerRepository<T> where T : class
    {
        public Task<T> Add(T entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetItem(Expression<Func<T, bool>> predicate, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetItems(Expression<Func<T, bool>>[] predicate, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetItems(Expression<Func<T, bool>> predicate = null, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
