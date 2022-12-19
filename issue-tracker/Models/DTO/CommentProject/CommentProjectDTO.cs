using issue_tracker.Models.DTO.Project;
using Microsoft.Build.Framework;

namespace issue_tracker.Models.DTO.CommentProject
    {
    public class CommentProjectDTO : BaseCommentProjectDTO
        {
        [Required]
        public int Id { get; set; }
        [Required]
        public virtual ProjectDTO ProjectId { get; set; }
        }
    }
