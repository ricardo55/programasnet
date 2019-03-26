using System.Collections.Generic;
using System;
namespace ReservacionHotelExamen2.Models
{
    public class RoomType
    {
        public int RoomTypeID { get; set; }
        public string RoomTypeDesc { get; set; }

        public ICollection<Room> Rooms { get; set; }
        
    }
}