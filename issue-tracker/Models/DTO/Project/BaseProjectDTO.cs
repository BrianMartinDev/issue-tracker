using Microsoft.Build.Framework;

namespace issue_tracker.Models.DTO.Project
    {
    public class BaseProjectDTO
        {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        }
    }