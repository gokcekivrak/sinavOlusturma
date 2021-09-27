using Microsoft.EntityFrameworkCore;
using Shared.Data.Abstract;
using Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Entities.Concrete.EntityFramework
{
	public class EfEntityRepositoryBase : IEntityRepository<IEntityBase>
      where IEntityBase : class, EntityBase, new()
	{
        private readonly DbContext _context;

        public EfEntityRepositoryBase(DbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(IEntityBase entity)
        {
            await _context.Set<IEntityBase>().AddAsync(entity);
        }

        public async Task<bool> AnyAsync(Expression<Func<IEntityBase, bool>> predicate)
        {
            return await _context.Set<IEntityBase>().AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<IEntityBase, bool>> predicate)
        {
            return await _context.Set<IEntityBase>().CountAsync(predicate);
        }

        public async Task DeleteAsync(IEntityBase entity)
        {
            await Task.Run(() => { _context.Set<IEntityBase>().Remove(entity); });
        }

        public async Task<IList<IEntityBase>> GetAllAsync(Expression<Func<IEntityBase, bool>> predicate = null, params Expression<Func<IEntityBase, object>>[] includeProperties)
        {
            IQueryable<IEntityBase> query = _context.Set<IEntityBase>();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (includeProperties.Any())
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }

            return await query.ToListAsync();
        }

        public async Task<IEntityBase> GetAsync(Expression<Func<IEntityBase, bool>> predicate, params Expression<Func<IEntityBase, object>>[] includeProperties)
        {
            IQueryable<IEntityBase> query = _context.Set<IEntityBase>();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (includeProperties.Any())
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }

            return await query.SingleOrDefaultAsync();
        }

        public async Task UpdateAsync(IEntityBase entity)
        {
            await Task.Run(() => { _context.Set<IEntityBase>().Update(entity); });
        }
    }
}
