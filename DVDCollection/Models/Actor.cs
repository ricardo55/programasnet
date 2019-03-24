using System.Collections.Generic;

namespace DVDCollection.Models
{
    public class Actor
    {
        public int ActorID { get; set; }
        public string ActorFullName { get; set; }
        public string ActorNotes { get; set; }

        public ICollection<FilmActorRole> FilmActorRoles { get; set; }
        
    }
}