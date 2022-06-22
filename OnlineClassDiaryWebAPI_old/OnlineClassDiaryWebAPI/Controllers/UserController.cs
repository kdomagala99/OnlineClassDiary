using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineClassDiaryWebAPI.Dtos;
using OnlineClassDiaryWebAPI.Entities;
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

        [HttpGet("getusers")]
        public ActionResult GetUsers()
        {
            var result = _userService.GetUsers();
            return Ok(result);
        }

        [HttpGet("getuser/{email}")]
        public ActionResult GetUser(string email)
        {
            var result = _userService.GetUser(email);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost("createuser")]
        public ActionResult CreateUser([FromBody] User userDto)
        {
            _userService.CreateUser(userDto);
            return Ok();
        }

        [HttpPut("edituser")]
        public ActionResult EditUser([FromBody]User user)
        {
            _userService.EditUser(user);
            return Ok();
        }

        [HttpDelete("deleteuser/{email}")]
        public ActionResult DeleteUser(string email)
        {
            _userService.DeleteUser(email);
            return Ok();
        }

        [HttpPost("login")]
        public ActionResult Login([FromForm]string email, [FromForm]string password)
        {
            var logged = _userService.Login(email, password);
            if (logged == null)
                return NotFound();
            if (logged.Email == null)
                return BadRequest();
            return Ok();
        }
    }
}
