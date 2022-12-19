using System.ComponentModel.DataAnnotations;

namespace issue_tracker.Models.DTO.Issue
    {
    public class GetIssueDTO : BaseIssueDTO
        {
        [Required]
        public int Id { get; set; }
        }
    }