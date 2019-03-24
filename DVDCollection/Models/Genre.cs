using System;
using System.Collections.Generic;

namespace DVDCollection.Models
{
    public class Genre
    {
        public int GenreID { get; set; }
        public string GenreName { get; set; }

        public ICollection<FilmTitle> FilmTitles { get; set; }
        
    }
}