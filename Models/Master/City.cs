﻿using System;
using System.ComponentModel.DataAnnotations;
using AutoLogistic.Models.Common;

namespace AutoLogistic.Models.Master
{
    public class City : BaseDescriptions
    {
        [Key]
        public Guid CityId { get; set; }
        public string CityName { get; set; }
    }
}
