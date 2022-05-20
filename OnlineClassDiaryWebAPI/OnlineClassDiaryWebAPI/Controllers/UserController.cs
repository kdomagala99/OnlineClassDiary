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

        [HttpGet("getuser/{username}")]
        public ActionResult GetUser(string username)
        {
            var result = _userService.GetUser(username);
            return Ok(result);
        }

        [HttpPut("edituser/{username}")]
        public ActionResult EditUser([FromQuery]string username, [FromBody] UserDto userDto)
        {
            var result = _userService.EditUser(username, userDto);
            return Ok(result);
        }
    }
}
