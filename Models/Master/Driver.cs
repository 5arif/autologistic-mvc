using System;
using System.ComponentModel.DataAnnotations;
using AutoLogistic.Models.History;

namespace AutoLogistic.Models.Master
{
    public class Driver : RowHistory
    {
        [Key]
        public Guid DriverId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
