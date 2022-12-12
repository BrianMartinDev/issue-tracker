namespace issue_tracker.Models
    {
    public class Company
        {
        public int Id { get; set; }
        public string? OrgName { get; set; }
        public string? Description { get; set; }
        //-- Navigation Properties
        public virtual IEnumerable<Project>? Projects { get; set; }
        }
    }
