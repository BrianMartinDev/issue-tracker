using Microsoft.Build.Framework;

namespace issue_tracker.Models.DTO.CommentProject
    {
    public class GetCommentProjectDTO : BaseCommentProjectDTO
        {
        [Required]
        public int Id { get; set; }
        }
    }