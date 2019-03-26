CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY,
    "ProductVersion" TEXT NOT NULL
);

CREATE TABLE "Customer" (
    "CustomerID" INTEGER NOT NULL CONSTRAINT "PK_Customer" PRIMARY KEY AUTOINCREMENT,
    "CustomerTitle" TEXT NULL,
    "CustomerForenames" TEXT NULL,
    "CustomerSurnames" TEXT NULL,
    "CustomerDOB" TEXT NOT NULL,
    "CustomerAdressStreet" TEXT NULL,
    "CustomerAdressTown" TEXT NULL,
    "CustomerAdressCountry" TEXT NULL,
    "CustomerAdressPostalCode" TEXT NULL,
    "CustomerHomePhone" TEXT NULL,
    "CustomerWorkPhone" TEXT NULL,
    "CustomerMobilePhone" TEXT NULL,
    "CustomerEmail" TEXT NULL
);

CREATE TABLE "FacilitieList" (
    "FacilitieListID" INTEGER NOT NULL CONSTRAINT "PK_FacilitieList" PRIMARY KEY AUTOINCREMENT,
    "FacilityDesc" TEXT NULL
);

CREATE TABLE "Guest" (
    "GuestID" INTEGER NOT NULL CONSTRAINT "PK_Guest" PRIMARY KEY AUTOINCREMENT,
    "GuestTitle" TEXT NULL,
    "GuestForenames" TEXT NULL,
    "GuestSurnames" TEXT NULL,
    "GuestDOB" TEXT NOT NULL,
    "GuestAdressStreet" TEXT NULL,
    "GuestAdressTown" TEXT NULL,
    "GuestAdressCounty" TEXT NULL,
    "GuestAdressPostalCode" TEXT NULL,
    "GuestContactPhone" TEXT NULL
);

CREATE TABLE "PaymentMethod" (
    "PaymentMethodID" INTEGER NOT NULL CONSTRAINT "PK_PaymentMethod" PRIMARY KEY AUTOINCREMENT,
    "PaymentMethodDesc" TEXT NULL
);

CREATE TABLE "RoomBand" (
    "RoomBandID" INTEGER NOT NULL CONSTRAINT "PK_RoomBand" PRIMARY KEY AUTOINCREMENT,
    "BandDesc" TEXT NULL
);

CREATE TABLE "RoomPrice" (
    "RoomPriceID" INTEGER NOT NULL CONSTRAINT "PK_RoomPrice" PRIMARY KEY AUTOINCREMENT,
    "RoomPriceAmount" INTEGER NOT NULL
);

CREATE TABLE "RoomType" (
    "RoomTypeID" INTEGER NOT NULL CONSTRAINT "PK_RoomType" PRIMARY KEY AUTOINCREMENT,
    "RoomTypeDesc" TEXT NULL
);

CREATE TABLE "Room" (
    "RoomID" INTEGER NOT NULL CONSTRAINT "PK_Room" PRIMARY KEY AUTOINCREMENT,
    "RoomTypeID" INTEGER NOT NULL,
    "RoomBandID" INTEGER NOT NULL,
    "RoomPriceID" INTEGER NOT NULL,
    "Floor" TEXT NULL,
    "AdditionalNotes" TEXT NULL,
    CONSTRAINT "FK_Room_RoomBand_RoomBandID" FOREIGN KEY ("RoomBandID") REFERENCES "RoomBand" ("RoomBandID") ON DELETE CASCADE,
    CONSTRAINT "FK_Room_RoomPrice_RoomPriceID" FOREIGN KEY ("RoomPriceID") REFERENCES "RoomPrice" ("RoomPriceID") ON DELETE CASCADE,
    CONSTRAINT "FK_Room_RoomType_RoomTypeID" FOREIGN KEY ("RoomTypeID") REFERENCES "RoomType" ("RoomTypeID") ON DELETE CASCADE
);

CREATE TABLE "Booking" (
    "BookingID" INTEGER NOT NULL CONSTRAINT "PK_Booking" PRIMARY KEY AUTOINCREMENT,
    "CustomerID" INTEGER NOT NULL,
    "DateBookingMade" TEXT NOT NULL,
    "TimeBookingMade" TEXT NOT NULL,
    "BookedStartDate" TEXT NOT NULL,
    "BookedEndDate" TEXT NOT NULL,
    "TotalPaymentDueDate" TEXT NOT NULL,
    "TotalPaymentDueAmount" INTEGER NOT NULL,
    "TotalPaymentMadeOn" TEXT NOT NULL,
    "BookingComments" TEXT NULL,
    "RoomID" INTEGER NULL,
    CONSTRAINT "FK_Booking_Customer_CustomerID" FOREIGN KEY ("CustomerID") REFERENCES "Customer" ("CustomerID") ON DELETE CASCADE,
    CONSTRAINT "FK_Booking_Room_RoomID" FOREIGN KEY ("RoomID") REFERENCES "Room" ("RoomID") ON DELETE RESTRICT
);

