using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using PlayCricket.Services.Controllers.Model;
namespace PlayCricket.Services.Controllers.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<UserDetails> userdetail { get; set; }

    }
}
