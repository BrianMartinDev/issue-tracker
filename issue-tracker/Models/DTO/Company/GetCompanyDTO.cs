using System.ComponentModel.DataAnnotations;

namespace issue_tracker.Models.DTO.Company
    {
    public class GetCompanyDTO
        {
        [Required]
        public int Id { get; set; }
        }
    }