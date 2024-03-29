﻿
using issue_tracker.DataAccess.Repository;
using issue_tracker.DataAccess.Repository.IRepository;

namespace issue_tracker.DataAccess.UnitOfWork
    {
    public class UnitOfWork : IUnitOfWork, IDisposable
        {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
            {
            _context = context;
            CompanyRepository = new CompanyRepository(context);
            ProjectRepository = new ProjectRepository(context);
            IssueRepository = new IssueRepository(context);
            CommentIssueRepository = new CommentIssueRepository(context);
            CommentProjectRepository = new CommentProjectRepository(context);
            }
        public ICompanyRepository CompanyRepository { get; set; }
        public IProjectRepository ProjectRepository { get; private set; }
        public IIssueRepository IssueRepository { get; private set; }
        public ICommentIssueRepository CommentIssueRepository { get; private set; }
        public ICommentProjectRepository CommentProjectRepository { get; private set; }

        public async Task<int> CompletedAsync()
            {
            return await _context.SaveChangesAsync();
            }

        public void Dispose()
            {
            _context.Dispose();
            }
        }
    }
