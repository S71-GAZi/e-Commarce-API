using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace e_Commarce_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TockenController : ControllerBase
    {

        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<string>> Get()
        {
            var token = await HttpContext.GetTokenAsync("access_token");
            return token;
        }
    }
}
