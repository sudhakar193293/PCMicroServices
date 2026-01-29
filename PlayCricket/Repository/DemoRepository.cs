using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql;
using PlayClicket.DataContext;
using PlayClicket.Model;
using System.Collections.Generic;
using System.Reflection;

namespace PlayClicket.Repository
{
    public class DemoRepository : IDemoRepository
    {
        private readonly AppDbContext _context;
        IConfiguration Configuration { get; }
        public DemoRepository(AppDbContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }

        IEnumerable<UserDetails> IDemoRepository.GetDemoUsers()
        {
            try
            {
                List<UserDetails> objUserDetail = [];
                objUserDetail.AddRange(new UserDetails
                {
                    id = 1,
                    firstname = "sudhakar",
                    lastname = "pelleti",
                    gender = "M"
                },
                new UserDetails{
                    id = 2,
                    firstname = "Tarun",
                    lastname = "Gupta",
                    gender = "M"
                });
                var details= _context.userdetail;
                return _context.userdetail;
            }
            catch (Exception ex) 
            { 
                return [];
            }
        }

    }
}
