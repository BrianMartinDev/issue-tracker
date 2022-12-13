namespace issue_tracker.Models
    {
    public class Project
        {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        //-- Navigation Properties
        public Company? Company { get; set; }
        public virtual IEnumerable<Issue>? Issues { get; set; }
        public virtual ICollection<AppUser>? AppUsers { get; set; }
        public virtual IEnumerable<CommentProject>? CommentProjects { get; set; }
        }
    }
