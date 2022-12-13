using System.ComponentModel.DataAnnotations;

namespace issue_tracker.Models.DTO.Issue
    {
    public class GetIssueDTO
        {
        [Required]
        public int Id { get; set; }
        }
    }