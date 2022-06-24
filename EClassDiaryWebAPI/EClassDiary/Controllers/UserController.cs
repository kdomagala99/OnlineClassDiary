using EClassDiary.Entities;
using EClassDiary.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EClassDiary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly UserService _userService;

        public UserController(UserService service)
        {
            _userService = service;
        }

        [HttpGet("getuser/{email}")]
        public ActionResult GetUser(string email)
        {
            var user = _userService.GetUser(email);
            if (user == null)
                return BadRequest();
            return Ok(user);
        }

        [HttpGet("getallusers")]
        public ActionResult GetAllUsers()
        {
            return Ok(_userService.GetAllUsers());
        }

        [HttpPost("adduser")]
        public ActionResult AddUser([FromForm] string email, [FromForm] string password, [FromForm] string name, [FromForm] string surname, [FromForm] string role, [FromForm] string? childEmail)
        {
            var result = _userService.AddUser(email, password, name, surname, role, childEmail);
            if (result)
                return Ok();
            return BadRequest();
        }

        [HttpPost("login")]
        public ActionResult LoginUser([FromForm] string email, [FromForm] string password)
        {
            var loginStatus = _userService.LoginUser(email, password);
            if (loginStatus)
                return Ok();
            return BadRequest();
        }
    }
}
