using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ReservacionHotelExamen2.Models
{
    public class PaymentMethod
    {
        [Display(Name="Id")]
        public int PaymentMethodID { get; set; }

        [Display(Name="Descripción",Prompt="Notas adicionales del Pago")]
        [StringLength(300)]
        public string PaymentMethodDesc { get; set; }

        public ICollection<Payment> Payments { get; set; }


        
        
    }
}