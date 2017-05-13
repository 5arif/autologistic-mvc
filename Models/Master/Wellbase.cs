using System;
using System.ComponentModel.DataAnnotations;
using AutoLogistic.Models.Common;

namespace AutoLogistic.Models.Master
{
    public class Wellbase : BaseDescriptions
    {
        [Key]
        public Guid WellbaseId { get; set; }
        public string WellbaseNumber { get; set; }
    }
}
