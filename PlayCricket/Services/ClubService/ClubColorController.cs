using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlayCricket.Services.ClubService
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubColorController : ControllerBase
    {
        // GET: api/<ClubColorController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ClubColorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ClubColorController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClubColorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClubColorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
