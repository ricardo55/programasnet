﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReservacionHotelExamen2.Models;

namespace ReservacionHotelExamen2.Migrations
{
    [DbContext(typeof(ReservacionHotelContext))]
    [Migration("20190326173712_ComplexDataModel")]
    partial class ComplexDataModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity("ReservacionHotelExamen2.Models.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BookedEndDate");

                    b.Property<DateTime>("BookedStartDate");

                    b.Property<string>("BookingComments");

                    b.Property<int>("CustomerID");

                    b.Property<DateTime>("DateBookingMade");

                    b.Property<int?>("RoomID");

                    b.Property<DateTime>("TimeBookingMade");

                    b.Property<int>("TotalPaymentDueAmount");

                    b.Property<DateTime>("TotalPaymentDueDate");

                    b.Property<DateTime>("TotalPaymentMadeOn");

                    b.HasKey("BookingID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("RoomID");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("ReservacionHotelExamen2.Models.BookingRoom", b =>
                {
                    b.Property<int>("BookingID");

                    b.Property<int>("RoomID");

                    b.Property<int>("GuestID");

                    b.HasKey("BookingID", "RoomID", "GuestID");

                    b.HasIndex("GuestID");

                    b.HasIndex("RoomID");

                    b.ToTable("BookingRoom");
                });

            modelBuilder.Entity("ReservacionHotelExamen2.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerAdressCountry");

                    b.Property<string>("CustomerAdressPostalCode");

                    b.Property<string>("CustomerAdressStreet");

                    b.Property<string>("CustomerAdressTown");

                    b.Property<DateTime>("CustomerDOB");

                    b.Property<string>("CustomerEmail");

                    b.Property<string>("CustomerForenames");

                    b.Property<string>("CustomerHomePhone");

                    b.Property<string>("CustomerMobilePhone");

                    b.Property<string>("CustomerSurnames");

                    b.Property<string>("CustomerTitle");

                    b.Property<string>("CustomerWorkPhone");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("ReservacionHotelExamen2.Models.FacilitieList", b =>
                {
                    b.Property<int>("FacilitieListID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FacilityDesc");

                    b.HasKey("FacilitieListID");

                    b.ToTable("FacilitieList");
                });

            modelBuilder.Entity("ReservacionHotelExamen2.Models.Guest", b =>
                {
                    b.Property<int>("GuestID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GuestAdressCounty");

                    b.Property<string>("GuestAdressPostalCode");

                    b.Property<string>("GuestAdressStreet");

                    b.Property<string>("GuestAdressTown");

                    b.Property<string>("GuestContactPhone");

                    b.Property<DateTime>("GuestDOB");

                    b.Property<string>("GuestForenames");

                    b.Property<string>("GuestSurnames");

                    b.Property<string>("GuestTitle");

                    b.HasKey("GuestID");

                    b.ToTable("Guest");
                });

            modelBuilder.Entity("ReservacionHotelExamen2.Models.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BookingID");

                    b.Property<int>("CustomerID");

                    b.Property<long>("PaymentAmount");

                    b.Property<string>("PaymentComments");

                    b.Property<int>("PaymentMethodID");

                    b.HasKey("PaymentID");

                    b.HasIndex("BookingID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("PaymentMethodID");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("ReservacionHotelExamen2.Models.PaymentMethod", b =>
                {
                    b.Property<int>("PaymentMethodID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PaymentMethodDesc");

                    b.HasKey("PaymentMethodID");

                    b.ToTable("PaymentMethod");
                });

            modelBuilder.Entity("ReservacionHotelExamen2.Models.Room", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdditionalNotes");

                    b.Property<string>("Floor");

                    b.Property<int>("RoomBandID");

                    b.Property<int>("RoomPriceID");

                    b.Property<int>("RoomTypeID");

                    b.HasKey("RoomID");

                    b.HasIndex("RoomBandID");

                    b.HasIndex("RoomPriceID");

                    b.HasIndex("RoomTypeID");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("ReservacionHotelExamen2.Models.RoomBand", b =>
                {
                    b.Property<int>("RoomBandID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BandDesc");

                    b.HasKey("RoomBandID");

                    b.ToTable("RoomBand");
                });

            modelBuilder.Entity("ReservacionHotelExamen2.Models.RoomFacilities", b =>
                {
                    b.Property<int>("RoomID");

                    b.Property<int>("FacilityID");

                    b.Property<int?>("FacilitieListID");

                    b.Property<string>("FacilityDetails");

                    b.HasKey("RoomID", "FacilityID");

                    b.HasIndex("FacilitieListID");

                    b.ToTable("RoomFacilities");
                });

            modelBuilder.Entity("ReservacionHotelExamen2.Models.RoomPrice", b =>
                {
                    b.Property<int>("RoomPriceID")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("RoomPriceAmount");

                    b.HasKey("RoomPriceID");

                    b.ToTable("RoomPrice");
                });

            modelBuilder.Entity("ReservacionHotelExamen2.Models.RoomType", b =>
                {
                    b.Property<int>("RoomTypeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RoomTypeDesc");

                    b.HasKey("RoomTypeID");

                    b.ToTable("RoomType");
                });

            modelBuilder.Entity("ReservacionHotelExamen2.Models.Booking", b =>
                {
                    b.HasOne("ReservacionHotelExamen2.Models.Customer", "Customer")
                        .WithMany("Bookings")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ReservacionHotelExamen2.Models.Room")
                        .WithMany("Bookings")
                        .HasForeignKey("RoomID");
                });

            modelBuilder.Entity("ReservacionHotelExamen2.Models.BookingRoom", b =>
                {
                    b.HasOne("ReservacionHotelExamen2.Models.Booking", "Booking")
                        .WithMany("BookingRooms")
                        .HasForeignKey("BookingID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ReservacionHotelExamen2.Models.Guest", "Guest")
                        .WithMany("BookingRooms")
                        .HasForeignKey("GuestID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ReservacionHotelExamen2.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ReservacionHotelExamen2.Models.Payment", b =>
                {
                    b.HasOne("ReservacionHotelExamen2.Models.Booking", "Booking")
                        .WithMany("Payments")
                        .HasForeignKey("BookingID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ReservacionHotelExamen2.Models.Customer", "Customer")
                        .WithMany("Payments")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ReservacionHotelExamen2.Models.PaymentMethod", "PaymentMethod")
                        .WithMany("Payments")
                        .HasForeignKey("PaymentMethodID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ReservacionHotelExamen2.Models.Room", b =>
                {
                    b.HasOne("ReservacionHotelExamen2.Models.RoomBand", "RoomBand")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomBandID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ReservacionHotelExamen2.Models.RoomPrice", "RoomPrice")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomPriceID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ReservacionHotelExamen2.Models.RoomType", "RoomType")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomTypeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ReservacionHotelExamen2.Models.RoomFacilities", b =>
                {
                    b.HasOne("ReservacionHotelExamen2.Models.FacilitieList", "FacilitieList")
                        .WithMany("RoomFacilities")
                        .HasForeignKey("FacilitieListID");

                    b.HasOne("ReservacionHotelExamen2.Models.Room", "Room")
                        .WithMany("RoomFacilities")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}