using Microsoft.AspNetCore.Mvc;

namespace BaptisteIdentityServer.Controllers
{
    public class AuthController : Controller
    {
        [HttpPost("connect/token")]
        public async Task<IActionResult> AccessToken()
        {
            throw new NotImplementedException();
        }

        [HttpPost("register/client")]
        public async Task<IActionResult> 

    }
}
