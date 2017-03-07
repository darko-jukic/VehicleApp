﻿using System.ComponentModel.DataAnnotations;

namespace VehicleApp.Service.Models
{
    public class VehicleModel
    {
        public int Id { get; set; }
        public int VehicleMakeId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Abrv { get; set; }
    }
}
