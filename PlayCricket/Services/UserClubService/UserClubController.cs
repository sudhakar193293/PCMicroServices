using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlayCricket.Services.UserClubService
{
    [Route("api")]
    [ApiController]
    public class UserClubController : ControllerBase
    {        
        // GET: api/<ClubUserController>
        [HttpGet("users/clubs")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ClubUserController>/5
        [HttpGet("users/{userid}/clubs")]
        public string Get(int userid)
        {
            return "value";
        }
        // GET api/<ClubUserController>/5
        [HttpGet("clubs/{clubid}/users")]
        public string GetByClubId(int clubid)
        {
            return "value";
        }

        // GET api/<ClubUserController>/5
        [HttpGet("users/{userid}/clubs/{clubid}")]
        public string Get(int userid,int clubid)
        {
            return "value";
        }
        

        // POST api/<ClubUserController>
        [HttpPost("users/clubs")]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClubUserController>/5
        [HttpPut("users/{userid}/clubs/{clubid}")]
        public void Put(int userid,int clubid, [FromBody] string value)
        {
        }

        // DELETE api/<ClubUserController>/5
        [HttpDelete("users/{userid}/clubs/{clubid}")]
        public void Delete(int clubid)
        {
        }
    }
}
