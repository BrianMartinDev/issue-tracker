using issue_tracker.Models.DTO.CommentIssue;
using System.ComponentModel.DataAnnotations;

namespace issue_tracker.Models.DTO.Issue
    {
    public class IssueDTO : BaseIssueDTO
        {
        [Required]
        public int Id { get; set; }
        [Required]
        public int ProjectId { get; set; }
        public virtual IEnumerable<CommentIssueDTO>? CommentIssues { get; set; }
        }
    }
