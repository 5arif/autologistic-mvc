using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AutoLogistic.Data;

namespace AutoLogistic.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170513084611_AddBussinesModel")]
    partial class AddBussinesModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("Npgsql:PostgresExtension:uuid-ossp", "'uuid-ossp', '', ''")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("AutoLogistic.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("AutoLogistic.Models.Master.Carrier", b =>
                {
                    b.Property<Guid>("CarrierId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CarrierName");

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime>("DeleteDate");

                    b.Property<string>("Descriptions");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("ModifyBy");

                    b.Property<int>("ModifyCount");

                    b.Property<DateTime>("ModifyDate");

                    b.HasKey("CarrierId");

                    b.ToTable("Carrier");
                });

            modelBuilder.Entity("AutoLogistic.Models.Master.City", b =>
                {
                    b.Property<Guid>("CityId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CityName");

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime>("DeleteDate");

                    b.Property<string>("Descriptions");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("ModifyBy");

                    b.Property<int>("ModifyCount");

                    b.Property<DateTime>("ModifyDate");

                    b.HasKey("CityId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("AutoLogistic.Models.Master.CrType", b =>
                {
                    b.Property<Guid>("CrTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CrName");

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime>("DeleteDate");

                    b.Property<string>("Descriptions");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("ModifyBy");

                    b.Property<int>("ModifyCount");

                    b.Property<DateTime>("ModifyDate");

                    b.HasKey("CrTypeId");

                    b.ToTable("CrType");
                });

            modelBuilder.Entity("AutoLogistic.Models.Master.Customer", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime>("DeleteDate");

                    b.Property<string>("Descriptions");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("ModifyBy");

                    b.Property<int>("ModifyCount");

                    b.Property<DateTime>("ModifyDate");

                    b.Property<string>("Name");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("AutoLogistic.Models.Master.Driver", b =>
                {
                    b.Property<Guid>("DriverId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime>("DeleteDate");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("ModifyBy");

                    b.Property<int>("ModifyCount");

                    b.Property<DateTime>("ModifyDate");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("DriverId");

                    b.ToTable("Driver");
                });

            modelBuilder.Entity("AutoLogistic.Models.Master.ItemColor", b =>
                {
                    b.Property<Guid>("ItemColorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Color");

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime>("DeleteDate");

                    b.Property<string>("Descriptions");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("ModifyBy");

                    b.Property<int>("ModifyCount");

                    b.Property<DateTime>("ModifyDate");

                    b.HasKey("ItemColorId");

                    b.ToTable("ItemColor");
                });

            modelBuilder.Entity("AutoLogistic.Models.Master.ItemModel", b =>
                {
                    b.Property<Guid>("ItemModelId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime>("DeleteDate");

                    b.Property<string>("Descriptions");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Model");

                    b.Property<string>("ModifyBy");

                    b.Property<int>("ModifyCount");

                    b.Property<DateTime>("ModifyDate");

                    b.HasKey("ItemModelId");

                    b.ToTable("ItemModel");
                });

            modelBuilder.Entity("AutoLogistic.Models.Master.ItemType", b =>
                {
                    b.Property<Guid>("ItemTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime>("DeleteDate");

                    b.Property<string>("Descriptions");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("ModifyBy");

                    b.Property<int>("ModifyCount");

                    b.Property<DateTime>("ModifyDate");

                    b.Property<string>("Type");

                    b.HasKey("ItemTypeId");

                    b.ToTable("ItemType");
                });

            modelBuilder.Entity("AutoLogistic.Models.Master.PickupArea", b =>
                {
                    b.Property<Guid>("PickupAreaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AreaName");

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime>("DeleteDate");

                    b.Property<string>("Descriptions");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("ModifyBy");

                    b.Property<int>("ModifyCount");

                    b.Property<DateTime>("ModifyDate");

                    b.HasKey("PickupAreaId");

                    b.ToTable("PickupArea");
                });

            modelBuilder.Entity("AutoLogistic.Models.Master.RackPole", b =>
                {
                    b.Property<Guid>("RackId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime>("DeleteDate");

                    b.Property<string>("Descriptions");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("ModifyBy");

                    b.Property<int>("ModifyCount");

                    b.Property<DateTime>("ModifyDate");

                    b.Property<string>("RackNumber");

                    b.HasKey("RackId");

                    b.ToTable("RackPole");
                });

            modelBuilder.Entity("AutoLogistic.Models.Master.Truck", b =>
                {
                    b.Property<Guid>("TruckId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime>("DeleteDate");

                    b.Property<string>("Descriptions");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("ModifyBy");

                    b.Property<int>("ModifyCount");

                    b.Property<DateTime>("ModifyDate");

                    b.Property<string>("PoliceRegNumber");

                    b.Property<Guid>("TruckerId");

                    b.HasKey("TruckId");

                    b.HasIndex("TruckerId");

                    b.ToTable("Truck");
                });

            modelBuilder.Entity("AutoLogistic.Models.Master.Trucker", b =>
                {
                    b.Property<Guid>("TruckerId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime>("DeleteDate");

                    b.Property<string>("Descriptions");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("ModifyBy");

                    b.Property<int>("ModifyCount");

                    b.Property<DateTime>("ModifyDate");

                    b.Property<string>("TruckerName");

                    b.HasKey("TruckerId");

                    b.ToTable("Trucker");
                });

            modelBuilder.Entity("AutoLogistic.Models.Master.Wellbase", b =>
                {
                    b.Property<Guid>("WellbaseId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime>("DeleteDate");

                    b.Property<string>("Descriptions");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("ModifyBy");

                    b.Property<int>("ModifyCount");

                    b.Property<DateTime>("ModifyDate");

                    b.Property<string>("WellbaseNumber");

                    b.HasKey("WellbaseId");

                    b.ToTable("Wellbase");
                });

            modelBuilder.Entity("AutoLogistic.Models.Transactions.Delivering", b =>
                {
                    b.Property<Guid>("DeliveringId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ContainerUnloadDate");

                    b.Property<DateTime>("ContainerUnloadTimeEnd");

                    b.Property<DateTime>("ContainerUnloadTimeStart");

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime>("CustomerReceivedTime");

                    b.Property<string>("CustomerReceiverName");

                    b.Property<DateTime>("CustomerSentDate");

                    b.Property<DateTime>("CustomerSentTime");

                    b.Property<DateTime>("DeleteDate");

                    b.Property<Guid>("DriverId");

                    b.Property<bool>("Incident");

                    b.Property<bool>("IsDelete");

                    b.Property<int>("KmArrival");

                    b.Property<string>("ModifyBy");

                    b.Property<int>("ModifyCount");

                    b.Property<DateTime>("ModifyDate");

                    b.Property<string>("Note");

                    b.Property<DateTime>("ShipDockingDate");

                    b.Property<Guid>("ShippingId");

                    b.Property<Guid>("TruckId");

                    b.HasKey("DeliveringId");

                    b.HasIndex("DriverId");

                    b.HasIndex("ShippingId");

                    b.HasIndex("TruckId");

                    b.ToTable("Delivering");
                });

            modelBuilder.Entity("AutoLogistic.Models.Transactions.Receiving", b =>
                {
                    b.Property<Guid>("ReceivingId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CarrierDispatchNote");

                    b.Property<Guid>("CarrierId");

                    b.Property<Guid>("CrTypeId");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CustomerDispatchNoteDate");

                    b.Property<string>("CustomerDispatchNoteNumber");

                    b.Property<Guid>("CustomerId");

                    b.Property<int?>("DaysDoorToDoor");

                    b.Property<int>("DaysInStorage");

                    b.Property<int?>("DaysInTheShip");

                    b.Property<DateTime>("DeleteDate");

                    b.Property<Guid>("DestinationId");

                    b.Property<string>("DispatchNoteNumber");

                    b.Property<Guid?>("DriverId");

                    b.Property<string>("EngineNumber");

                    b.Property<string>("FrameNumber");

                    b.Property<string>("IncidentRecord");

                    b.Property<bool>("IsDelete");

                    b.Property<Guid>("ItemColorId");

                    b.Property<Guid>("ItemModelId");

                    b.Property<DateTime?>("ItemReceiveDate");

                    b.Property<Guid>("ItemTypeId");

                    b.Property<string>("ModifyBy");

                    b.Property<int>("ModifyCount");

                    b.Property<DateTime>("ModifyDate");

                    b.Property<int>("MonthOfLoading");

                    b.Property<int>("MonthOfReceiving");

                    b.Property<Guid>("OriginId");

                    b.Property<Guid>("PickupAreaId");

                    b.Property<int>("ReceiveNumber");

                    b.Property<DateTime>("ReceivedDate");

                    b.Property<DateTime?>("ShipDepartureDate");

                    b.Property<DateTime?>("ShipDockingDestinationDate");

                    b.Property<DateTime?>("StuffingDate");

                    b.Property<Guid>("TruckId");

                    b.HasKey("ReceivingId");

                    b.HasIndex("CarrierId");

                    b.HasIndex("CrTypeId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DestinationId");

                    b.HasIndex("DriverId");

                    b.HasIndex("ItemColorId");

                    b.HasIndex("ItemModelId");

                    b.HasIndex("ItemTypeId");

                    b.HasIndex("OriginId");

                    b.HasIndex("PickupAreaId");

                    b.HasIndex("TruckId");

                    b.ToTable("Receiving");
                });

            modelBuilder.Entity("AutoLogistic.Models.Transactions.Shipping", b =>
                {
                    b.Property<Guid>("ShippingId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ActualDispatchDate");

                    b.Property<DateTime>("ActualTimeArrival");

                    b.Property<Guid>("CarrierId");

                    b.Property<DateTime>("ContainerBookedTime");

                    b.Property<DateTime>("ContainerClosingTime");

                    b.Property<string>("ContainerCode");

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime>("DeleteDate");

                    b.Property<DateTime>("EstimateTimeArrival");

                    b.Property<DateTime>("EstimateTimeDeparture");

                    b.Property<string>("InvoiceNumber");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("ModifyBy");

                    b.Property<int>("ModifyCount");

                    b.Property<DateTime>("ModifyDate");

                    b.Property<Guid>("RackPoleId");

                    b.Property<Guid>("ReceiverId");

                    b.Property<Guid>("ReceivingId");

                    b.Property<string>("SI");

                    b.Property<string>("SealCode");

                    b.Property<string>("ShipmentNumber");

                    b.Property<string>("ShippingBookingNumber");

                    b.Property<DateTime>("StuffingDate");

                    b.Property<DateTime>("StuffingDateEnd");

                    b.Property<DateTime>("StuffingDateStart");

                    b.Property<Guid>("TruckId");

                    b.Property<string>("VesselName");

                    b.Property<Guid>("WellbaseId");

                    b.HasKey("ShippingId");

                    b.HasIndex("CarrierId");

                    b.HasIndex("RackPoleId");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("ReceivingId");

                    b.HasIndex("TruckId");

                    b.HasIndex("WellbaseId");

                    b.ToTable("Shipping");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AutoLogistic.Models.Master.Truck", b =>
                {
                    b.HasOne("AutoLogistic.Models.Master.Trucker", "Trucker")
                        .WithMany("Trucks")
                        .HasForeignKey("TruckerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AutoLogistic.Models.Transactions.Delivering", b =>
                {
                    b.HasOne("AutoLogistic.Models.Master.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutoLogistic.Models.Transactions.Shipping", "Shipping")
                        .WithMany()
                        .HasForeignKey("ShippingId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutoLogistic.Models.Master.Truck", "Truck")
                        .WithMany()
                        .HasForeignKey("TruckId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AutoLogistic.Models.Transactions.Receiving", b =>
                {
                    b.HasOne("AutoLogistic.Models.Master.Carrier", "CarCarrier")
                        .WithMany()
                        .HasForeignKey("CarrierId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutoLogistic.Models.Master.CrType", "CrType")
                        .WithMany()
                        .HasForeignKey("CrTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutoLogistic.Models.Master.Customer", "Sender")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutoLogistic.Models.Master.City", "Destination")
                        .WithMany()
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutoLogistic.Models.Master.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverId");

                    b.HasOne("AutoLogistic.Models.Master.ItemColor", "CarColor")
                        .WithMany()
                        .HasForeignKey("ItemColorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutoLogistic.Models.Master.ItemModel", "CarModel")
                        .WithMany()
                        .HasForeignKey("ItemModelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutoLogistic.Models.Master.ItemType", "ItemType")
                        .WithMany()
                        .HasForeignKey("ItemTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutoLogistic.Models.Master.City", "Origin")
                        .WithMany()
                        .HasForeignKey("OriginId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutoLogistic.Models.Master.PickupArea", "PickupArea")
                        .WithMany()
                        .HasForeignKey("PickupAreaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutoLogistic.Models.Master.Truck", "Truck")
                        .WithMany()
                        .HasForeignKey("TruckId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AutoLogistic.Models.Transactions.Shipping", b =>
                {
                    b.HasOne("AutoLogistic.Models.Master.Carrier", "Carrier")
                        .WithMany()
                        .HasForeignKey("CarrierId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutoLogistic.Models.Master.RackPole", "RackPole")
                        .WithMany()
                        .HasForeignKey("RackPoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutoLogistic.Models.Master.Customer", "Receiver")
                        .WithMany()
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutoLogistic.Models.Transactions.Receiving", "Receiving")
                        .WithMany()
                        .HasForeignKey("ReceivingId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutoLogistic.Models.Master.Truck", "Truck")
                        .WithMany()
                        .HasForeignKey("TruckId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutoLogistic.Models.Master.Wellbase", "Wellbase")
                        .WithMany()
                        .HasForeignKey("WellbaseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AutoLogistic.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AutoLogistic.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutoLogistic.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
