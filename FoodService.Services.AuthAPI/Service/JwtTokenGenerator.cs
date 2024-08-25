using FoodService.Services.AuthAPI.Models;
using FoodService.Services.AuthAPI.Service.IService;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FoodService.Services.AuthAPI.Service
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        private readonly JwtOptions _jwtOptions;
        public JwtTokenGenerator(IOptions<JwtOptions> jwtOptions)
        {
            _jwtOptions = jwtOptions.Value;
        }

        public string GenerateToken(ApplicationUser applicationUser, IEnumerable<string> roles)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            // Ensure that the key is at least 256 bits (32 bytes)
            var key = Encoding.ASCII.GetBytes(_jwtOptions.Secret);
            if (key.Length < 32)
            {
                throw new ArgumentException("The JWT secret key must be at least 256 bits (32 bytes) long.");
            }

            var claimList = new List<Claim>
    {
        new Claim(JwtRegisteredClaimNames.Email, applicationUser.Email),
        new Claim(JwtRegisteredClaimNames.Sub, applicationUser.Id),
        new Claim(JwtRegisteredClaimNames.Name, applicationUser.UserName)
    };

            // Add roles as claims
            claimList.AddRange(roles.Select(role => new Claim(ClaimTypes.Role, role)));

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Audience = _jwtOptions.Audience,
                Issuer = _jwtOptions.Issuer,
                Subject = new ClaimsIdentity(claimList),
                Expires = DateTime.UtcNow.AddDays(7),  // Token expiration time
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

    }
}
