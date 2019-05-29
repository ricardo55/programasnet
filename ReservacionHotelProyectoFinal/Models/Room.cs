using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
namespace ReservacionHotelExamen2.Models
{
    public class Room
    {
        [Display(Name="Id")]
        public int RoomID { get; set; }

        [Display(Name="Tipo",Prompt="Tipo de Cuarto")]
        [Range(0, int.MaxValue, ErrorMessage = "Porfavor introduce un numero entero valido")]
        [Required(ErrorMessage="El Tipo de Cuarto es requerido")]
        public int RoomTypeID { get; set; }

        [Display(Name="Grupo",Prompt="Grupo de Cuarto")]
        [Range(0, int.MaxValue, ErrorMessage = "Porfavor introduce un numero entero valido")]
        [Required(ErrorMessage="El Grupo de Cuarto es requerido")]
        public int RoomBandID { get; set; }

        [Display(Name="Precio",Prompt="Precio de Cuarto")]
        [Range(0, int.MaxValue, ErrorMessage = "Porfavor introduce un numero entero valido")]
        [Required(ErrorMessage="El Precio del Cuarto es requerido")]
        public int RoomPriceID { get; set; }

        [Display(Name="Piso",Prompt="Piso 2")]
        [Required(ErrorMessage="El Piso es requerido")]
        [StringLength(10)]
        public string Floor { get; set; }


        [Display(Name="Notas Adicionales",Prompt="Notas")]
        [StringLength(100)]
        public string AdditionalNotes { get; set; }

        public ICollection<Booking> Bookings { get; set; }

        public ICollection<RoomFacilities> RoomFacilities { get; set; }
        public RoomType RoomType { get; set; }
        public RoomBand RoomBand { get; set; }
        public RoomPrice RoomPrice { get; set; }
        
    }
}