using EClassDiary.Entities;
using EClassDiary.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EClassDiary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeController : Controller
    {
        private readonly GradeService _gradeService;

        public GradeController(GradeService gradeService)
        {
            _gradeService = gradeService;
        }

        [HttpGet("studentgrades/{name}/{surname}")]
        public ActionResult GetStudentGrades( string name, string surname)
        {
            var result = _gradeService.GetStudentGrades(name, surname);
            if (result == null)
                return BadRequest();
            return Ok(result);
        }

        [HttpPost("addgradetostudent")]
        public ActionResult AddGradeToStudent([FromForm] string name, [FromForm] string surname, [FromForm] decimal value, [FromForm] string subject, [FromForm] string teacherEmail)
        {
            var result = _gradeService.AddGradeToStudent(name, surname, value, subject, teacherEmail);
            if (result)
                return Ok();
            return BadRequest();
        }
        [HttpDelete("deleteallgrades")]
        public ActionResult DeleteAllGrades()
        {
            _gradeService.DeleteAllGrades();
            return Ok();
        }
    }
}
