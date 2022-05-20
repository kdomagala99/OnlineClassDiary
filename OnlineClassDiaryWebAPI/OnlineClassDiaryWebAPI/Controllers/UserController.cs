using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineClassDiaryWebAPI.Dtos;
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

        [HttpGet("getuser/{username}")]
        public ActionResult GetUser(string username)
        {
            var result = _userService.GetUser(username);
            return Ok(result);
        }

        [HttpPost("createuser")]
        public ActionResult CreateUser([FromBody] UserDto userDto)
        {
            var result = _userService.CreateUser(userDto);
            return Ok(result);
        }

        [HttpPut("edituser/{username}")]
        public ActionResult EditUser([FromQuery]string username, [FromBody] UserDto userDto)
        {
            var result = _userService.EditUser(username, userDto);
            return Ok(result);
        }

        [HttpDelete("deleteuser/{username}")]
        public ActionResult DeleteUser([FromQuery]string username)
        {
            var result = _userService.DeleteUser(username);
            return Ok();
        }
    }
}
