using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ReservacionHotelExamen2.Models
{
    public class Booking
    {
        [Display(Name="Id")]
        public int BookingID { get; set; }

        [Display(Name="Cliente")]
        public int CustomerID { get; set; }

        [Display(Name="Fecha de Prestamo")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateBookingMade { get; set; }

        [Display(Name = "Tiempo de Prestamo")]
        [DataType(DataType.Time)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh\\:mm}")]
        //[RegularExpression(@"((([0-1][0-9])|(2[0-3]))(:[0-5][0-9])(:[0-5][0-9])?)", ErrorMessage = "Time must be between 00:00 to 23:59")]
        public DateTime TimeBookingMade { get; set; }

        [Display(Name="Fecha Inicio Prestamo")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)] 
        public DateTime BookedStartDate { get; set; }

        [Display(Name="Fecha Final Prestamo")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)] 
        public DateTime BookedEndDate { get; set; }


        [Display(Name="Fecha del Pago")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)] 
        public DateTime TotalPaymentDueDate { get; set; }

        [Display(Name="Cantidad Total Pago")]
        [Range(0, int.MaxValue, ErrorMessage = "Porfavor introduce un numero entero valido")]
        [Required(ErrorMessage="El Total del Pago es requerido")]
        [DataType(DataType.Currency)]
        //[Column(TypeName = "decimal(18, 2)")]
        public int TotalPaymentDueAmount { get; set; }


        [Display(Name="Fecha Total del Pago")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)] 
        public DateTime TotalPaymentMadeOn { get; set; }

        [Display(Name="Comentarios",Prompt="Notas adicionales del Prestamo")]
        [StringLength(300)]
        public string BookingComments { get; set; }

        //public ICollection<Customer> Customers { get; set; }
        public Customer Customer { get; set; }
        public ICollection<BookingRoom> BookingRooms { get; set; }
        public ICollection<Payment> Payments { get; set; }
        //public Payment Payment { get; set; }

        








        
    }
}