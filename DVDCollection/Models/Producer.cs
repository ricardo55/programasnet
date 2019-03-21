using System;
using System.Collection.Generic;


namespace DVDCollection.Models
{
    public class Producer
    {
        public int ProducerID {get; set; }
        public string ProducerName { get; set; }
        public string ProducerEmail { get; set; }
        public string ProducerWeb { get; set; }

        public IDCollection<FilTitleProducer> FilmTitleProducers { get; set; }
        
    }
}