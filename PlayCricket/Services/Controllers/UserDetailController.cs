using Microsoft.AspNetCore.Mvc;
using PlayCricket.Services.Controllers.Model;
using PlayCricket.Services.Controllers.Repository;
namespace PlayCricket.Services.Controllers
{
    [ApiController]
    [Route("userdetail")]
    public class UserDetailController : ControllerBase
    {
        private readonly IDemoRepository _demoRepository;
        public UserDetailController(IDemoRepository demoRepository) { 
        _demoRepository = demoRepository;
        }
        [HttpGet(Name = "GetUserDetail")]
        public IEnumerable<UserDetails> Get()   
            {
            return _demoRepository.GetDemoUsers();
        }
    }
}
