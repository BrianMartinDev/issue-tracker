using System.ComponentModel.DataAnnotations;

namespace issue_tracker.Models.DTO.CommentProject
    {
    public class UpdateCommentProjectDTO
        {
        [Required]
        public int Id { get; set; }
        }
    }