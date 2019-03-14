using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Universidad.Models;

namespace Universidad.Models
{

    public class UniversidadContext : DbContext
    {
        public UniversidadContext (DbContextOptions<UniversidadContext> options)
            : base(options)
        {
        }

        public DbSet<Universidad.Models.Student> Student { get; set; }

        public DbSet<Universidad.Models.Course> Course { get; set; }

        public DbSet<Universidad.Models.Enrollment> Enrollment { get; set; }
    }

    
}

    