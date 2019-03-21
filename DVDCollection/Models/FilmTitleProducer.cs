namespace DVDCollection.Models
{
    public class FilmTitleProducer
    {
        public int FilmTitleID { get; set; }
        public int ProducerID { get; set; }

        public FilmTitle FilTitle { get; set; }
        public Producer Producer { get; set; }

    }
}