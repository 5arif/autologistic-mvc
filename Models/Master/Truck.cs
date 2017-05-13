using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoLogistic.Models.Common;

namespace AutoLogistic.Models.Master
{
    public class Truck : BaseDescriptions
    {
        [Key]
        public Guid TruckId { get; set; }
        public Guid TruckerId { get; set; }
        public string PoliceRegNumber { get; set; }
        
        [ForeignKey("TruckerId")]
        public virtual Trucker Trucker { get; set; }
    }
}
