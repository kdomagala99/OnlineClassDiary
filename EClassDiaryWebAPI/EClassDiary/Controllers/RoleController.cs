using EClassDiary.Database;
using Microsoft.AspNetCore.Mvc;
using OnlineClassDiaryWebAPI.Entities;

namespace EClassDiary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : Controller
    {
        private readonly EClassDiaryDbContext _dbContext;
        public RoleController(EClassDiaryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost("addrole")]
        public ActionResult AddRole([FromForm] string name)
        {
            Role role = new Role();
            role.Name = name;
            _dbContext.Roles.Add(role);
            _dbContext.SaveChanges();
            return Ok();
        }


    }
}
