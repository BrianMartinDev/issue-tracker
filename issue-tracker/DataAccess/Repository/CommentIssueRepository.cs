using issue_tracker.DataAccess.Repository.IRepository;

namespace issue_tracker.DataAccess.Repository
    {
    public class CommentIssueRepository : GenericRepository<CommentIssue>, ICommentIssueRepository
        {
        public CommentIssueRepository(ApplicationDbContext context) : base(context)
            {
            }
        }
    }
