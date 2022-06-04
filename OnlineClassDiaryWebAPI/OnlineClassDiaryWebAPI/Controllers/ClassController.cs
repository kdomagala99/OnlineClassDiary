﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineClassDiaryWebAPI.Dtos;
using OnlineClassDiaryWebAPI.Services.Interfaces;

namespace OnlineClassDiaryWebAPI.Controllers
{
    [Route("api/classcontroller")]
    [ApiController]
    public class ClassController : Controller
    {
        private readonly IClassService _classService;

        public ClassController(IClassService classService)
        {
            _classService = classService;
        }

        [HttpGet("getclass/{id}")]
        public ActionResult GetClass(int id)
        {
            var result = _classService.GetClass(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPut("editclass/{id}")]
        public ActionResult EditClass(int id, [FromBody] ClassDto classDto)
        {
            _classService.EditClass(id, classDto);
            return Ok();
        }

        [HttpPost("createclass")]
        public ActionResult CreateClass([FromBody] ClassDto classDto)
        {
            _classService.CreateClass(classDto);
            return Ok();
        }

        [HttpDelete("deleteclass/{id}")]
        public ActionResult DeleteClass(int id)
        {
            _classService.DeleteClass(id);
            return Ok();
        }
    }
}
