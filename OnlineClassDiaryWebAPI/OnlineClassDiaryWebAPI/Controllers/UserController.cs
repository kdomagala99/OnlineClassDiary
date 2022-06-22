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
#nullable enable
        [HttpPost("adduser")]
        public ActionResult AddUser([FromForm]string email, [FromForm] string password, [FromForm]string name, [FromForm] string surname, [FromForm] string role, [FromForm] string? childEmail)
        {
            var result = _userService.AddUser(email, password, name, surname, role, childEmail);
            if (result)
                return Ok();
            return BadRequest();
        }
#nullable disable

        [HttpGet("getallusers")]
        public ActionResult GetAllUsers()
        {
            return Ok(_userService.GetAllUsers());
        }
    }
}
