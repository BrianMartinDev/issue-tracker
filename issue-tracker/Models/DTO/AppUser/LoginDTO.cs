using System.ComponentModel.DataAnnotations;

namespace issue_tracker.Models.DTO.AppUser
    {
    public class LoginDTO
        {
        [Required]
        public string Email { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Password must be {2} and {1} characters", MinimumLength = 2)]
        public string Password { get; set; }
        }
    }