



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

        public async Task<Company> ProjectListByCompanyId(int id)
            {
            var obj = await _context.Companies.Include(o => o.Projects)
                //.Where(o => o.Id == id)
                .FirstOrDefaultAsync(x => x.Id == id);
            return obj;
            }
        }
    }
