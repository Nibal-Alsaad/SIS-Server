using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebSIS.DA.Repositories.Interfaces
{
  public  interface IRepository<TEntity,TModel,TKey>
    {
        Task<IEnumerable<TModel>> GetAllAsync();
        Task<TModel> GetAsync(TKey id);
        Task<IEnumerable<TModel>> FindAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TModel> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
        Task AddAsync(TModel item);
        Task AddRangeAsync(IEnumerable<TModel> items);
        void UpdateItem(TModel item);
        void RemoveItem(TModel item);
        void RemoveRangeItems(IEnumerable<TModel> items);
    }
}
