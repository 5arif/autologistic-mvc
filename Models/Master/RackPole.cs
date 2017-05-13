using System;
using System.ComponentModel.DataAnnotations;
using AutoLogistic.Models.Common;

namespace AutoLogistic.Models.Master
{
    public class RackPole : BaseDescriptions
    {
        [Key]
        public Guid RackId { get; set; }
        public string RackNumber { get; set; }
    }
}
