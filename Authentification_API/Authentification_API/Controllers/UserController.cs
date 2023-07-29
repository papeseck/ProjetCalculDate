using Authentification_API.Context;
using Authentification_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Authentification_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AuthBdContext _authBdContext;
        public UserController(AuthBdContext authBdContext)
        {
            _authBdContext = authBdContext;

        }
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] User userObj)
        {
            if (userObj == null)
                return BadRequest();
            var user = await _authBdContext.users.FirstOrDefaultAsync(x => x.UserName == userObj.UserName
            && x.Password == userObj.Password);
            if (user == null)
                return NotFound(new { Message = "user not found?" });
            return Ok(new
            {
                Message = "Login Sucess "
            });

        }
        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] User userObj)
        {
            if (userObj == null)
                return BadRequest();
            await _authBdContext.users.AddAsync(userObj);
            await _authBdContext.SaveChangesAsync();
            return Ok(new
            {
                Message = "User registered!!"
            });

        }
    }
}
