using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineClassDiaryWebAPI.Dtos;
using OnlineClassDiaryWebAPI.Services.Interfaces;

namespace OnlineClassDiaryWebAPI.Controllers
{
    [Route("api/rolecontroller")]
    [ApiController]
    public class RoleController : Controller
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet("getrole/{name}")]
        public ActionResult GetRole(string name)
        {
            var result = _roleService.GetRole(name);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPut("editrole/{name}")]
        public ActionResult EditRole(string name, [FromBody] RoleDto roleDto)
        {
            _roleService.EditRole(name, roleDto);
            return Ok();
        }

        [HttpPost("createrole")]
        public ActionResult CreateRole([FromBody] RoleDto roleDto)
        {
            _roleService.CreateRole(roleDto);
            return Ok();
        }

        [HttpDelete("deleterole/{name}")]
        public ActionResult DeleteRole(string name)
        {
            _roleService.DeleteRole(name);
            return Ok();
        }
        [HttpGet("getroles")]
        public ActionResult GetRoles()
        {
            var roles = _roleService.GetRoles();
            return Ok(roles);
        }
    }
}
