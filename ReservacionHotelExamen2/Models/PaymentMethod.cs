using System;
using System.Collections.Generic;
namespace ReservacionHotelExamen2.Models
{
    public class PaymentMethod
    {
        public int PaymentMethodID { get; set; }
        public string PaymentMethodDesc { get; set; }

        public ICollection<Payment> Payments { get; set; }


        
        
    }
}