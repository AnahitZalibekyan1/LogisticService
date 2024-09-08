using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.Repositories
{
    internal interface IRepository<TEntity, TKey, TDataContext>
   where TEntity : class where TDataContext : DbContext
        {
        void Add(TEntity entity);
        IQueryable<TEntity> GetAll();
        TEntity FinfByKey(TKey key);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
