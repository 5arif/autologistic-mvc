using System;
using System.ComponentModel.DataAnnotations;
using AutoLogistic.Models.Common;

namespace AutoLogistic.Models.Master
{
    public class CrType : BaseDescriptions
    {
        [Key]
        public Guid CrTypeId { get; set; }
        public string CrName { get; set; }
    }
}
