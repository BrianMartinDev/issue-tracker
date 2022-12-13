using issue_tracker.DataAccess.Repository.IRepository;
using issue_tracker.Models;

namespace issue_tracker.DataAccess.Repository
    {
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
        {
        public ProjectRepository(ApplicationDbContext context) : base(context)
            {
            }
        }
    }
