using Microsoft.Build.Framework;

namespace issue_tracker.Models.DTO.CommentIssue
    {
    public class UpdateCommentIssueDTO : BaseCommentIssueDTO
        {
        [Required]
        public int Id { get; set; }
        }
    }