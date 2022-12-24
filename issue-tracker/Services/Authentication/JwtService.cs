using issue_tracker.Models.DTO.AppUser;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace issue_tracker.Services.Authentication
    {
    public class JwtService
        {
        private readonly IConfiguration _configuration;
        private const int EXPIRATION_MINUTES = 10;

        public JwtService(IConfiguration configuration)
            {
            _configuration = configuration;
            }

        public AuthResponseDTO CreateToken(IdentityUser user)
            {
            var expiration = DateTime.UtcNow.AddMinutes(EXPIRATION_MINUTES);

            var token = CreateJwtToken(CreateClaims(user), CreateSigningCredentials(), expiration);

            var tokenHandler = new JwtSecurityTokenHandler();


            return new AuthResponseDTO
                {
                Token = tokenHandler.WriteToken(token),
                Expiration = expiration
                };
            }

        // standardized claims
        private Claim[] CreateClaims(IdentityUser user)
            {
            return new[] {
                new Claim(JwtRegisteredClaimNames.Sub, _configuration["JwtSettings:Subject"]),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Email, user.Email)
                };
            }

        // JWT claims
        private JwtSecurityToken CreateJwtToken(Claim[] claims, SigningCredentials credentials, DateTime expiration)
            {
            return new JwtSecurityToken(
                _configuration["JwtSettings:Issuer"],
                _configuration["JwtSettings:Audience"],
                claims,
                expires: expiration,
                signingCredentials: credentials
                );
            }
        private SigningCredentials CreateSigningCredentials()
            {
            return new SigningCredentials(
                new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(_configuration["JwtSettings:Key"])
                ),
                SecurityAlgorithms.HmacSha256
            );

            }
        }
    }
