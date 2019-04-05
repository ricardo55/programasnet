using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReservacionHotelExamen2.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerTitle = table.Column<string>(maxLength: 20, nullable: false),
                    CustomerForenames = table.Column<string>(maxLength: 20, nullable: false),
                    CustomerSurnames = table.Column<string>(maxLength: 20, nullable: false),
                    CustomerDOB = table.Column<DateTime>(nullable: false),
                    CustomerAdressStreet = table.Column<string>(maxLength: 20, nullable: false),
                    CustomerAdressTown = table.Column<string>(maxLength: 20, nullable: false),
                    CustomerAdressCountry = table.Column<string>(maxLength: 20, nullable: false),
                    CustomerAdressPostalCode = table.Column<string>(nullable: false),
                    CustomerHomePhone = table.Column<string>(nullable: false),
                    CustomerWorkPhone = table.Column<string>(nullable: false),
                    CustomerMobilePhone = table.Column<string>(nullable: false),
                    CustomerEmail = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "FacilitieList",
                columns: table => new
                {
                    FacilitieListID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FacilityDesc = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilitieList", x => x.FacilitieListID);
                });

            migrationBuilder.CreateTable(
                name: "Guest",
                columns: table => new
                {
                    GuestID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GuestTitle = table.Column<string>(maxLength: 100, nullable: false),
                    GuestForenames = table.Column<string>(maxLength: 100, nullable: false),
                    GuestSurnames = table.Column<string>(maxLength: 100, nullable: false),
                    GuestDOB = table.Column<DateTime>(nullable: false),
                    GuestAdressStreet = table.Column<string>(maxLength: 20, nullable: false),
                    GuestAdressTown = table.Column<string>(maxLength: 20, nullable: false),
                    GuestAdressCounty = table.Column<string>(maxLength: 20, nullable: false),
                    GuestAdressPostalCode = table.Column<string>(nullable: false),
                    GuestContactPhone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guest", x => x.GuestID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethod",
                columns: table => new
                {
                    PaymentMethodID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PaymentMethodDesc = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethod", x => x.PaymentMethodID);
                });

            migrationBuilder.CreateTable(
                name: "RoomBand",
                columns: table => new
                {
                    RoomBandID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BandDesc = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomBand", x => x.RoomBandID);
                });

            migrationBuilder.CreateTable(
                name: "RoomPrice",
                columns: table => new
                {
                    RoomPriceID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoomPriceAmount = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomPrice", x => x.RoomPriceID);
                });

            migrationBuilder.CreateTable(
                name: "RoomType",
                columns: table => new
                {
                    RoomTypeID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoomTypeDesc = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomType", x => x.RoomTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    RoomID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoomTypeID = table.Column<int>(nullable: false),
                    RoomBandID = table.Column<int>(nullable: false),
                    RoomPriceID = table.Column<int>(nullable: false),
                    Floor = table.Column<string>(maxLength: 10, nullable: false),
                    AdditionalNotes = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.RoomID);
                    table.ForeignKey(
                        name: "FK_Room_RoomBand_RoomBandID",
                        column: x => x.RoomBandID,
                        principalTable: "RoomBand",
                        principalColumn: "RoomBandID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Room_RoomPrice_RoomPriceID",
                        column: x => x.RoomPriceID,
                        principalTable: "RoomPrice",
                        principalColumn: "RoomPriceID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Room_RoomType_RoomTypeID",
                        column: x => x.RoomTypeID,
                        principalTable: "RoomType",
                        principalColumn: "RoomTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    BookingID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerID = table.Column<int>(nullable: false),
                    DateBookingMade = table.Column<DateTime>(nullable: false),
                    TimeBookingMade = table.Column<DateTime>(nullable: false),
                    BookedStartDate = table.Column<DateTime>(nullable: false),
                    BookedEndDate = table.Column<DateTime>(nullable: false),
                    TotalPaymentDueDate = table.Column<DateTime>(nullable: false),
                    TotalPaymentDueAmount = table.Column<int>(nullable: false),
                    TotalPaymentMadeOn = table.Column<DateTime>(nullable: false),
                    BookingComments = table.Column<string>(maxLength: 300, nullable: true),
                    RoomID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.BookingID);
                    table.ForeignKey(
                        name: "FK_Booking_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Booking_Room_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Room",
                        principalColumn: "RoomID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoomFacilities",
                columns: table => new
                {
                    RoomID = table.Column<int>(nullable: false),
                    FacilitieListID = table.Column<int>(nullable: false),
                    FacilityDetails = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomFacilities", x => new { x.RoomID, x.FacilitieListID });
                    table.ForeignKey(
                        name: "FK_RoomFacilities_FacilitieList_FacilitieListID",
                        column: x => x.FacilitieListID,
                        principalTable: "FacilitieList",
                        principalColumn: "FacilitieListID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomFacilities_Room_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Room",
                        principalColumn: "RoomID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookingRoom",
                columns: table => new
                {
                    BookingID = table.Column<int>(nullable: false),
                    RoomID = table.Column<int>(nullable: false),
                    GuestID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingRoom", x => new { x.BookingID, x.RoomID, x.GuestID });
                    table.ForeignKey(
                        name: "FK_BookingRoom_Booking_BookingID",
                        column: x => x.BookingID,
                        principalTable: "Booking",
                        principalColumn: "BookingID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingRoom_Guest_GuestID",
                        column: x => x.GuestID,
                        principalTable: "Guest",
                        principalColumn: "GuestID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingRoom_Room_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Room",
                        principalColumn: "RoomID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookingID = table.Column<int>(nullable: false),
                    CustomerID = table.Column<int>(nullable: false),
                    PaymentMethodID = table.Column<int>(nullable: false),
                    PaymentAmount = table.Column<long>(nullable: false),
                    PaymentComments = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentID);
                    table.ForeignKey(
                        name: "FK_Payment_Booking_BookingID",
                        column: x => x.BookingID,
                        principalTable: "Booking",
                        principalColumn: "BookingID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_PaymentMethod_PaymentMethodID",
                        column: x => x.PaymentMethodID,
                        principalTable: "PaymentMethod",
                        principalColumn: "PaymentMethodID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_CustomerID",
                table: "Booking",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_RoomID",
                table: "Booking",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_BookingRoom_GuestID",
                table: "BookingRoom",
                column: "GuestID");

            migrationBuilder.CreateIndex(
                name: "IX_BookingRoom_RoomID",
                table: "BookingRoom",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_BookingID",
                table: "Payment",
                column: "BookingID");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_CustomerID",
                table: "Payment",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_PaymentMethodID",
                table: "Payment",
                column: "PaymentMethodID");

            migrationBuilder.CreateIndex(
                name: "IX_Room_RoomBandID",
                table: "Room",
                column: "RoomBandID");

            migrationBuilder.CreateIndex(
                name: "IX_Room_RoomPriceID",
                table: "Room",
                column: "RoomPriceID");

            migrationBuilder.CreateIndex(
                name: "IX_Room_RoomTypeID",
                table: "Room",
                column: "RoomTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_RoomFacilities_FacilitieListID",
                table: "RoomFacilities",
                column: "FacilitieListID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingRoom");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "RoomFacilities");

            migrationBuilder.DropTable(
                name: "Guest");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "PaymentMethod");

            migrationBuilder.DropTable(
                name: "FacilitieList");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "RoomBand");

            migrationBuilder.DropTable(
                name: "RoomPrice");

            migrationBuilder.DropTable(
                name: "RoomType");
        }
    }
}
