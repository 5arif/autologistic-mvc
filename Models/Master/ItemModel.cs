using System;
using System.ComponentModel.DataAnnotations;
using AutoLogistic.Models.Common;

namespace AutoLogistic.Models.Master
{
    public class ItemModel :BaseDescriptions
    {
        [Key]
        public Guid ItemModelId { get; set; }
        public string Model { get; set; }
    }
}
