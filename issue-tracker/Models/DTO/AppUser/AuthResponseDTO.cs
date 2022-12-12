namespace issue_tracker.Models.DTO.AppUser
    {
    public class AuthResponseDTO
        {
        public string Username { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        }
    }