using System;
using System.Collections.Generic;
namespace ReservacionHotelExamen2.Models
{
    public class Customer
    {

        public int CustomerID { get; set; }
        public string CustomerTitle { get; set; }
        public string CustomerForenames { get; set; }
        public string CustomerSurnames { get; set; }
        public DateTime CustomerDOB { get; set; }   
        public string CustomerAdressStreet { get; set; }
        public string CustomerAdressTown { get; set; }
        public string CustomerAdressCountry { get; set; }
        public string CustomerAdressPostalCode { get; set; }
        public string CustomerHomePhone { get; set; }
        public string CustomerWorkPhone { get; set; }
        public string CustomerMobilePhone { get; set; }
        public string CustomerEmail { get; set; }

        public ICollection<Booking> Bookings { get; set; }
        public ICollection<Payment> Payments { get; set; }




        
        
    }
}