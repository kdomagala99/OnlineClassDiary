using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineClassDiaryWebAPI.Dtos;
using OnlineClassDiaryWebAPI.Services.Interfaces;

namespace OnlineClassDiaryWebAPI.Controllers
{
    [Route("api/statuscontroller")]
    [ApiController]
    public class StatusController : Controller
    {
        private readonly IStatusService _statusService;

        public StatusController(IStatusService statusService)
        {
            _statusService = statusService;
        }

        [HttpGet("getstatus/{statusId}")]
        public ActionResult GetStatus(string statusname)
        {
            var result  = _statusService.GetStatus(statusname);
            return Ok(result);
        }

        [HttpPut("editstatus/{statusId}")]
        public ActionResult EditStatus([FromQuery]string statusname, [FromBody] StatusDto statusDto)
        {
            _statusService.EditStatus(statusname, statusDto);
            return Ok();
        }
    }
}