CREATE TABLE "RoomFacilities" (
    "RoomID" INTEGER NOT NULL,
    "FacilityID" INTEGER NOT NULL,
    "FacilityDetails" TEXT NULL,
    "FacilitieListID" INTEGER NULL,
    CONSTRAINT "PK_RoomFacilities" PRIMARY KEY ("RoomID", "FacilityID"),
    CONSTRAINT "FK_RoomFacilities_FacilitieList_FacilitieListID" FOREIGN KEY ("FacilitieListID") REFERENCES "FacilitieList" ("FacilitieListID") ON DELETE RESTRICT,
    CONSTRAINT "FK_RoomFacilities_Room_RoomID" FOREIGN KEY ("RoomID") REFERENCES "Room" ("RoomID") ON DELETE CASCADE
);

CREATE TABLE "BookingRoom" (
    "BookingID" INTEGER NOT NULL,
    "RoomID" INTEGER NOT NULL,
    "GuestID" INTEGER NOT NULL,
    CONSTRAINT "PK_BookingRoom" PRIMARY KEY ("BookingID", "RoomID", "GuestID"),
    CONSTRAINT "FK_BookingRoom_Booking_BookingID" FOREIGN KEY ("BookingID") REFERENCES "Booking" ("BookingID") ON DELETE CASCADE,
    CONSTRAINT "FK_BookingRoom_Guest_GuestID" FOREIGN KEY ("GuestID") REFERENCES "Guest" ("GuestID") ON DELETE CASCADE,
    CONSTRAINT "FK_BookingRoom_Room_RoomID" FOREIGN KEY ("RoomID") REFERENCES "Room" ("RoomID") ON DELETE CASCADE
);

CREATE TABLE "Payment" (
    "PaymentID" INTEGER NOT NULL CONSTRAINT "PK_Payment" PRIMARY KEY AUTOINCREMENT,
    "BookingID" INTEGER NOT NULL,
    "CustomerID" INTEGER NOT NULL,
    "PaymentMethodID" INTEGER NOT NULL,
    "PaymentAmount" INTEGER NOT NULL,
    "PaymentComments" TEXT NULL,
    CONSTRAINT "FK_Payment_Booking_BookingID" FOREIGN KEY ("BookingID") REFERENCES "Booking" ("BookingID") ON DELETE CASCADE,
    CONSTRAINT "FK_Payment_Customer_CustomerID" FOREIGN KEY ("CustomerID") REFERENCES "Customer" ("CustomerID") ON DELETE CASCADE,
    CONSTRAINT "FK_Payment_PaymentMethod_PaymentMethodID" FOREIGN KEY ("PaymentMethodID") REFERENCES "PaymentMethod" ("PaymentMethodID") ON DELETE CASCADE
);

CREATE INDEX "IX_Booking_CustomerID" ON "Booking" ("CustomerID");

CREATE INDEX "IX_Booking_RoomID" ON "Booking" ("RoomID");

CREATE INDEX "IX_BookingRoom_GuestID" ON "BookingRoom" ("GuestID");

CREATE INDEX "IX_BookingRoom_RoomID" ON "BookingRoom" ("RoomID");

CREATE INDEX "IX_Payment_BookingID" ON "Payment" ("BookingID");

CREATE INDEX "IX_Payment_CustomerID" ON "Payment" ("CustomerID");

CREATE INDEX "IX_Payment_PaymentMethodID" ON "Payment" ("PaymentMethodID");

CREATE INDEX "IX_Room_RoomBandID" ON "Room" ("RoomBandID");

CREATE INDEX "IX_Room_RoomPriceID" ON "Room" ("RoomPriceID");

CREATE INDEX "IX_Room_RoomTypeID" ON "Room" ("RoomTypeID");

CREATE INDEX "IX_RoomFacilities_FacilitieListID" ON "RoomFacilities" ("FacilitieListID");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20190326173712_ComplexDataModel', '2.2.3-servicing-35854');

