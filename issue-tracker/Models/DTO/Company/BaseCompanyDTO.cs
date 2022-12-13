using System.ComponentModel.DataAnnotations;

namespace issue_tracker.Models.DTO.Company
    {
    public class BaseCompanyDTO
        {
        [Required]
        public string? OrgName { get; set; }
        [Required]
        public string? Description { get; set; }
        }
    }