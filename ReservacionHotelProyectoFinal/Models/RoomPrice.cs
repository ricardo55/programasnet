using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
namespace ReservacionHotelExamen2.Models
{
    public class RoomPrice
    {
        [Display(Name="Id")]
        public int RoomPriceID { get; set; }

        [Display(Name="Precio",Prompt="Precio de Cuarto")]
        [Range(0, double.MaxValue, ErrorMessage = "Porfavor introduce un numero entero valido")]
        [Required(ErrorMessage="El Precio del Cuarto es requerido")]
        public long RoomPriceAmount { get; set; }

        

        public ICollection<Room> Rooms { get; set; }
        
    }
}