using System.Linq.Expressions;

namespace FinanceNow.Repository.Interfaces
{
    public interface IBaseRepository<T>
    {

        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetFirstAsync(Expression<Func<T, bool>> expression);
        Task<T> Create(T entity);
        T? Update(T entity);
        T? Delete(T entity);


    }
}
