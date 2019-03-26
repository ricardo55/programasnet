using System.Collections.Generic;
using System;
namespace ReservacionHotelExamen2.Models
{
    public class RoomPrice
    {
        public int RoomPriceID { get; set; }
        public long RoomPriceAmount { get; set; }

        public ICollection<Room> Rooms { get; set; }
        
    }
}