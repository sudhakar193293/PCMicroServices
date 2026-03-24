using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlayCricket.Services.Controllers
{
    [Route("api/userclub")]
    [ApiController]
    public class UserClubDetailController : ControllerBase
    {
        // GET: api/<ClubUserController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ClubUserController>/5
        [HttpGet("user/{userid}/clubs")]
        public string Get(int userid)
        {
            return "value";
        }

        // GET api/<ClubUserController>/5
        [HttpGet("user/{userid}/club/{clubid}")]
        public string Get(int userid,int clubid)
        {
            return "value";
        }
        

        // POST api/<ClubUserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClubUserController>/5
        [HttpPut("user/{userid}/club/{clubid}")]
        public void Put(int userid,int clubid, [FromBody] string value)
        {
        }

        // DELETE api/<ClubUserController>/5
        [HttpDelete("user/{userid}/club/{clubid}")]
        public void Delete(int id)
        {
        }
    }
}
