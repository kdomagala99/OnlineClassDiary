using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineClassDiaryWebAPI.Dtos;
using OnlineClassDiaryWebAPI.Services.Interfaces;

namespace OnlineClassDiaryWebAPI.Controllers
{
    [Route("api/attendancecontroller")]
    [ApiController]
    public class AttendanceController : Controller
    {
        private readonly IAttendanceService _attendanceService;

        public AttendanceController(IAttendanceService attendanceService)
        {
            _attendanceService = attendanceService;
        }

        [HttpGet("getattendance/{id}")]
        public ActionResult GetAttendance(int id)
        {
            var result = _attendanceService.GetAttendance(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPut("editattendance/{id}")]
        public ActionResult EditAttendance(int id, [FromBody] AttendanceDto attendanceDto)
        {
            _attendanceService.EditAttendance(id, attendanceDto);
            return Ok();
        }

        [HttpPost("createattendance")]
        public ActionResult CreateAttendance([FromBody] AttendanceDto attendanceDto)
        {
            _attendanceService.CreateAttendance(attendanceDto);
            return Ok();
        }
    }
}
