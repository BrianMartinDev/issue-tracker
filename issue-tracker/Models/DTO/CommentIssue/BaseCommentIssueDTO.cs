using System.ComponentModel.DataAnnotations;

namespace issue_tracker.Models.DTO.CommentIssue
    {
    public class BaseCommentIssueDTO
        {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        }
    }