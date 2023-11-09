using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using Yesilcam.DATA.Abstract;

namespace Yesilcam.REPO.Interfaces
{
	public interface IBaseREPO<T> where T : class
	{
		int Create(T Entity);
		int Update(T Entity);
		int Delete(T Entity);

		Task<T> GetById(int id);
		Task<bool> Any(Expression<Func<T, bool>> expression);
		Task<List<T>> GetAll(Expression<Func<T, bool>> expression);

		Task<TResult> GetFilteredFirstOrDefault<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> join = null);

		Task<List<TResult>> GetFilteredList<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> join = null);
	}
}
