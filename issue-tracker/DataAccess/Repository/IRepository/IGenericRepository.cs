namespace issue_tracker.DataAccess.Repository.IRepository
    {
    public interface IGenericRepository
        {
        Task<List<T>> SelectAll<T>() where T : class;
        Task<T> SelectById<T>(long id) where T : class;
        Task CreateAsync<T>(T entity) where T : class;
        Task UpdateAsync<T>(T entity) where T : class;
        Task DeleteAsync<T>(T entity) where T : class;
        }
    }