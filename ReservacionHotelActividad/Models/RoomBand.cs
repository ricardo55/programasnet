using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
namespace ReservacionHotelExamen2.Models
{
    public class RoomBand
    {
        [Display(Name="Id")]
        public int RoomBandID { get; set; }

        [Display(Name="Notas Grupo",Prompt="Notas")]
        [StringLength(100)]
        public string BandDesc { get; set; }

        public ICollection<Room> Rooms { get; set; }
        
    }
}