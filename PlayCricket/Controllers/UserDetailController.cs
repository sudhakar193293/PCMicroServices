using Microsoft.AspNetCore.Mvc;
using PlayClicket.Model;
using PlayClicket.Repository;
namespace PlayClicket.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
