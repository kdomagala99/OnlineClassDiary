using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineClassDiaryWebAPI.Services.Interfaces;
using System;

namespace OnlineClassDiaryWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : Controller
    {
        private readonly IAttendanceService _attendanceService;
        public AttendanceController(IAttendanceService attendanceService)
        {
            _attendanceService = attendanceService;
        }

        [HttpGet("getattendances")]
        public ActionResult GetAttendances()
        {
            var attendances = _attendanceService.GetAttendances();
            return Ok(attendances);
        }

        [HttpPost("addattendance")]
        public ActionResult AddAttendance([FromForm] string teacherEmail, [FromForm] string status, [FromForm] string studentName, [FromForm] string studentSurname, [FromForm] DateTime date)
        {
            var result = _attendanceService.AddAttendance(teacherEmail, status, studentName, studentSurname, date);
            if (result)
                return Ok();
            return BadRequest();
        }

        [HttpDelete("deleteattendance")]
        public ActionResult DeleteAttendance([FromForm] string studentName, [FromForm] string studentEmail, [FromForm] DateTime dateTime)
        {
            var result = _attendanceService.RemoveAttendance(studentName, studentEmail, dateTime);
            if (result)
                return Ok();
            return BadRequest();
        }
    }
}
