using System;
using System.Collections.Generic;

namespace DVDCollection.Models
{
    public class Certificate
    {
       public int CertificateID { get; set; }
       public string CertificateName { get; set; }   

        public ICollection<FilmTitle> FilmTitles { get; set; }
        
    }
}