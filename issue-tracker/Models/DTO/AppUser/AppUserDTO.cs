using System.ComponentModel.DataAnnotations;

namespace issue_tracker.Models.DTO.AppUser
    {
    public class AppUserDTO : LoginDTO
        {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        }
    }
