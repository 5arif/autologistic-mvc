using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoLogistic.Models.History;
using AutoLogistic.Models.Master;

namespace AutoLogistic.Models.Transactions
{
    public class Delivering : RowHistory
    {
        [Key]
        public Guid DeliveringId { get; set; }
        public Guid DriverId     { get; set; }
        public Guid ShippingId   { get; set; }
        public Guid TruckId      { get; set; }

        public bool     Incident                 { get; set; }
        public DateTime ContainerUnloadDate      { get; set; }
        public DateTime ContainerUnloadTimeEnd   { get; set; }
        public DateTime ContainerUnloadTimeStart { get; set; }
        public DateTime CustomerReceivedTime     { get; set; }
        public DateTime CustomerSentDate         { get; set; }
        public DateTime CustomerSentTime         { get; set; }
        public DateTime ShipDockingDate          { get; set; }
        public int      KmArrival                { get; set; }
        public string   CustomerReceiverName     { get; set; }
        public string   Note                     { get; set; }

        [ForeignKey("ShippingId")]
        public virtual Shipping Shipping { get; set; }

        [ForeignKey("TruckId")]
        public virtual Truck Truck { get; set; }

        [ForeignKey("DriverId")]
        public virtual Driver Driver { get; set; }
    }
}
