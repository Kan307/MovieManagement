using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Models;

namespace MovieManagement.Data
{
    public class MovieManagementContext : DbContext
    {
        public MovieManagementContext (DbContextOptions<MovieManagementContext> options)
            : base(options)
        {
        }

        public DbSet<MovieManagement.Models.Movie> Movie { get; set; } = default!;
    }
}
