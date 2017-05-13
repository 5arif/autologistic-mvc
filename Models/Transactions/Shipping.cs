using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoLogistic.Models.History;
using AutoLogistic.Models.Master;

namespace AutoLogistic.Models.Transactions
{
    public class Shipping : RowHistory
    {
        [Key]
        public Guid ShippingId  { get; set; }
        public Guid CarrierId   { get; set; }
        public Guid ReceiverId  { get; set; }
        public Guid ReceivingId { get; set; }
        public Guid TruckId     { get; set; }
        public Guid WellbaseId  { get; set; }
        public Guid RackPoleId  { get; set; }

        public DateTime StuffingDate      { get; set; }
        public DateTime StuffingDateEnd   { get; set; }
        public DateTime StuffingDateStart { get; set; }
        public string InvoiceNumber       { get; set; }

        public string ContainerCode         { get; set; }
        public string SealCode              { get; set; }
        public string ShipmentNumber        { get; set; } //?
        public string ShippingBookingNumber { get; set; }
        public string SI                    { get; set; } //?
        public string VesselName            { get; set; }

        public DateTime ActualDispatchDate    { get; set; }
        public DateTime ActualTimeArrival     { get; set; }
        public DateTime ContainerBookedTime   { get; set; }
        public DateTime ContainerClosingTime  { get; set; }
        public DateTime EstimateTimeArrival   { get; set; }
        public DateTime EstimateTimeDeparture { get; set; }

        [ForeignKey("ReceiverId")]
        public virtual Customer Receiver { get; set; } //Dealer Penerima

        [ForeignKey("ReceivingId")]
        public virtual Receiving Receiving { get; set; }

        [ForeignKey("TruckId")]
        public virtual Truck Truck { get; set; }
        
        [ForeignKey("CarrierId")]
        public virtual Carrier Carrier { get; set; }

        [ForeignKey("WellbaseId")]
        public virtual Wellbase Wellbase { get; set; }

        [ForeignKey("RackPoleId")]
        public virtual RackPole RackPole { get; set; }
    }
}
