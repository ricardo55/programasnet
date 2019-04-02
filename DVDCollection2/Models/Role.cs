using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DVDCollection.Models
{
    public class Role
    {
        [Display(Name="Id")]
        public int RoleID { get; set; }

        [Display(Name="Descripción",Prompt="Descripción del Rol")]
        [Required(ErrorMessage="La Descripción del Rol es requerido")]
        [StringLength(100)]
        public string RolName { get; set; }

         public ICollection<FilmActorRole> FilmActorRoles { get; set; }
    }
}