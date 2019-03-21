using System;
using System.Collection.Generic;

namespace DVDCollection.Models
{
    public class FilTitle
    {
        public int FilTitleID { get; set; }
        public int GenreID { get; set; }
        public int CertificateID { get; set; }
        public string FilmName { get; set; }
        public string FilmStory { get; set; }  
        public DateTime FilmReleaseDate { get; set; }
        public int FilmDuration { get; set; }
        public string FilmAdditionalInfo { get; set; }  

        public IDCollection<FilmActorRole> FilmActorRoles { get; set; }
        public IDCollection<FilmTitleProducer> FilmTitleProducers { get; set; }
        public Genre Genre { get; set; }
        public Certificate Certificate { get; set; }

    }
}