using System;
using System.Collections.Generic;
namespace ReservacionHotelExamen2.Models
{
    public class Booking
    {

        public int BookingID { get; set; }
        public int CustomerID { get; set; }

        public DateTime DateBookingMade { get; set; }
        public DateTime TimeBookingMade { get; set; }
        public DateTime BookedStartDate { get; set; }
        public DateTime BookedEndDate { get; set; }
        public DateTime TotalPaymentDueDate { get; set; }
        public int TotalPaymentDueAmount { get; set; }
        public DateTime TotalPaymentMadeOn { get; set; }
        public string BookingComments { get; set; }

        //public ICollection<Customer> Customers { get; set; }
        public Customer Customer { get; set; }
        public ICollection<BookingRoom> BookingRooms { get; set; }
        public ICollection<Payment> Payments { get; set; }
        //public Payment Payment { get; set; }

        








        
    }
}