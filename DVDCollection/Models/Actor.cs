namespace DVDCollection.Models
{
    public class Actor
    {
        public int ActorID { get; set; }
        public string ActorFullName { get; set; }
        public string ActorNotes { get; set; }

        public IDCollection<FilmActorRole> FilmActorRoles { get; set; }
        
    }
}