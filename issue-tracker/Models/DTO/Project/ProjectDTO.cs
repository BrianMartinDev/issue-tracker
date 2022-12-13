using issue_tracker.Models.DTO.AppUser;
using issue_tracker.Models.DTO.CommentProject;
using issue_tracker.Models.DTO.Issue;
using Microsoft.Build.Framework;

namespace issue_tracker.Models.DTO.Project
    {
    public class ProjectDTO : BaseProjectDTO
        {
        [Required]
        public int Id { get; set; }
        [Required]
        public int CompanyId { get; set; }
        //-- Navigation Properties
        public virtual IEnumerable<IssueDTO>? Issues { get; set; }
        public virtual ICollection<AppUserDTO>? AppUsers { get; set; }
        public virtual IEnumerable<CommentProjectDTO>? CommentProjects { get; set; }
        }
    }
