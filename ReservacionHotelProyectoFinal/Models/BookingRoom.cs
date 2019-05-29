using System.ComponentModel.DataAnnotations;
namespace ReservacionHotelExamen2.Models
{
    public class BookingRoom
    {

        [Display(Name="Id")]
        public int BookingID { get; set; }

        [Display(Name="Cuarto")]
        public int RoomID { get; set; }

        [Display(Name="Huesped")]
        public int GuestID { get; set; }


        
        public Booking Booking { get; set; }
        public Room Room { get; set; }
        public Guest Guest { get; set; }
        
        
    }
}