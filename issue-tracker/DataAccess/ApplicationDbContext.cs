using issue_tracker.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace issue_tracker.DataAccess
    {
    public class ApplicationDbContext : IdentityUserContext<IdentityUser>
        {
        private readonly DbContextOptions<ApplicationDbContext> _options;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {
            _options = options;
            }
        public DbSet<Company>? Companies { get; set; }
        public DbSet<Project>? Projects { get; set; }
        public DbSet<Issue>? Issues { get; set; }
        public DbSet<Notification>? Notifications { get; set; }
        public DbSet<CommentProject>? CommentProjects { get; set; }
        public DbSet<CommentIssue>? CommentIssues { get; set; }
        public DbSet<UserApiKey> UserApiKeys { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new CommentProjectConfiguration());
            modelBuilder.ApplyConfiguration(new IssueConfiguration());
            modelBuilder.ApplyConfiguration(new CommentIssueConfiguration());
            }
        }
    }