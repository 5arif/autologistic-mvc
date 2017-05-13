using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoLogistic.Models.Common;

namespace AutoLogistic.Models.Master
{
    public class Customer : BaseDescriptions
    {
        [Key]
        public Guid CustomerId { get; set; }
        public string Name { get; set; }
    }
}
