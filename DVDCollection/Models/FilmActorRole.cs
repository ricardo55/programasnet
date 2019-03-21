namespace DVDCollection.Models
{
    public class FilmActorRole
    {
        public int FilmTitleID { get; set; }
        public int ActorID { get; set; }
        public int RoleID { get; set; }
        public string CharacterName { get; set; }
        public string CharacterDesc { get; set; }


        public FilTitle FilTitle { get; set; }
        public Actor Actor { get; set; }
        public Role Rol { get; set; }  
        
    }
}