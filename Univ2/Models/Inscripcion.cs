using System;
using System.Collections.Generic;

namespace Univ2.Models
{
    public enum Grado
    {
        A,B,C,D,F

    }

    public class Inscripcion
    {
        public int InscripcionId { get; set; }
        public int CursoId { get; set; }
        public int EstudianteId { get; set; }
        public Grado? Grado { get; set; }

        public Curso Curso { get; set; }
        public Estudiante Estudiante { get; set; }
    }
}
