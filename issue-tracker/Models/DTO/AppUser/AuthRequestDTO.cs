using System.ComponentModel.DataAnnotations;

namespace issue_tracker.Models.DTO.AppUser
    {
    public class AuthRequestDTO
        {
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? Password { get; set; }
        }
    }
