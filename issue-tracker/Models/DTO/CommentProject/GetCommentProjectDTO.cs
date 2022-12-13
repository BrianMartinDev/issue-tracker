using Microsoft.Build.Framework;

namespace issue_tracker.Models.DTO.CommentProject
    {
    public class GetCommentProjectDTO
        {
        [Required]
        public int Id { get; set; }
        }
    }