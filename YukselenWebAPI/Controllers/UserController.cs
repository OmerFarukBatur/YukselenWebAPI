using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace YukselenWebAPI.Controllers
{
    
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost(Name = "register")]
        public IActionResult Register([FromBody] object user)
        {
            return Ok(user);
        }
        [HttpPost(Name ="create")]
        public IActionResult Create()
        {
            string a = "a";
            return Ok(a);
        }
    }
}
