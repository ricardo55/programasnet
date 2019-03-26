using System;
using System.Collections.Generic;
namespace ReservacionHotelExamen2.Models
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public int BookingID { get; set; }
        public int CustomerID { get; set; }
        public int PaymentMethodID { get; set; }
        public long PaymentAmount { get; set; }
        public string PaymentComments { get; set; }  

        public Booking Booking { get; set; }
        public Customer Customer { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        
    }
}