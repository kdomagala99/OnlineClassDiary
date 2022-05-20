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

        [HttpGet("getrole/{id}")]
        public ActionResult GetRole(int id)
        {
            var result = _roleService.GetRole(id);
            return Ok(result);
        }

        [HttpPut("editrole/{id}")]
        public ActionResult EditRole([FromQuery] int id, [FromBody] RoleDto roleDto)
        {
            var result = _roleService.EditRole(id, roleDto);
            return Ok(result);
        }

        [HttpPost("createrole")]
        public ActionResult CreateRole([FromBody] RoleDto roleDto)
        {
            var result = _roleService.CreateRole(roleDto);
            return Ok(result);
        }

        [HttpDelete("deleterole/{id}")]
        public ActionResult DeleteRole([FromQuery] int id)
        {
            var result = _roleService.DeleteRole(id);
            return Ok(result);
        }
    }
}
