using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DVDCollection.Models
{
    public class Actor
    {
        [Display(Name="Id")]
        public int ActorID { get; set; }
        [Display(Name="Nombre",Prompt="Nombre completo del actor")]
        [Required(ErrorMessage="El nombre del actor es requerido")]
        [StringLength(60)]
        public string ActorFullName { get; set; }
        [Display(Name="Notas",Prompt="Notas adicionales del Actor")]
        [StringLength(300)]
        public string ActorNotes { get; set; }

        public ICollection<FilmActorRole> FilmActorRoles { get; set; }
        
    }
}