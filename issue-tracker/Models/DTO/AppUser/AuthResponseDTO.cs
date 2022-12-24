namespace issue_tracker.Models.DTO.AppUser
    {
    public class AuthResponseDTO
        {
        public string? Token { get; set; }
        public DateTime Expiration { get; set; }
        }
    }