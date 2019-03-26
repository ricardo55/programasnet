using System;
using System.Collections.Generic;
namespace ReservacionHotelExamen2.Models
{
    public class Guest
    {
        public int GuestID { get; set; }
        public string GuestTitle { get; set; }
        public string GuestForenames { get; set; }
        public string GuestSurnames { get; set; }
        public DateTime GuestDOB { get; set; }   
        public string GuestAdressStreet { get; set; }
        public string GuestAdressTown { get; set; }
        public string GuestAdressCounty { get; set; }
        public string GuestAdressPostalCode { get; set; }
        public string GuestContactPhone { get; set; }

        public ICollection<BookingRoom> BookingRooms { get; set; }
        
        
    }
}