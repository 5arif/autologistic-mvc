using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoLogistic.Models.History;
using AutoLogistic.Models.Master;

namespace AutoLogistic.Models.Transactions
{
    public class Receiving : RowHistory
    {
        [Key]
        public Guid ReceivingId { get; set; }

        //fk
        public Guid OriginId      { get; set; }
        public Guid DestinationId { get; set; }
        public Guid CustomerId    { get; set; }
        public Guid ItemTypeId    { get; set; }
        public Guid ItemModelId   { get; set; }
        public Guid ItemColorId   { get; set; }
        public Guid CarrierId     { get; set; }
        public Guid PickupAreaId  { get; set; }
        public Guid TruckId       { get; set; }
        public Guid CrTypeId      { get; set; }

        //nullable fk
        public Guid? DriverId { get; set; }

        public DateTime  ReceivedDate               { get; set; }
        public DateTime? ItemReceiveDate            { get; set; }
        public DateTime? ShipDepartureDate          { get; set; }
        public DateTime? ShipDockingDestinationDate { get; set; }
        public DateTime? StuffingDate               { get; set; }
        public int       DaysInStorage              { get; set; }
        public int       MonthOfLoading             { get; set; }
        public int       MonthOfReceiving           { get; set; }
        public int       ReceiveNumber              { get; set; }
        public int?      DaysDoorToDoor             { get; set; }
        public int?      DaysInTheShip              { get; set; }
        public string    CustomerDispatchNoteDate   { get; set; }
        public string    CustomerDispatchNoteNumber { get; set; }
        public string    DispatchNoteNumber         { get; set; }
        public string    CarrierDispatchNote        { get; set; }
        public string    EngineNumber               { get; set; }
        public string    FrameNumber                { get; set; }
        public string    IncidentRecord             { get; set; }

        [ForeignKey("OriginId")]
        public virtual City Origin { get; set; }

        [ForeignKey("DestinationId")]
        public virtual City Destination { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Sender { get; set; }

        [ForeignKey("ItemTypeId")]
        public virtual ItemType ItemType { get; set; }

        [ForeignKey("ItemModelId")]
        public virtual ItemModel CarModel { get; set; }

        [ForeignKey("ItemColorId")]
        public virtual ItemColor CarColor { get; set; }

        [ForeignKey("CarrierId")]
        public virtual Carrier CarCarrier { get; set; }

        [ForeignKey("PickupAreaId")]
        public virtual PickupArea PickupArea { get; set; }

        [ForeignKey("TruckId")]
        public virtual Truck Truck { get; set; }

        [ForeignKey("DriverId")]
        public virtual Driver Driver { get; set; }

        [ForeignKey("CrTypeId")]
        public virtual CrType CrType { get; set; }
    }
}
