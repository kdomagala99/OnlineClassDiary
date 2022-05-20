using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineClassDiaryWebAPI.Dtos;
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
            var result = _semesterService.CreateSemester(semesterDto);
            return Ok(result);
        }

        [HttpPut("editsemester/{semesterId}")]
        public ActionResult EditSemester([FromQuery]int semesterId, [FromBody] SemesterDto semesterDto)
        {
            var result = _semesterService.EditSemester(semesterId, semesterDto);
            return Ok(result);
        }

        [HttpDelete("deletesemester/{semesterId}")]
        public ActionResult DeleteSemester([FromQuery]int semesterId)
        {
            var result = _semesterService.DeleteSemester(semesterId);
            return Ok(result);
        }
    }
}
