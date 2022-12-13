using Microsoft.Build.Framework;

namespace issue_tracker.Models.DTO.CommentIssue
    {
    public class CommentIssueDTO : BaseCommentIssueDTO
        {
        [Required]
        public int Id { get; set; }
        [Required]
        public int IssueId { get; set; }
        }
    }
