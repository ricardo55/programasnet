using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ReservacionHotelExamen2.Models
{
    public class Guest
    {
        [Display(Name="Id")]
        public int GuestID { get; set; }

        [Display(Name="Nombre Huesped",Prompt="Ricardo")]
        [Required(ErrorMessage="El Nombre es requerido")]
        [StringLength(100)]
        public string GuestTitle { get; set; }


        [Display(Name="Apellido Paterno",Prompt="Kaiser")]
        [Required(ErrorMessage="El Apellido es requerido")]
        [StringLength(100)]
        public string GuestForenames { get; set; }

        [Display(Name="Apellido Materno",Prompt="Weissy")]
        [Required(ErrorMessage="El Apellido es requerido")]
        [StringLength(100)]
        public string GuestSurnames { get; set; }

        [Display(Name="Fecha DOB")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)] 
        public DateTime GuestDOB { get; set; }   

        [Display(Name="Calle",Prompt="Bugambilias")]
        [Required(ErrorMessage="La Calle es requerida")]
        [StringLength(20)]
        public string GuestAdressStreet { get; set; }

        [Display(Name="Ciudad",Prompt="Zacatecas")]
        [Required(ErrorMessage="La Ciudad es requerida")]
        [StringLength(20)]
        public string GuestAdressTown { get; set; }

        [Display(Name="Pais",Prompt="Mexico")]
        [Required(ErrorMessage="El Pais es requerido")]
        [StringLength(20)]
        public string GuestAdressCounty { get; set; }

        [Display(Name="C.P.",Prompt="12345")]
        [DataType(DataType.PostalCode)]
        [Required(ErrorMessage="El C.P. es requerido")]
        public string GuestAdressPostalCode { get; set; }

        [Display(Name="Email",Prompt="correo@company.com")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage="El Correo es requerido")]
        public string GuestContactPhone { get; set; }

        public ICollection<BookingRoom> BookingRooms { get; set; }
        
        
    }
}