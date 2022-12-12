using issue_tracker.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace issue_tracker.DataAccess.Repository
    {
    internal class GenericRepository<ApplicationDbContext> : IGenericRepository where ApplicationDbContext : DbContext
        {
        private readonly ApplicationDbContext dbContext;

        public GenericRepository(ApplicationDbContext context)
            {
            dbContext = context;
            }
        public async Task CreateAsync<T>(T entity) where T : class
            {
            dbContext.Set<T>().Add(entity);

            _ = await dbContext.SaveChangesAsync();
            }

        public async Task DeleteAsync<T>(T entity) where T : class
            {
            dbContext.Set<T>().Remove(entity);

            _ = await dbContext.SaveChangesAsync();
            }

        public async Task<List<T>> SelectAll<T>() where T : class
            {
            return await dbContext.Set<T>().ToListAsync();
            }

        public async Task<T> SelectById<T>(long id) where T : class
            {

            return await dbContext.Set<T>().FindAsync(id);
            }

        public async Task UpdateAsync<T>(T entity) where T : class
            {
            dbContext.Set<T>().Update(entity);

            _ = await dbContext.SaveChangesAsync();
            }
        }
    }
