using issue_tracker.Models.DTO.Project;
using Microsoft.Build.Framework;

namespace issue_tracker.Models.DTO.Company
    {
    public class CompanyDTO : BaseCompanyDTO
        {
        [Required]
        public int Id { get; set; }
        //-- Navigation Properties
        public virtual IEnumerable<ProjectDTO>? Projects { get; set; }
        }
    }
