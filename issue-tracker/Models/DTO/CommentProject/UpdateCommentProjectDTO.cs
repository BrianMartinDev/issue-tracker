using System.ComponentModel.DataAnnotations;

namespace issue_tracker.Models.DTO.CommentProject
    {
    public class UpdateCommentProjectDTO : BaseCommentProjectDTO
        {
        [Required]
        public int Id { get; set; }
        }
    }