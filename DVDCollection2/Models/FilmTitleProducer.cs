using System.ComponentModel.DataAnnotations;
namespace DVDCollection.Models
{
    public class FilmTitleProducer
    {
        [Display(Name="ID del Productor")]
        public int FilmTitleID { get; set; }
        
        [Display(Name="ID de la Pelicula")]
        public int ProducerID { get; set; }

        public FilmTitle FilmTitle { get; set; }
        public Producer Producer { get; set; }

    }
}