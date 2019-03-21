using System;
using System.Collection.Generic;

namespace DVDCollection.Models
{
    public class Certificate
    {
       public int CertificateID { get; set; }
       public string CertificateName { get; set; }   

        public IDCollection<FilmTitle> FilmTitles { get; set; }
        
    }
}