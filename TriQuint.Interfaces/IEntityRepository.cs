using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TriQuint.BaseInterfaces
{
    public interface IEntityRepository<T> :IDisposable
    {
        IQueryable<T> All { get; }
        IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);
        IList<T> GetAll();
        Task<IList<T>> GetAllAsync();
        int Count();
        Task<int> CountAsync();
        T Find(Expression<Func<T, bool>> match);
        Task<T> FindAsync(Expression<Func<T, bool>> match);
        Task<IList<T>> FindAllAsync(Expression<Func<T, bool>> match);
        void InsertOrUpdate(T entity);
        void Delete(int id);
    }
}
