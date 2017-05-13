using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoLogistic.Models.Common;

namespace AutoLogistic.Models.Master
{
    public class ItemType : BaseDescriptions
    {
        [Key]
        public Guid ItemTypeId { get; set; }
        public string Type { get; set; }
    }
}
