using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DVDCollection.Models
{
    public class FilmTitle
    {
        [Display(Name="Id")]
        public int FilmTitleID { get; set; }

        [Display(Name="Genero")]
        public int GenreID { get; set; }

        [Display(Name="Certificado")]
        public int CertificateID { get; set; }

        [Display(Name="Descripción",Prompt="Descripción de la Pelicula")]
        [Required(ErrorMessage="La Descripción de la Pelicula es requerida")]
        [StringLength(100)]
        public string FilmName { get; set; }

        [Display(Name="Sinopsis",Prompt="Sinopsis de la Pelicula")]
        [Required(ErrorMessage="La Sinopsis de la Pelicula es requerida")]
        [StringLength(300)]
        public string FilmStory { get; set; }  

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)] 
        public DateTime FilmReleaseDate { get; set; }


        [DataType(DataType.Duration)]
        public int FilmDuration { get; set; }

        [Display(Name="Notas",Prompt="Notas adicionales de la Pelicula")]
        [StringLength(300)]
        public string FilmAdditionalInfo { get; set; }  

        public ICollection<FilmActorRole> FilmActorRoles { get; set; }
        public ICollection<FilmTitleProducer> FilmTitleProducers { get; set; }
        public Genre Genre { get; set; }
        public Certificate Certificate { get; set; }

    }
}