using Microsoft.Build.Framework;

namespace issue_tracker.Models.DTO.Project
    {
    public class GetProjectDTO : BaseProjectDTO
        {
        [Required]
        public int Id { get; set; }
        }
    }