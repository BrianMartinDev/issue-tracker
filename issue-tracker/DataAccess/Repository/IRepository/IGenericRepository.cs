using System.Linq.Expressions;

namespace issue_tracker.DataAccess.Repository.IRepository
    {
    public interface IGenericRepository<T> where T : class
        {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetAsync(int id);
        Task<bool> CreateAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> Remove(int id);
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression);
        }
    }