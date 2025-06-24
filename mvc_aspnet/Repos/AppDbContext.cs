using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCAspnet.Models;

namespace MVCAspnet.Repos
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Show> Shows { get; set; }
        public DbSet<Character> Characters { get; set; }
    }
}