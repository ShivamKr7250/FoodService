using FoodService.Services.AuthAPI.Models;
using FoodService.Services.AuthAPI.Service.IService;
using System.IdentityModel.Tokens.Jwt;

namespace FoodService.Services.AuthAPI.Service
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        private readonly JwtOptions _jwtOptions;
        public JwtTokenGenerator(JwtOptions jwtOptions)
        {
            _jwtOptions = jwtOptions;
        }

        public string GenerateToken(ApplicationUser applicationUser)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
        }
    }
}
