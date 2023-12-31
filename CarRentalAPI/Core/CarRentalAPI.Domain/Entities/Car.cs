﻿using CarRentalAPI.Domain.Entities.Common;

namespace CarRentalAPI.Domain.Entities
{
    public class Car 
    {
        public int Id { get; set; }
        public string CreatedDate { get; set; }
        public string? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Version { get; set; }
        public string ModelYear { get; set; }
        public string Class { get; set; }
        public string Body { get; set; }
        public short TrunkVolume { get; set; }
        public float HourlyPrice { get; set; }
        public byte MaxNumberOfPassengers { get; set; }
        public string Fuel { get; set; }
        public string Transmission { get; set; }
        public short HorsePower { get; set; }
        public string ImagePath { get; set; }
    }
}
