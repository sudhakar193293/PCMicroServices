using Microsoft.AspNetCore.Mvc;
using PlayCricket.ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlayCricket.Services.ClubService
{
    [Route("api/clubs")]
    [ApiController]
    public class ClubSocialMediaController : ControllerBase
    {
        // GET: api/<ClubSocialMediaController>
        [HttpGet("socialmedia")]
        public List<ClubSocialMedia> Get()
        {
            return new List<ClubSocialMedia>();
        }

        // GET api/<ClubSocialMediaController>/5
        [HttpGet("{clubid}/socialmedia")]
        public ClubSocialMedia Get(int clubid)
        {
            return new ClubSocialMedia();
        }

        // POST api/<ClubSocialMediaController>
        [HttpPost("socialmedia")]
        public void Post([FromBody] List<ClubSocialMedia> value)
        {
        }

        // PUT api/<ClubSocialMediaController>/5
        [HttpPut("{clubid}/socialmedia")]
        public void Put(int clubid, [FromBody] List<ClubSocialMedia> value)
        {
        }
        [HttpPut("{clubid}/socialmedia/{socialmediaid}")]
        public void PutSocialMedia(int clubid,int socialmediaid, ClubSocialMedia value)
        {
        }

        // DELETE api/<ClubSocialMediaController>/5
        [HttpDelete("{clubid}/socialmedia")]
        public void Delete(int clubid)
        {
        }
    }
}
