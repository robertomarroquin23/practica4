using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using practica4.Models;

namespace practica4.Data
{
    public class practica4Context : DbContext
    {
        public practica4Context (DbContextOptions<practica4Context> options)
            : base(options)
        {
        }

        public DbSet<practica4.Models.Movie> Movie { get; set; } = default!;
    }
}
