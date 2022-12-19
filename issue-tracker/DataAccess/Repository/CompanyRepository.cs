



using issue_tracker.DataAccess.Repository.IRepository;
using issue_tracker.Models;
using System.Data.Entity;

namespace issue_tracker.DataAccess.Repository
    {
    public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
        {
        public CompanyRepository(ApplicationDbContext context) : base(context)
            {
            }

        public async Task<IEnumerable<Company>> GetCompanyProjects()
            {
            return await _context.Companies.Include(o => o.Projects).ToListAsync();
            }
        }
    }
