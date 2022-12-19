namespace issue_tracker.DataAccess.Repository.IRepository
    {
    public interface IUnitOfWork : IDisposable
        {
        ICompanyRepository CompanyRepository { get; }
        IProjectRepository ProjectRepository { get; }
        IIssueRepository IssueRepository { get; }
        ICommentIssueRepository CommentIssueRepository { get; }
        ICommentProjectRepository CommentProjectRepository { get; }

        Task<int> CompletedAsync();
        }
    }