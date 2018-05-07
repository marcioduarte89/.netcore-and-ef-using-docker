using DotNetCore.And.SQL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.And.SQL
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        internal void EnsureSeeded()
        {
            this.Users.Add(new User()
            {
                FirstMidName = "Marcio",
                LastName = "Duarte"
            });

            this.SaveChanges();
        }
    }
}
