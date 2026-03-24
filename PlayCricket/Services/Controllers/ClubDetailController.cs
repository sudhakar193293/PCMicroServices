using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlayCricket.Services.Controllers
{
    [Route("api/clubdetail")]
    [ApiController]
    public class ClubDetailController : ControllerBase
    {
        // GET: api/<ClubDetailController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ClubDetailController>/5
        [HttpGet("{clubid}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ClubDetailController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClubDetailController>/5
        [HttpPut("{clubid}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClubDetailController>/5
        [HttpDelete("{clubid}")]
        public void Delete(int id)
        {
        }
    }
}
