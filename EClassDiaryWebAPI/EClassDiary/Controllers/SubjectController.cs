
using EClassDiary.Entities;
using EClassDiary.Services;
using Microsoft.AspNetCore.Mvc;

namespace EClassDiary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly SubjectService _subjectService;

        public SubjectController(SubjectService service)
        {
            _subjectService = service;
        }

        [HttpGet("getsubjects")]
        public ActionResult GetAllSubjects()
        {
            var result = _subjectService.GetAllSubjects();
            return Ok(result);
        }

        [HttpPost("createsubject")]
        public ActionResult CreateSubject([FromForm] string name)
        {
            _subjectService.CreateSubject(name);
            return Ok();
        }

        [HttpDelete("deletesubject")]
        public ActionResult DeleteSubject([FromForm] string name)
        {
            var result = _subjectService.DeleteSubject(name);
            if (result)
                return Ok();
            return BadRequest();
        }
    }
}
