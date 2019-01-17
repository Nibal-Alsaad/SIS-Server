using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebSIS.DA.Context;
using WebSIS.DA.Repositories.Interfaces;

namespace WebSIS.DA.Repositories
{
    public class RepositoryBase<TEntity,TModel, TKey> : IRepository<TEntity,TModel, TKey> where TEntity : class
    {
        SISContext _context;
        IMapper _mapper;
        private DbSet<TEntity> dataTable
        {
            get
            {
                return _context.Set<TEntity>();
            }
        }
        public RepositoryBase(SISContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual async Task<IEnumerable<TModel>> GetAllAsync()
        {
            var res= await dataTable.ToListAsync();
            return _mapper.Map<IEnumerable<TModel>>(res);
        }

        public virtual async Task<TModel> GetAsync(TKey id)
        {
            var res= await dataTable.FindAsync(id);
            return _mapper.Map<TModel>(res);
        }

        public async Task<IEnumerable<TModel>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var res= await dataTable.Where(predicate).ToListAsync();
            return _mapper.Map<IEnumerable<TModel>>(res);
        }

        public async Task<TModel> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var res= await dataTable.SingleOrDefaultAsync(predicate);
            return _mapper.Map<TModel>(res);
        }

        public async Task AddAsync(TModel item)
        {
            var entity = _mapper.Map<TEntity>(item);
             await dataTable.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<TModel> items)
        {
            var entities = _mapper.Map<IEnumerable<TEntity>>(items);
            await dataTable.AddRangeAsync(entities);
        }

        public void UpdateItem(TModel item)
        {
                var entity = _mapper.Map<TEntity>(item);
                dataTable.Update(entity);
        }

        public void RemoveItem(TModel item)
        {
            var entity = _mapper.Map<TEntity>(item);
            dataTable.Remove(entity);
        }

        public void RemoveRangeItems(IEnumerable<TModel> items)
        {
            var entities = _mapper.Map<IEnumerable<TEntity>>(items);
            dataTable.RemoveRange(entities);
        }

    }
}
