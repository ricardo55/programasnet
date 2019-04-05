using System.ComponentModel.DataAnnotations;
namespace ReservacionHotelExamen2.Models
{
    public class RoomFacilities
    {

        [Display(Name="Id")]
        public int RoomID { get; set; }

        [Display(Name="Faclidad")]
        public int FacilitieListID { get; set; }

        [Display(Name="Detalles",Prompt="Falta ...")]
        [StringLength(100)]
        public string FacilityDetails { get; set; }

        

        public FacilitieList FacilitieList { get; set; }
        public Room Room { get; set; }
        
        
    }
}