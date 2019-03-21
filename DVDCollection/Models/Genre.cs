using System;
using System.Collection.Generic;

namespace DVDCollection.Models
{
    public class Genre
    {
        public int GenreID { get; set; }
        public string GenreName { get; set; }

        public IDCollection<FilTitle> FilmTitles { get; set; }
        
    }
}