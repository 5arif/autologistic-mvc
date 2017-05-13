using System;
using System.ComponentModel.DataAnnotations;
using AutoLogistic.Models.Common;

namespace AutoLogistic.Models.Master
{
    public class Carrier : BaseDescriptions
    {
        [Key]
        public Guid CarrierId   { get; set; }
        public string CarrierName { get; set; }
    }
}
