using System;
using System.Collections.Generic;

namespace Universidad.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }

        public string SecondMidName { get; set; }
        public DateTime FechaInscripcion { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}