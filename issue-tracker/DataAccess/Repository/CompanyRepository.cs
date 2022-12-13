using issue_tracker.DataAccess.Repository.IRepository;
using issue_tracker.Models;

namespace issue_tracker.DataAccess.Repository
    {
    public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
        {
        public CompanyRepository(ApplicationDbContext context) : base(context)
            {
            }
        }
    }
