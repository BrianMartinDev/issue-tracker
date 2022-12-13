using issue_tracker.DataAccess.Repository.IRepository;
using issue_tracker.Models;

namespace issue_tracker.DataAccess.Repository
    {
    public class IssueRepository : GenericRepository<Issue>, IIssueRepository
        {
        public IssueRepository(ApplicationDbContext context) : base(context)
            {
            }
        }
    }
