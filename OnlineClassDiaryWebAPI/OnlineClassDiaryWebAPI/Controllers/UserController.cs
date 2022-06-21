using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineClassDiaryWebAPI.Services.Interfaces;

namespace OnlineClassDiaryWebAPI.Controllers
{
    [Route("api/usercontroller")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public ActionResult LoginUser([FromForm]string email, [FromForm]string password)
        {
            var loginStatus = _userService.LoginUser(email, password);
            if (loginStatus)
                return Ok();
            return BadRequest();
        }

        [HttpGet("getuser/{email}")]
        public ActionResult GetUser(string email)
        {
            var user = _userService.GetUser(email);
            if (user == null)
                return BadRequest();
            return Ok(user);
        }
    }
}
