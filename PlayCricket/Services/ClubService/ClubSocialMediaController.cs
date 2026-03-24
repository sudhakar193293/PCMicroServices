using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlayCricket.Services.ClubService
{
    [Route("api/clubsocialmedia")]
    [ApiController]
    public class ClubSocialMediaController : ControllerBase
    {
        // GET: api/<ClubSocialMediaController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ClubSocialMediaController>/5
        [HttpGet("{clubid}")]
        public string Get(int clubid)
        {
            return "value";
        }

        // POST api/<ClubSocialMediaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClubSocialMediaController>/5
        [HttpPut("{clubid}")]
        public void Put(int id, [FromBody] string value)
        {
        }
        [HttpPut("club/{clubid}/socialmedia/{socialmediaid}")]
        public void PutSocialMedia(int clubid,int socialmediaid, [FromBody] string value)
        {
        }

        // DELETE api/<ClubSocialMediaController>/5
        [HttpDelete("{clubid}")]
        public void Delete(int id)
        {
        }
    }
}
