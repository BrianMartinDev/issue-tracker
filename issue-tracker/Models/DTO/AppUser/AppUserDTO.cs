using issue_tracker.Models.DTO.Company;
using issue_tracker.Models.DTO.Project;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace issue_tracker.Models.DTO.AppUser
    {
    public class AppUserDTO : LoginDTO
        {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [NotMapped]
        public string? FullName { get { return $"{FirstName} {LastName}"; } }
        [NotMapped]
        [DataType(DataType.Upload)]
        public IFormFile? AvatarFormFile { get; set; }
        [DisplayName("Avatar")]
        public string? AvatarFileName { get; set; }
        public byte[]? AvatarFileData { get; set; }
        [Display(Name = "File Extension")]
        public string? AvatarContentType { get; set; }
        public int? CompanyId { get; set; }

        //Navigation Properties
        public virtual CompanyDTO? Company { get; set; }
        public virtual ICollection<ProjectDTO>? Projects { get; set; }
        }
    }
