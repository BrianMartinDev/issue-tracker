using System.ComponentModel.DataAnnotations;

namespace issue_tracker.Models.DTO.Issue
    {
    public class BaseIssueDTO
        {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        }
    }