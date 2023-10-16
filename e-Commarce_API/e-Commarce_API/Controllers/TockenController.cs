using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace e_Commarce_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TockenController : ControllerBase
    {
        public readonly IConfiguration _configuration;
        //private readonly SignInManager<ApplicationUser> _signInManager;
        //private readonly UserManager<ApplicationUser> _userManager;

        public TockenController(IConfiguration config
            //UserManager<ApplicationUser> userManager,
            //SignInManager<ApplicationUser> signInManager
            )
        {
            _configuration = config;
            //_userManager = userManager;
            //_signInManager = signInManager;
        }
        [HttpGet]
        public async Task<IActionResult> Get(string username, string password)
        {
            if (username != null && password != null)
            {
                //var user = await _userManager.FindByEmailAsync(username);
                //var result = await _signInManager.CheckPasswordSignInAsync(user, password, true);

                if (username == "sfd.api.token" && password == "realjwttoken")
                {
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]);
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        //Subject = new ClaimsIdentity((await _userManager.GetClaimsAsync(user)).ToArray()),
                        Issuer = _configuration["Jwt:Issuer"],
                        Audience = _configuration["Jwt:Audience"],
                        Expires = DateTime.UtcNow.AddDays(2000),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                    };
                    var token = tokenHandler.CreateToken(tokenDescriptor);

                    return Ok(tokenHandler.WriteToken(token));
                }
                else
                {
                    return BadRequest("Invalid credentials");
                }
                //return BadRequest();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
