using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AutoLogistic.Data.Migrations
{
    public partial class AddBussinesModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:uuid-ossp", "'uuid-ossp', '', ''");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AspNetUserClaims",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AspNetRoleClaims",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.CreateTable(
                name: "Carrier",
                columns: table => new
                {
                    CarrierId = table.Column<Guid>(nullable: false),
                    CarrierName = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    DeleteDate = table.Column<DateTime>(nullable: true),
                    Descriptions = table.Column<string>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    ModifyCount = table.Column<int>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrier", x => x.CarrierId);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityId = table.Column<Guid>(nullable: false),
                    CityName = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    DeleteDate = table.Column<DateTime>(nullable: true),
                    Descriptions = table.Column<string>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    ModifyCount = table.Column<int>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "CrType",
                columns: table => new
                {
                    CrTypeId = table.Column<Guid>(nullable: false),
                    CrName = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    DeleteDate = table.Column<DateTime>(nullable: true),
                    Descriptions = table.Column<string>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    ModifyCount = table.Column<int>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrType", x => x.CrTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    DeleteDate = table.Column<DateTime>(nullable: true),
                    Descriptions = table.Column<string>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    ModifyCount = table.Column<int>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Driver",
                columns: table => new
                {
                    DriverId = table.Column<Guid>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    DeleteDate = table.Column<DateTime>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    ModifyCount = table.Column<int>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.DriverId);
                });

            migrationBuilder.CreateTable(
                name: "ItemColor",
                columns: table => new
                {
                    ItemColorId = table.Column<Guid>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    DeleteDate = table.Column<DateTime>(nullable: true),
                    Descriptions = table.Column<string>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    ModifyCount = table.Column<int>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemColor", x => x.ItemColorId);
                });

            migrationBuilder.CreateTable(
                name: "ItemModel",
                columns: table => new
                {
                    ItemModelId = table.Column<Guid>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    DeleteDate = table.Column<DateTime>(nullable: true),
                    Descriptions = table.Column<string>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    ModifyBy = table.Column<string>(nullable: true),
                    ModifyCount = table.Column<int>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemModel", x => x.ItemModelId);
                });

            migrationBuilder.CreateTable(
                name: "ItemType",
                columns: table => new
                {
                    ItemTypeId = table.Column<Guid>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    DeleteDate = table.Column<DateTime>(nullable: true),
                    Descriptions = table.Column<string>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    ModifyCount = table.Column<int>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemType", x => x.ItemTypeId);
                });

            migrationBuilder.CreateTable(
                name: "PickupArea",
                columns: table => new
                {
                    PickupAreaId = table.Column<Guid>(nullable: false),
                    AreaName = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    DeleteDate = table.Column<DateTime>(nullable: true),
                    Descriptions = table.Column<string>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    ModifyCount = table.Column<int>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PickupArea", x => x.PickupAreaId);
                });

            migrationBuilder.CreateTable(
                name: "RackPole",
                columns: table => new
                {
                    RackId = table.Column<Guid>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    DeleteDate = table.Column<DateTime>(nullable: true),
                    Descriptions = table.Column<string>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    ModifyCount = table.Column<int>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    RackNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RackPole", x => x.RackId);
                });

            migrationBuilder.CreateTable(
                name: "Trucker",
                columns: table => new
                {
                    TruckerId = table.Column<Guid>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    DeleteDate = table.Column<DateTime>(nullable: true),
                    Descriptions = table.Column<string>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    ModifyCount = table.Column<int>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    TruckerName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trucker", x => x.TruckerId);
                });

            migrationBuilder.CreateTable(
                name: "Wellbase",
                columns: table => new
                {
                    WellbaseId = table.Column<Guid>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    DeleteDate = table.Column<DateTime>(nullable: true),
                    Descriptions = table.Column<string>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    ModifyCount = table.Column<int>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    WellbaseNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wellbase", x => x.WellbaseId);
                });

            migrationBuilder.CreateTable(
                name: "Truck",
                columns: table => new
                {
                    TruckId = table.Column<Guid>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    DeleteDate = table.Column<DateTime>(nullable: true),
                    Descriptions = table.Column<string>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    ModifyCount = table.Column<int>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    PoliceRegNumber = table.Column<string>(nullable: true),
                    TruckerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Truck", x => x.TruckId);
                    table.ForeignKey(
                        name: "FK_Truck_Trucker_TruckerId",
                        column: x => x.TruckerId,
                        principalTable: "Trucker",
                        principalColumn: "TruckerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Receiving",
                columns: table => new
                {
                    ReceivingId = table.Column<Guid>(nullable: false),
                    CarrierDispatchNote = table.Column<string>(nullable: true),
                    CarrierId = table.Column<Guid>(nullable: false),
                    CrTypeId = table.Column<Guid>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CustomerDispatchNoteDate = table.Column<string>(nullable: true),
                    CustomerDispatchNoteNumber = table.Column<string>(nullable: true),
                    CustomerId = table.Column<Guid>(nullable: false),
                    DaysDoorToDoor = table.Column<int>(nullable: true),
                    DaysInStorage = table.Column<int>(nullable: false),
                    DaysInTheShip = table.Column<int>(nullable: true),
                    DeleteDate = table.Column<DateTime>(nullable: true),
                    DestinationId = table.Column<Guid>(nullable: false),
                    DispatchNoteNumber = table.Column<string>(nullable: true),
                    DriverId = table.Column<Guid>(nullable: true),
                    EngineNumber = table.Column<string>(nullable: true),
                    FrameNumber = table.Column<string>(nullable: true),
                    IncidentRecord = table.Column<string>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    ItemColorId = table.Column<Guid>(nullable: false),
                    ItemModelId = table.Column<Guid>(nullable: false),
                    ItemReceiveDate = table.Column<DateTime>(nullable: true),
                    ItemTypeId = table.Column<Guid>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    ModifyCount = table.Column<int>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    MonthOfLoading = table.Column<int>(nullable: false),
                    MonthOfReceiving = table.Column<int>(nullable: false),
                    OriginId = table.Column<Guid>(nullable: false),
                    PickupAreaId = table.Column<Guid>(nullable: false),
                    ReceiveNumber = table.Column<int>(nullable: false),
                    ReceivedDate = table.Column<DateTime>(nullable: false),
                    ShipDepartureDate = table.Column<DateTime>(nullable: true),
                    ShipDockingDestinationDate = table.Column<DateTime>(nullable: true),
                    StuffingDate = table.Column<DateTime>(nullable: true),
                    TruckId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receiving", x => x.ReceivingId);
                    table.ForeignKey(
                        name: "FK_Receiving_Carrier_CarrierId",
                        column: x => x.CarrierId,
                        principalTable: "Carrier",
                        principalColumn: "CarrierId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receiving_CrType_CrTypeId",
                        column: x => x.CrTypeId,
                        principalTable: "CrType",
                        principalColumn: "CrTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receiving_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receiving_City_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receiving_Driver_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Driver",
                        principalColumn: "DriverId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Receiving_ItemColor_ItemColorId",
                        column: x => x.ItemColorId,
                        principalTable: "ItemColor",
                        principalColumn: "ItemColorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receiving_ItemModel_ItemModelId",
                        column: x => x.ItemModelId,
                        principalTable: "ItemModel",
                        principalColumn: "ItemModelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receiving_ItemType_ItemTypeId",
                        column: x => x.ItemTypeId,
                        principalTable: "ItemType",
                        principalColumn: "ItemTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receiving_City_OriginId",
                        column: x => x.OriginId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receiving_PickupArea_PickupAreaId",
                        column: x => x.PickupAreaId,
                        principalTable: "PickupArea",
                        principalColumn: "PickupAreaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receiving_Truck_TruckId",
                        column: x => x.TruckId,
                        principalTable: "Truck",
                        principalColumn: "TruckId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shipping",
                columns: table => new
                {
                    ShippingId = table.Column<Guid>(nullable: false),
                    ActualDispatchDate = table.Column<DateTime>(nullable: false),
                    ActualTimeArrival = table.Column<DateTime>(nullable: false),
                    CarrierId = table.Column<Guid>(nullable: false),
                    ContainerBookedTime = table.Column<DateTime>(nullable: false),
                    ContainerClosingTime = table.Column<DateTime>(nullable: false),
                    ContainerCode = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    DeleteDate = table.Column<DateTime>(nullable: true),
                    EstimateTimeArrival = table.Column<DateTime>(nullable: false),
                    EstimateTimeDeparture = table.Column<DateTime>(nullable: false),
                    InvoiceNumber = table.Column<string>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    ModifyCount = table.Column<int>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    RackPoleId = table.Column<Guid>(nullable: false),
                    ReceiverId = table.Column<Guid>(nullable: false),
                    ReceivingId = table.Column<Guid>(nullable: false),
                    SI = table.Column<string>(nullable: true),
                    SealCode = table.Column<string>(nullable: true),
                    ShipmentNumber = table.Column<string>(nullable: true),
                    ShippingBookingNumber = table.Column<string>(nullable: true),
                    StuffingDate = table.Column<DateTime>(nullable: false),
                    StuffingDateEnd = table.Column<DateTime>(nullable: false),
                    StuffingDateStart = table.Column<DateTime>(nullable: false),
                    TruckId = table.Column<Guid>(nullable: false),
                    VesselName = table.Column<string>(nullable: true),
                    WellbaseId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipping", x => x.ShippingId);
                    table.ForeignKey(
                        name: "FK_Shipping_Carrier_CarrierId",
                        column: x => x.CarrierId,
                        principalTable: "Carrier",
                        principalColumn: "CarrierId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shipping_RackPole_RackPoleId",
                        column: x => x.RackPoleId,
                        principalTable: "RackPole",
                        principalColumn: "RackId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shipping_Customer_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shipping_Receiving_ReceivingId",
                        column: x => x.ReceivingId,
                        principalTable: "Receiving",
                        principalColumn: "ReceivingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shipping_Truck_TruckId",
                        column: x => x.TruckId,
                        principalTable: "Truck",
                        principalColumn: "TruckId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shipping_Wellbase_WellbaseId",
                        column: x => x.WellbaseId,
                        principalTable: "Wellbase",
                        principalColumn: "WellbaseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Delivering",
                columns: table => new
                {
                    DeliveringId = table.Column<Guid>(nullable: false),
                    ContainerUnloadDate = table.Column<DateTime>(nullable: false),
                    ContainerUnloadTimeEnd = table.Column<DateTime>(nullable: false),
                    ContainerUnloadTimeStart = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CustomerReceivedTime = table.Column<DateTime>(nullable: false),
                    CustomerReceiverName = table.Column<string>(nullable: true),
                    CustomerSentDate = table.Column<DateTime>(nullable: false),
                    CustomerSentTime = table.Column<DateTime>(nullable: false),
                    DeleteDate = table.Column<DateTime>(nullable: true),
                    DriverId = table.Column<Guid>(nullable: false),
                    Incident = table.Column<bool>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    KmArrival = table.Column<int>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    ModifyCount = table.Column<int>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    ShipDockingDate = table.Column<DateTime>(nullable: false),
                    ShippingId = table.Column<Guid>(nullable: false),
                    TruckId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivering", x => x.DeliveringId);
                    table.ForeignKey(
                        name: "FK_Delivering_Driver_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Driver",
                        principalColumn: "DriverId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Delivering_Shipping_ShippingId",
                        column: x => x.ShippingId,
                        principalTable: "Shipping",
                        principalColumn: "ShippingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Delivering_Truck_TruckId",
                        column: x => x.TruckId,
                        principalTable: "Truck",
                        principalColumn: "TruckId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Truck_TruckerId",
                table: "Truck",
                column: "TruckerId");

            migrationBuilder.CreateIndex(
                name: "IX_Delivering_DriverId",
                table: "Delivering",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Delivering_ShippingId",
                table: "Delivering",
                column: "ShippingId");

            migrationBuilder.CreateIndex(
                name: "IX_Delivering_TruckId",
                table: "Delivering",
                column: "TruckId");

            migrationBuilder.CreateIndex(
                name: "IX_Receiving_CarrierId",
                table: "Receiving",
                column: "CarrierId");

            migrationBuilder.CreateIndex(
                name: "IX_Receiving_CrTypeId",
                table: "Receiving",
                column: "CrTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Receiving_CustomerId",
                table: "Receiving",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Receiving_DestinationId",
                table: "Receiving",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Receiving_DriverId",
                table: "Receiving",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Receiving_ItemColorId",
                table: "Receiving",
                column: "ItemColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Receiving_ItemModelId",
                table: "Receiving",
                column: "ItemModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Receiving_ItemTypeId",
                table: "Receiving",
                column: "ItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Receiving_OriginId",
                table: "Receiving",
                column: "OriginId");

            migrationBuilder.CreateIndex(
                name: "IX_Receiving_PickupAreaId",
                table: "Receiving",
                column: "PickupAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Receiving_TruckId",
                table: "Receiving",
                column: "TruckId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipping_CarrierId",
                table: "Shipping",
                column: "CarrierId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipping_RackPoleId",
                table: "Shipping",
                column: "RackPoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipping_ReceiverId",
                table: "Shipping",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipping_ReceivingId",
                table: "Shipping",
                column: "ReceivingId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipping_TruckId",
                table: "Shipping",
                column: "TruckId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipping_WellbaseId",
                table: "Shipping",
                column: "WellbaseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Delivering");

            migrationBuilder.DropTable(
                name: "Shipping");

            migrationBuilder.DropTable(
                name: "RackPole");

            migrationBuilder.DropTable(
                name: "Receiving");

            migrationBuilder.DropTable(
                name: "Wellbase");

            migrationBuilder.DropTable(
                name: "Carrier");

            migrationBuilder.DropTable(
                name: "CrType");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Driver");

            migrationBuilder.DropTable(
                name: "ItemColor");

            migrationBuilder.DropTable(
                name: "ItemModel");

            migrationBuilder.DropTable(
                name: "ItemType");

            migrationBuilder.DropTable(
                name: "PickupArea");

            migrationBuilder.DropTable(
                name: "Truck");

            migrationBuilder.DropTable(
                name: "Trucker");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.AlterDatabase()
                .OldAnnotation("Npgsql:PostgresExtension:uuid-ossp", "'uuid-ossp', '', ''");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AspNetUserClaims",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AspNetRoleClaims",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");
        }
    }
}
