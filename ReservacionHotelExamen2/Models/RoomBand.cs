using System.Collections.Generic;
using System;
namespace ReservacionHotelExamen2.Models
{
    public class RoomBand
    {
        public int RoomBandID { get; set; }
        public string BandDesc { get; set; }

        public ICollection<Room> Rooms { get; set; }
        
    }
}