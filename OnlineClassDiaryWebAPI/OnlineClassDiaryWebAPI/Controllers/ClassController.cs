using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineClassDiaryWebAPI.Dtos;
using OnlineClassDiaryWebAPI.Services.Interfaces;

namespace OnlineClassDiaryWebAPI.Controllers
{
    [Route("api/classcontroller")]
    [ApiController]
    public class ClassController : Controller
    {
        private readonly IClassService _classService;

        public ClassController(IClassService classService)
        {
            _classService = classService;
        }

        [HttpGet("getclass/{id}")]
        public ActionResult GetClass(int id)
        {
            var result = _classService.GetClass(id);
            return Ok(result);
        }

        [HttpPut("editclass/{id}")]
        public ActionResult EditClass([FromQuery] int id, [FromBody] ClassDto classDto)
        {
            var result = _classService.EditClass(id, classDto);
            return Ok(result);
        }

        [HttpPost("createclass")]
        public ActionResult CreateClass([FromBody] ClassDto classDto)
        {
            var result = _classService.CreateClass(classDto);
            return Ok(result);
        }

        [HttpDelete("deleteclass/{id}")]
        public ActionResult DeleteClass([FromQuery] int id)
        {
            var result = _classService.DeleteClass(id);
            return Ok(result);
        }
    }
}
