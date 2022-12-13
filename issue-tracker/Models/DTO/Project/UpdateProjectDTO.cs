using System.ComponentModel.DataAnnotations;

namespace issue_tracker.Models.DTO.Project
    {
    public class UpdateProjectDTO
        {
        [Required]
        public int Id { get; set; }
        }
    }