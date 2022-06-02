using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineClassDiaryWebAPI.Dtos;
using OnlineClassDiaryWebAPI.Services.Interfaces;

namespace OnlineClassDiaryWebAPI.Controllers
{
    [Route("api/gradecontroller")]
    [ApiController]
    public class GradeController : Controller
    {
        private readonly IGradeService _gradeService;

        public GradeController(IGradeService gradeService)
        {
            _gradeService = gradeService;
        }

        [HttpGet("getgrade/{id}")]
        public ActionResult GetGrade(int id)
        {
            var result = _gradeService.GetGrade(id);
            return Ok(result);
        }

        [HttpPut("editgrade/{id}")]
        public ActionResult EditGrade(int id, [FromBody] GradeDto gradeDto)
        {
            var result = _gradeService.EditGrade(id, gradeDto);
            return Ok(result);
        }

        [HttpPost("creategrade")]
        public ActionResult CreateGrade([FromBody] GradeDto gradeDto)
        {
            var result = _gradeService.CreateGrade(gradeDto);
            return Ok(result);
        }

        [HttpDelete("deletegrade/{id}")]
        public ActionResult DeleteGrade(int id)
        {
            var result = _gradeService.DeleteGrade(id);
            return Ok(result);
        }
    }
}
