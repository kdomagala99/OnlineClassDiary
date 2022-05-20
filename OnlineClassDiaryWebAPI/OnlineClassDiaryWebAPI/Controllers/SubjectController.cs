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
            return Ok(result);
        }

        [HttpPost("createsubject")]
        public ActionResult CreateSubject([FromBody] SubjectDto subjectDto)
        {
            var result = _subjectService.CreateSubject(subjectDto);
            return Ok(result);
        }

        [HttpPut("editsubject/{subjectname}")]
        public ActionResult EditSubject([FromQuery]string subjectname, [FromBody]SubjectDto subjectDto)
        {
            var result = _subjectService.EditSubject(subjectname, subjectDto);
            return Ok(result);
        }

        [HttpDelete("deletesubject/{subjectname}")]
        public ActionResult DeleteSubject([FromQuery]string subjectname)
        {
            var result = _subjectService.DeleteSubject(subjectname);
            return Ok(result);
        }
    }
}
