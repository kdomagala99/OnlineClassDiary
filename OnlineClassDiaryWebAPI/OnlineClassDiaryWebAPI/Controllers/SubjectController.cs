using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineClassDiaryWebAPI.Dtos;
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

        [HttpGet("getsubject/{subjectname}")]
        public ActionResult GetSubject(string subjectname)
        {
            var result = _subjectService.GetSubject(subjectname);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost("createsubject")]
        public ActionResult CreateSubject([FromBody] SubjectDto subjectDto)
        {
            _subjectService.CreateSubject(subjectDto);
            return Ok();
        }

        [HttpPut("editsubject/{subjectname}")]
        public ActionResult EditSubject(string subjectname, [FromBody]SubjectDto subjectDto)
        {
            _subjectService.EditSubject(subjectname, subjectDto);
            return Ok();
        }

        [HttpDelete("deletesubject/{subjectname}")]
        public ActionResult DeleteSubject(string subjectname)
        {
            _subjectService.DeleteSubject(subjectname);
            return Ok();
        }
    }
}
