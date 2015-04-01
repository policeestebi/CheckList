using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TriQuint.BaseInterfaces;
using TriQuint.CheckList.DAL.Interfaces;
using TriQuint.CheckList.Entities;

namespace TriQuint.CheckList.Repositories
{
    public abstract class GenericRepository<T>:IEntityRepository<T> where T: BaseEntity
    {
        protected GenericRepository(IContext context)
        {
            if (context == null) throw new NullReferenceException("context");

            _context = context as DbContext;

            _dbSet = _context.Set<T>();
        }

        protected GenericRepository(IUnitOfWork uow)
        {
            if(uow == null) throw new ArgumentNullException("uow");

            _context = uow.Context as DbContext;

            _dbSet = _context.Set<T>();
        } 

        public void Dispose()
        {
            _context.Dispose();

            // This object will be cleaned up by the Dispose method. 
            // Therefore, you should call GC.SupressFinalize to 
            // take this object off the finalization queue 
            // and prevent finalization code for this object 
            // from executing a second time.
            GC.SuppressFinalize(this);
        }

        public virtual IQueryable<T> All
        {
            get { return _dbSet; }
        }

        public virtual IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            return includeProperties.Aggregate<Expression<Func<T, object>>, IQueryable<T>>(_dbSet, (current, includeProperty) => current.Include(includeProperty));
        }

        public virtual IList<T> GetAll()
        {
            return (_dbSet.ToList());
        }

        public virtual async Task<IList<T>> GetAllAsync()
        {
            var entities = await(_dbSet.ToListAsync());

            return entities;
        }

        public virtual int Count()
        {
            return _dbSet.Count();
        }

        public virtual async Task<int> CountAsync()
        {
            var count = await (_dbSet.CountAsync());

            return count;
        }

        public virtual T Find(Expression<Func<T, bool>> match)
        {
            return (_dbSet.SingleOrDefault(match));
        }

        public virtual async Task<T> FindAsync(Expression<Func<T, bool>> match)
        {
            return await (_dbSet.SingleOrDefaultAsync(match));
        }

        public virtual async Task<IList<T>> FindAllAsync(Expression<Func<T, bool>> match)
        {
            var entities = await(_dbSet.Where(match).ToListAsync());

            return entities;
        }

        public virtual void InsertOrUpdate(T entity)
        {
            _context.Entry(entity).State = entity.Id == default(int) ? EntityState.Added : EntityState.Modified;
        }

        public virtual void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            _dbSet.Remove(entity);
        }

        protected readonly DbContext _context;

        protected readonly DbSet<T> _dbSet;
    }
}
