using System.Linq.Expressions;
using FinanceNow.Data;
using FinanceNow.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FinanceNow.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly FinanceNowContext _context;
        public BaseRepository(FinanceNowContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().AsNoTracking().ToArrayAsync();

        }
        public async Task<T?> GetFirstAsync(Expression<Func<T, bool>> expression)
        {
            return await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(expression);
        }
        public async Task<T> Create(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            return entity;
        }

        public T? Update(T entity)
        {
            _context.Set<T>().Update(entity);
            return entity;
        }
        public T? Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            return entity;
        }
    }
}
