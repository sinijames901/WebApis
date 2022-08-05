using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginDetails.Models
{
    public class LoginContext : DbContext
    {
        //internal object lisMembers;

        public LoginContext(DbContextOptions options)
          : base(options)
        {
        }
        public DbSet<Login_dto> login_dtos { get; set; }
    }
}
