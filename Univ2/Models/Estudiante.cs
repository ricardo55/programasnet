using System;
using System.Collections.Generic;

namespace Univ2.Models
{
    public class Estudiante
    {
        
        public int EstudianteId { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInscripcion { get; set; }

        public ICollection<Inscripcion> Inscripcion { get; set; }
    }
}
