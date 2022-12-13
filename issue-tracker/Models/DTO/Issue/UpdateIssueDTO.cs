using System.ComponentModel.DataAnnotations;

namespace issue_tracker.Models.DTO.Issue
    {
    public class UpdateIssueDTO
        {
        [Required]
        public int Id { get; set; }
        }
    }