using System.ComponentModel.DataAnnotations;

namespace issue_tracker.Models.DTO.Company
    {
    public class UpdateCompanyDTO : BaseCompanyDTO
        {
        [Required]
        public int Id { get; set; }
        }
    }