namespace DVDCollection.Models
{
    public class Role
    {
        public int RoleID { get; set; }
        public string RolName { get; set; }

         public IDCollection<FilmActorRole> FilmActorRoles { get; set; }
    }
}