namespace ReservacionHotelExamen2.Models
{
    public class RoomFacilities
    {

        public int RoomID { get; set; }
        public int FacilityID { get; set; }
        public string FacilityDetails { get; set; }

        public FacilitieList FacilitieList { get; set; }
        public Room Room { get; set; }
        
        
    }
}