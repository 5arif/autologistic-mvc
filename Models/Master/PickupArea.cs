using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoLogistic.Models.Common;

namespace AutoLogistic.Models.Master
{
    public class PickupArea :BaseDescriptions
    {
        [Key]
        public Guid PickupAreaId { get; set; }
        public string AreaName { get; set; }
    }
}
