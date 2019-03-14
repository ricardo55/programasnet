using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Univ2.Models;

namespace Univ2.Models
{
    public class UniversidadContexto : DbContext
    {
        public UniversidadContexto (DbContextOptions<UniversidadContexto> options)
            : base(options)
        {
        }

        public DbSet<Univ2.Models.Estudiante> Estudiante { get; set; }

        public DbSet<Univ2.Models.Curso> Curso { get; set; }

        public DbSet<Univ2.Models.Inscripcion> Inscripcion { get; set; }
    }

}
