using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using waTestApp.Models;

namespace waTestApp.Data
{
    public class waTestAppContext : DbContext
    {
        public waTestAppContext (DbContextOptions<waTestAppContext> options)
            : base(options)
        {
        }

        public DbSet<Movie>? Movie { get; set; }
    }
}
