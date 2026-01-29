using PlayClicket.Model;

namespace PlayClicket.Repository
{
    public interface IDemoRepository
    {
        IEnumerable<UserDetails> GetDemoUsers();
    }
}
