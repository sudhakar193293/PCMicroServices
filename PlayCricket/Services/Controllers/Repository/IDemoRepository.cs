using PlayCricket.Services.Controllers.Model;

namespace PlayCricket.Services.Controllers.Repository
{
    public interface IDemoRepository
    {
        IEnumerable<UserDetails> GetDemoUsers();
    }
}
