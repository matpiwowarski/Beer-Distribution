using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerMaker.Repository
{
    public interface ICardioUnitOfWork : IDisposable
    {
        IBeerMakerRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
    }

    public class BeerMakerUnitOfWork : ICardioUnitOfWork
    {
        private bool disposed = false;
        public Dictionary<Type, object> Repositories = new Dictionary<Type, object>();
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IBeerMakerRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }
        public async Task<int> Commit()
        {
            throw new NotImplementedException();//return await _dbContext.SaveChangesAsync();
        }

        public void Rollback()
        {
            //_dbContext.ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
        }

    }
}
