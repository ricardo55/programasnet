using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DVDCollection.Models
{
    public class Certificate
    {
        [Display(Name="Id")]
        public int CertificateID { get; set; }
        [Display(Name="Descripción",Prompt="Descripción del certificado")]
        [Required(ErrorMessage="La Descripción del Certificado es requerido")]
        [StringLength(10)]
        public string CertificateName { get; set; }   

        public ICollection<FilmTitle> FilmTitles { get; set; }
        
    }
}