using ReservacionHotelExamen2.Models;
using Microsoft.EntityFrameworkCore;

namespace ReservacionHotelExamen2.Models
{
    public class ReservacionHotelContext : DbContext
    {
        public ReservacionHotelContext(DbContextOptions<ReservacionHotelContext> options) : base(options)
        {
        }

        public DbSet<Booking> Booking { get; set; }
        public DbSet<BookingRoom> BookingRoom { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<FacilitieList> FacilitieList { get; set; }
        public DbSet<Guest> Guest { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<RoomBand> RoomBand { get; set; }
        public DbSet<RoomFacilities> RoomFacilities { get; set; }
        public DbSet<RoomPrice> RoomPrice { get; set; }
        public DbSet<RoomType> RoomType { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>().ToTable("Booking");
            modelBuilder.Entity<BookingRoom>().ToTable("BookingRoom");
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<FacilitieList>().ToTable("FacilitieList");
            modelBuilder.Entity<Guest>().ToTable("Guest");
            modelBuilder.Entity<PaymentMethod>().ToTable("PaymentMethod");
            modelBuilder.Entity<Room>().ToTable("Room");
            modelBuilder.Entity<RoomBand>().ToTable("RoomBand");
            modelBuilder.Entity<RoomFacilities>().ToTable("RoomFacilities");
            modelBuilder.Entity<RoomPrice>().ToTable("RoomPrice");
            modelBuilder.Entity<RoomType>().ToTable("RoomType");

            modelBuilder.Entity<RoomFacilities>()
                .HasKey(c => new { c.RoomID, c.FacilityID });

            modelBuilder.Entity<BookingRoom>()
                .HasKey(c => new { c.BookingID, c.RoomID,c.GuestID });
        }
    }
}