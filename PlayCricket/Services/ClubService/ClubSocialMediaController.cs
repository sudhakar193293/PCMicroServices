using Microsoft.AspNetCore.Mvc;
using PlayCricket.ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlayCricket.Services.ClubService
{
    [Route("api/clubsocialmedia")]
    [ApiController]
    public class ClubSocialMediaController : ControllerBase
    {
        // GET: api/<ClubSocialMediaController>
        [HttpGet]
        public List<ClubSocialMedia> Get()
        {
            return new List<ClubSocialMedia>();
        }

        // GET api/<ClubSocialMediaController>/5
        [HttpGet("{clubid}")]
        public ClubSocialMedia Get(int clubid)
        {
            return new ClubSocialMedia();
        }

        // POST api/<ClubSocialMediaController>
        [HttpPost]
        public void Post([FromBody] List<ClubSocialMedia> value)
        {
        }

        // PUT api/<ClubSocialMediaController>/5
        [HttpPut("{clubid}")]
        public void Put(int clubid, [FromBody] List<ClubSocialMedia> value)
        {
        }
        [HttpPut("club/{clubid}/socialmedia/{socialmediaid}")]
        public void PutSocialMedia(int clubid,int socialmediaid, ClubSocialMedia value)
        {
        }

        // DELETE api/<ClubSocialMediaController>/5
        [HttpDelete("{clubid}")]
        public void Delete(int clubid)
        {
        }
    }
}
