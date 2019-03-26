using System;
using System.Collections.Generic;
namespace ReservacionHotelExamen2.Models
{
    public class FacilitieList
    {

        public int FacilitieListID { get; set; }
        public string FacilityDesc { get; set; }

        public ICollection<RoomFacilities> RoomFacilities { get; set; }

        
        
    }
}