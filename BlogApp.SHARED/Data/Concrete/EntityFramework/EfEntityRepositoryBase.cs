using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using BlogApp.SHARED.Data.Abstract;
using BlogApp.SHARED.Entities.Abstract;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.SHARED.Data.Concrete.EntityFramwork
{
	public class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
	{
		private readonly DbContext _dbContext;

		public EfEntityRepositoryBase(DbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task AddAsync(TEntity entity)
		{
			await _dbContext.Set<TEntity>().AddAsync(entity);
		}

		public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
		{
			return await _dbContext.Set<TEntity>().AnyAsync(predicate);
		}

		public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
		{
			return await _dbContext.Set<TEntity>().CountAsync(predicate);
		}

		public async Task DeleteAsync(TEntity entity)
		{
			await Task.Run(() => { _dbContext.Set<TEntity>().Remove(entity); });
		}

		public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null,
			params Expression<Func<TEntity, object>>[] icludeProporties)
		{
			IQueryable<TEntity> query = _dbContext.Set<TEntity>();
			if (predicate != null) query = query.Where(predicate);

			if (icludeProporties.Any())
				foreach (var includeProperty in icludeProporties)
					query = query.Include(includeProperty);

			return await query.ToListAsync();
		}

		public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate,
			params Expression<Func<TEntity, object>>[] icludeProporties)
		{
			IQueryable<TEntity> query = _dbContext.Set<TEntity>();
			if (predicate != null) query = query.Where(predicate);

			if (icludeProporties.Any())
				foreach (var includeProperty in icludeProporties)
					query = query.Include(includeProperty);

			return await query.SingleOrDefaultAsync();
		}

		public async Task UpdateAsync(TEntity entity)
		{
			await Task.Run(() => { _dbContext.Set<TEntity>().Update(entity); });
		}
	}
}