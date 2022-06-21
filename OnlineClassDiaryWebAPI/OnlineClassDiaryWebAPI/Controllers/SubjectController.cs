using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineClassDiaryWebAPI.Services.Interfaces;

namespace OnlineClassDiaryWebAPI.Controllers
{
    [Route("api/subjectcontroller")]
    [ApiController]
    public class SubjectController : Controller
    {
        private readonly ISubjectService _subjectService;

        public SubjectController(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        [HttpGet("getsubjects")]
        public ActionResult GetSubjects()
        {
            var result = _subjectService.GetSubjects();
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

