using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.Repositories
{
    internal class Repository<TEntity, TKey, TDataContext> :
       IRepository<TEntity, TKey, TDataContext>
       where TEntity : class where TDataContext : DbContext
    {
        private readonly TDataContext _context;

        public Repository(TDataContext context)
        {
            _context = context;
        }
        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);

            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
        }

        public TEntity FinfByKey(TKey key)
        {
            var x = (TEntity)_context.Find(key.GetType(), key);
            return x;
            if (x == null)
            {
                throw new ArgumentNullException(nameof(x));
            }
        }

        public IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>() as IQueryable<TEntity>;
            if (_context == null)
            {
                throw new InvalidOperationException();
            }
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            if (_context == null)
            {
                throw new InvalidOperationException();
            }
        }
    }
}
