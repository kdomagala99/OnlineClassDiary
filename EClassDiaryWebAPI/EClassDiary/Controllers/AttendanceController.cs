using EClassDiary.Entities;
using EClassDiary.Services;
using Microsoft.AspNetCore.Mvc;

namespace EClassDiary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : Controller
    {
        private readonly AttendanceService _attendanceService;
        public AttendanceController(AttendanceService service)
        {
            _attendanceService = service;
        }
        [HttpGet("getattendances")]
        public ActionResult GetAllAttendances()
        {
            var attendances = _attendanceService.GetAllAttendances();
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
        public ActionResult DeleteAttendance([FromForm] string studentName, [FromForm] string studentSurname, [FromForm] DateTime dateTime)
        {
            var result = _attendanceService.DeleteAttendance(studentName, studentSurname, dateTime);
            if (result)
                return Ok();
            return BadRequest();
        }

    }
}
