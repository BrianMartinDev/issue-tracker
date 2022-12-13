using issue_tracker.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace issue_tracker.DataAccess.Repository
    {
    public class GenericRepository<T> : IGenericRepository<T> where T : class
        {
        protected ApplicationDbContext _context;
        internal DbSet<T> dbSet;

        public GenericRepository(ApplicationDbContext context)
            {
            _context = context;
            dbSet = context.Set<T>();
            }

        public async Task<bool> CreateAsync(T entity)
            {
            await dbSet.AddAsync(entity);
            return true;
            }

        public async Task<bool> Remove(int id)
            {
            var entity = await dbSet.FindAsync(id);
            if (entity != null)
                {
                dbSet.Remove(entity);
                return true;
                }
            else
                return false;
            }

        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
            {
            return await dbSet.Where(predicate).ToListAsync();
            }

        public async Task<IEnumerable<T>> GetAllAsync()
            {
            return await dbSet.ToListAsync();
            }

        public async Task<T?> GetAsync(int id)
            {
            return await dbSet.FindAsync(id);
            }

        public async Task<bool> UpdateAsync(T entity)
            {
            dbSet.Update(entity);
            return true;
            }
        }
    }
