using System.ComponentModel.DataAnnotations;
namespace DVDCollection.Models
{
    public class FilmActorRole
    {
        [Display(Name="Id")]
        public int FilmTitleID { get; set; }

        [Required(ErrorMessage="El Actor es requerido")]
        [Display(Name="Actor")]
        public int ActorID { get; set; }

        [Required(ErrorMessage="El Rol es requerido")]
        [Display(Name="Rol")]
        public int RoleID { get; set; }

        [Display(Name="Personaje",Prompt="Nombre del Personaje")]
        [StringLength(60)]
        public string CharacterName { get; set; }
        
        [Display(Name="Descripción",Prompt="Descripción del Personaje")]
        [StringLength(100)]
        public string CharacterDesc { get; set; }


        public FilmTitle FilmTitle { get; set; }
        public Actor Actor { get; set; }
        public Role Rol { get; set; }  
        
    }
}