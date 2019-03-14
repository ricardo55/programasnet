using System;
using System.Collections.Generic;

namespace Univ2.Models
{
    public class Curso
    {
        
        public int CursoId { get; set; }
        public string Titulo { get; set; }
        public int Creditos { get; set; }

        public ICollection<Inscripcion> Inscripcion { get; set; }
    }
}
