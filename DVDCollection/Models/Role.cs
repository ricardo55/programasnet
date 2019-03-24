using System.Collections.Generic;

namespace DVDCollection.Models
{
    public class Role
    {
        public int RoleID { get; set; }
        public string RolName { get; set; }

         public ICollection<FilmActorRole> FilmActorRoles { get; set; }
    }
}