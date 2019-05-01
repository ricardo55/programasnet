using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DVDCollection.Models
{
    public class Genre
    {
        [Display(Name="Id")]
        public int GenreID { get; set; }
        
        [Display(Name="Descripción",Prompt="Descripción del Genero")]
        [Required(ErrorMessage="La Descripción del Genero es requerido")]
        [StringLength(100)]
        public string GenreName { get; set; }

        public ICollection<FilmTitle> FilmTitles { get; set; }
        
    }
}