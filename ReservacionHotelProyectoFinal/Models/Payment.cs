using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ReservacionHotelExamen2.Models
{
    public class Payment
    {
        [Display(Name="Id")]
        public int PaymentID { get; set; }

        [Display(Name="Prestamos")]
        public int BookingID { get; set; }

        [Display(Name="Cliente")]
        public int CustomerID { get; set; }

        [Display(Name="Metodo de Pago")]
        [Range(0, int.MaxValue, ErrorMessage = "Porfavor introduce un numero entero valido")]
        [Required(ErrorMessage="El Metodo de Pago es requerido")]
        public int PaymentMethodID { get; set; }

        [Display(Name="Cantidad de Pago",Prompt="1000")]
        [Range(0, int.MaxValue, ErrorMessage = "Porfavor introduce una cantidad valido")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage="La Cantidad del Pago es requerido")]
        public long PaymentAmount { get; set; }

        [Display(Name="Comentarios",Prompt="Notas adicionales del Pago")]
        [StringLength(300)]
        public string PaymentComments { get; set; }  

        public Booking Booking { get; set; }
        public Customer Customer { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        
    }
}