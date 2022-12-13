namespace issue_tracker.Models
    {
    public class Issue
        {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        //-- Navigation Properties
        public Project? Project { get; set; }
        public virtual IEnumerable<CommentIssue>? CommentIssues { get; set; }
        }
    }
