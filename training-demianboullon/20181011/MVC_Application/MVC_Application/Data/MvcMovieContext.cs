using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Application.Models;

namespace MVC_Application.Models
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Application.Models.Movie> Movie { get; set; }

        public DbSet<MVC_Application.Models.Area> Area { get; set; }
    }
}
