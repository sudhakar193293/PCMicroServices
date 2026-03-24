using Microsoft.AspNetCore.Mvc;
using PlayCricket.ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlayCricket.Services.ClubService
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubColorController : ControllerBase
    {
        // GET: api/<ClubColorController>
        [HttpGet]
        public List<ClubColor> Get()
        {
            return new List<ClubColor>();
        }

        // GET api/<ClubColorController>/5
        [HttpGet("{clubid}")]
        public ClubColor Get(int clubid)
        {
            return new ClubColor();
        }

        // POST api/<ClubColorController>
        [HttpPost]
        public void Post([FromBody] ClubColor value)
        {
        }

        // PUT api/<ClubColorController>/5
        [HttpPut("{clubid}")]
        public void Put(int clubid, [FromBody] ClubColor value)
        {
        }

        // DELETE api/<ClubColorController>/5
        [HttpDelete("{clubid}")]
        public void Delete(int clubid)
        {
        }
    }
}
