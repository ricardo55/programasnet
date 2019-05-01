using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace DVDCollection.Models
{
    public class Producer
    {
        [Display(Name="Id")]
        public int ProducerID {get; set; }

        [Display(Name="Nombre",Prompt="Nombre completo del productor")]
        [Required(ErrorMessage="El nombre del productor es requerido")]
        [StringLength(60)]
        public string ProducerName { get; set; }

        [Display(Name="Correo",Prompt="Dirección de correo del productor")]
        [DataType(DataType.EmailAddress)]
        public string ProducerEmail { get; set; }

        [Display(Name="URL",Prompt="Dirección del sitio web del productor")]
        [DataType(DataType.Url)]
        public string ProducerWeb { get; set; }

        public ICollection<FilmTitleProducer> FilmTitleProducers { get; set; }
        
    }
}