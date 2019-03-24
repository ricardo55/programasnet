using System;
using System.Collections.Generic;


namespace DVDCollection.Models
{
    public class Producer
    {
        public int ProducerID {get; set; }
        public string ProducerName { get; set; }
        public string ProducerEmail { get; set; }
        public string ProducerWeb { get; set; }

        public ICollection<FilmTitleProducer> FilmTitleProducers { get; set; }
        
    }
}