using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ReservacionHotelExamen2.Models
{
    public class FacilitieList
    {

        [Display(Name="Id")]
        public int FacilitieListID { get; set; }

        [Display(Name="Descripción",Prompt="correo@company.com")]
        //[DataType(DataType.Text)]
        [Required(ErrorMessage="La Descripción es requerida")]
        [StringLength(100)]
        public string FacilityDesc { get; set; }


        public ICollection<RoomFacilities> RoomFacilities { get; set; }

        
        
    }
}