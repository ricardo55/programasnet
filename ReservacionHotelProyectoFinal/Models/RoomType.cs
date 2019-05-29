using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace ReservacionHotelExamen2.Models
{
    public class RoomType
    {
        [Display(Name="Id")]
        public int RoomTypeID { get; set; }

        [Display(Name="Descripción",Prompt="Este...")]
        [StringLength(100)]
        public string RoomTypeDesc { get; set; }
        

        public ICollection<Room> Rooms { get; set; }
        
    }
}