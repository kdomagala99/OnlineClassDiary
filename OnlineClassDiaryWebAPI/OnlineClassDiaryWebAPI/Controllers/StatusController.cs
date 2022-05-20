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
        public ActionResult GetStatus(int statusId)
        {
            var result  = _statusService.GetStatus(statusId);
            return Ok(result);
        }

        [HttpPut("editstatus/{statusId}")]
        public ActionResult EditStatus([FromQuery]int statusId, [FromBody] StatusDto statusDto)
        {
            var result = _statusService.EditStatus(statusId, statusDto);
            return Ok(result);
        }
    }
}
