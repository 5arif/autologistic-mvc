using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AutoLogistic.Models.Common;

namespace AutoLogistic.Models.Master
{
    public class Trucker : BaseDescriptions
    {
        [Key]
        public Guid TruckerId { get; set; }
        public string TruckerName { get; set; }

        public virtual ICollection<Truck> Trucks { get; set; }
    }
}
