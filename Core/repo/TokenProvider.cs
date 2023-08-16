using Core.Entities;
using Core.interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Core.repo
{
    public class TokenProvider : ITokenProvider
    {
        private readonly IConfiguration _configuration;
        public TokenProvider(IConfiguration configuration)
        {
            _configuration = configuration;

        }
        public string creatToken(User user)
        {


            //var UserRole = await _userManager.GetRolesAsync(user);
            var claims = new List<Claim>
            {
                //new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Email , user.Email),
           
               new Claim(ClaimTypes.Hash , user.Id),
            };

            var key = _configuration["Token:key"]!;

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));

            var cred = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddDays(30),
                SigningCredentials = cred

            };
            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}


