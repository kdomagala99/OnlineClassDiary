using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineClassDiaryWebAPI.Services.Interfaces;

namespace OnlineClassDiaryWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeController : Controller
    {
        private readonly IGradeService _gradeService;
        public GradeController(IGradeService gradeService)
        {
            _gradeService = gradeService;
        }

        [HttpGet("studentgrades/{name}/{surname}")]
        public ActionResult GetStudentGrades(string name, string surname)
        {
            var result = _gradeService.GetStudentGrades(name, surname);
            if (result == null)
                return BadRequest();
            return Ok(result);
        }

        [HttpPost("addgradetostudent")]
        public ActionResult AddGrade([FromForm] string name, [FromForm] string surname, [FromForm] decimal value, [FromForm] string subject, [FromForm] string teacherEmail)
        {
            var result = _gradeService.AddGrade(name, surname, value, subject, teacherEmail);
            if (result)
                return Ok();
            return BadRequest();
        }

        [HttpDelete("deleteallgrades")]
        public ActionResult DeleteGrades()
        {
            _gradeService.DeleteAllGrades();
            return Ok();
        }


    }
}
