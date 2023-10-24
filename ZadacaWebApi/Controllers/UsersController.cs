using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZadacaWebApi.Data;

namespace ZadacaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        [HttpGet("getAll")]

        public ActionResult GetAll()
        {
            return Ok(StaticDb.UsersNames);
        }

        [HttpGet("{id}")]
        public ActionResult GetUserById(int id)
        {
            if(id >= 0 && id < StaticDb.UsersNames.Count)
            {
                return Ok(StaticDb.UsersNames[id]);
            }
            else
            {
                return NotFound("User not found");
            }
        }
    }
}
