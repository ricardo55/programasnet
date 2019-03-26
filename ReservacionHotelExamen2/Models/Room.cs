using System.Collections.Generic;
using System;
namespace ReservacionHotelExamen2.Models
{
    public class Room
    {
        public int RoomID { get; set; }
        public int RoomTypeID { get; set; }
        public int RoomBandID { get; set; }
        public int RoomPriceID { get; set; }
        public string Floor { get; set; }
        public string AdditionalNotes { get; set; }

        public ICollection<Booking> Bookings { get; set; }

        public ICollection<RoomFacilities> RoomFacilities { get; set; }
        public RoomType RoomType { get; set; }
        public RoomBand RoomBand { get; set; }
        public RoomPrice RoomPrice { get; set; }
        
    }
}