using System;
using System.Collections.Generic;

namespace DVDCollection.Models
{
    public class FilmTitle
    {
        public int FilmTitleID { get; set; }
        public int GenreID { get; set; }
        public int CertificateID { get; set; }
        public string FilmName { get; set; }
        public string FilmStory { get; set; }  
        public DateTime FilmReleaseDate { get; set; }
        public int FilmDuration { get; set; }
        public string FilmAdditionalInfo { get; set; }  

        public ICollection<FilmActorRole> FilmActorRoles { get; set; }
        public ICollection<FilmTitleProducer> FilmTitleProducers { get; set; }
        public Genre Genre { get; set; }
        public Certificate Certificate { get; set; }

    }
}