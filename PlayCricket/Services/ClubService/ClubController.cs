using Microsoft.AspNetCore.Mvc;
using PlayCricket.ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlayCricket.Services.Controllers
{
    [Route("api/club")]
    [ApiController]
    public class ClubController : ControllerBase
    {
        // GET: api/<ClubDetailController>
        [HttpGet]
        public List<Club> Get()
        {
            return new List<Club> { new Club () } ;
        }

        // GET api/<ClubDetailController>/5
        [HttpGet("{clubid}")]
        public Club Get(int clubid)
        {
            return new Club();
        }

        // POST api/<ClubDetailController>
        [HttpPost]
        public void Post([FromBody] List<Club> value)
        {
        }

        // PUT api/<ClubDetailController>/5
        [HttpPut("{clubid}")]
        public void Put(int clubid, [FromBody] Club value)
        {
        }

        // DELETE api/<ClubDetailController>/5
        [HttpDelete("{clubid}")]
        public void Delete(int clubid)
        {
        }
    }
}
