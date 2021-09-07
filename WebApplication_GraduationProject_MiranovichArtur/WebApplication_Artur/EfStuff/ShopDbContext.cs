using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Artur.EfStuff.Model;

namespace WebApplication_Artur.EfStuff
{
    public class ShopDbContext : DbContext
    {

        public ShopDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }


    }
}
