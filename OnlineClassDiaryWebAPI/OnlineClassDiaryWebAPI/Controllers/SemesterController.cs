using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineClassDiaryWebAPI.Dtos;
using OnlineClassDiaryWebAPI.Entities;
using OnlineClassDiaryWebAPI.Services.Interfaces;

namespace OnlineClassDiaryWebAPI.Controllers
{
    [Route("api/semestercontroller")]
    [ApiController]
    public class SemesterController : Controller
    {
        private readonly ISemesterService _semesterService;

        public SemesterController(ISemesterService semesterService)
        {
            _semesterService = semesterService;
        }

        [HttpGet("getsemesters")]
        public ActionResult GetSemesters()
        {
            var result = _semesterService.GetSemesters();
            return Ok(result);
        }

        [HttpGet("getsemester/{semesterId}")]
        public ActionResult GetSemester(int semesterId)
        {
            var result = _semesterService.GetSemester(semesterId);
            return Ok(result);
        }

        [HttpPost("createsemester")]
        public ActionResult CreateSemester([FromBody] SemesterDto semesterDto)
        {
            _semesterService.CreateSemester(semesterDto);
            return Ok();
        }

        [HttpPut("editsemester/{semesterId}")]
        public ActionResult EditSemester(int semesterId, [FromBody] SemesterDto semesterDto)
        {
            _semesterService.EditSemester(semesterId, semesterDto);
            return Ok();
        }

        [HttpDelete("deletesemester/{semesterId}")]
        public ActionResult DeleteSemester([FromQuery]int semesterId)
        {
            _semesterService.DeleteSemester(semesterId);
            return Ok();
        }
    }
}
