using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using Yesilcam.DATA.Abstract;
using Yesilcam.REPO.Contexts;
using Yesilcam.REPO.Interfaces;

namespace Yesilcam.REPO.Concrete
{
	public class BaseREPO<T> : IBaseREPO<T> where T:class
	{
		private AppDbContext _context;
		private DbSet<T> _table;

		public BaseREPO(AppDbContext context)
		{
			_context = context;
			_table = context.Set<T>();
		}

		public async Task<bool> Any(Expression<Func<T, bool>> expression)
		{
			return await _table.AnyAsync(expression);
		}

		public int Create(T Entity)
		{
			_table.Add(Entity);
			return _context.SaveChanges();
		}

		public int Delete(T Entity)
		{
			return _context.SaveChanges();
		}

		public async Task<List<T>> GetAll(Expression<Func<T, bool>> expression)
		{
			return await _table.Where(expression).ToListAsync();
		}

		public async Task<T> GetById(int id)
		{
			return await _table.FindAsync(id);
		}

		public async Task<TResult> GetFilteredFirstOrDefault<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> join = null)
		{
			IQueryable<T> query = _table;

            if (join!=null)
            {
				query = join(query); 
            }
            if (where!=null)
            {
                query=query.Where(where);
            }
            if (orderBy!=null)
            {
                return await orderBy(query).Select(select).FirstOrDefaultAsync();
            }
            else
            {
				return await query.Select(select).FirstOrDefaultAsync();
			}
        }

		public async Task<List<TResult>> GetFilteredList<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> join = null)
		{

			IQueryable<T> query = _table;

			if (join != null)
			{
				query = join(query);
			}
			if (where != null)
			{
				query = query.Where(where);
			}
			if (orderBy != null)
			{
				return await orderBy(query).Select(select).ToListAsync();
			}
			else
			{
				return await query.Select(select).ToListAsync();
			}
		}

		public int Update(T Entity)
		{
			_context.Entry<T>(Entity).State = EntityState.Modified;
			return _context.SaveChanges();
		}
	}
}
