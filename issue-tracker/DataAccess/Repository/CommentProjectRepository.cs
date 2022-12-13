using issue_tracker.DataAccess.Repository.IRepository;

namespace issue_tracker.DataAccess.Repository
    {
    public class CommentProjectRepository : GenericRepository<CommentProject>, ICommentProjectRepository
        {
        public CommentProjectRepository(ApplicationDbContext context) : base(context)
            {
            }
        }
    }
