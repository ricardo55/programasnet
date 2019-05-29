using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ReservacionHotelExamen2.Models
{
    public class Customer
    {

        [Display(Name="Id")]
        public int CustomerID { get; set; }

        [Display(Name="Nombre Cliente",Prompt="Nombre del Cliente")]
        [Required(ErrorMessage="El Nombre es requerido")]
        [StringLength(20)]
        public string CustomerTitle { get; set; }

        [Display(Name="Apellido Paterno",Prompt="Apellido Paterno")]
        [Required(ErrorMessage="El Apellido es requerido")]
        [StringLength(20)]
        public string CustomerForenames { get; set; }

        [Display(Name="Apellido Materno",Prompt="Apellido Materno")]
        [Required(ErrorMessage="El Apellido es requerido")]
        [StringLength(20)]
        public string CustomerSurnames { get; set; }

        [Display(Name="Fecha Cliente")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)] 
        public DateTime CustomerDOB { get; set; }  

        [Display(Name="Calle",Prompt="Bugambilias")]
        [Required(ErrorMessage="La Calle es requerida")]
        [StringLength(20)]
        public string CustomerAdressStreet { get; set; }

        [Display(Name="Ciudad",Prompt="Zacatecas")]
        [Required(ErrorMessage="La Ciudad es requerida")]
        [StringLength(20)]
        public string CustomerAdressTown { get; set; }

        [Display(Name="Pais",Prompt="Mexico")]
        [Required(ErrorMessage="El Pais es requerido")]
        [StringLength(20)]
        public string CustomerAdressCountry { get; set; }

        [Display(Name="C.P.",Prompt="12345")]
        [DataType(DataType.PostalCode)]
        [Required(ErrorMessage="El C.P. es requerido")]
        //[StringLength(20)]
        public string CustomerAdressPostalCode { get; set; }

        [Display(Name="Telefono",Prompt="1234567890")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage="El Telefono es requerido")]
        //[StringLength(13)]
        public string CustomerHomePhone { get; set; }

        [Display(Name="Telefono Trabajo",Prompt="1234567890")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage="El Telefono es requerido")]
        //[StringLength(13)]
        public string CustomerWorkPhone { get; set; }

        [Display(Name="Celular",Prompt="1234567890")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage="El Celular es requerido")]
        //[StringLength(13)]
        public string CustomerMobilePhone { get; set; }

        [Display(Name="Email",Prompt="correo@company.com")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage="El Correo es requerido")]
        //[StringLength(20)]
        public string CustomerEmail { get; set; }

        public ICollection<Booking> Bookings { get; set; }
        public ICollection<Payment> Payments { get; set; }




        
        
    }
}