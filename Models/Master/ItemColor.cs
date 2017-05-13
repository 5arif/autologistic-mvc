using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoLogistic.Models.Common;

namespace AutoLogistic.Models.Master
{
    public class ItemColor : BaseDescriptions
    {
        [Key]
        public Guid ItemColorId { get; set; }
        public string Color { get; set; }
    }
}
