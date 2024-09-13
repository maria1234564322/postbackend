using Application.User;
using DataAccess.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Web.Host.Model;

namespace Web.Host.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("registerUser")]
        public async Task<IActionResult> RegisterUser([FromBody] UserDto dto)
        {
            try
            {
                _userService.RegisterUser(dto);
                return Ok();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { errorText = ex.Message });
            }
        }

        [AllowAnonymous]
        [HttpPost("signIn")]
        public ActionResult SignIn([FromBody] LoginIncomeModel model)
        {
            var (user, identity) = GetIdentity(model.EmailAddress, model.Password);
            if (identity == null)
            {
                return BadRequest(new { errorText = "Invalid username or password." });
            }

            var now = DateTime.UtcNow;
            var jwt = new JwtSecurityToken(
                issuer: AuthOptions.ISSUER,
                audience: AuthOptions.AUDIENCE,
                notBefore: now,
                claims: identity.Claims,
                expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
                signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.Aes128CbcHmacSha256));

            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
            var response = new
            {
                access_token = encodedJwt,
            };
            return Ok(response);
        }

        private (User, ClaimsIdentity) GetIdentity(string email, string password)
        {
            User person = _userService.FindUserByEmailAndPassword(email, password);
            if (person != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, person.Email),
                    new Claim("UserId", person.Id.ToString())
                };

                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
                return (person, claimsIdentity);
            }

            return (null, null);
        }
    }
}

