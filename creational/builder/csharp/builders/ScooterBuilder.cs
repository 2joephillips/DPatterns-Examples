using System;
using System.Collections.Generic;

namespace csharp
{
    internal class ScooterBuilder : IVehicleBuilder 
    {
        public ScooterBuilder() => vehicle = new Vehicle("Scooter");
        public Vehicle vehicle { get; set; }
        public void BuildDoors() => vehicle["doors"] = "0";
        public void BuildEngine() => vehicle["engine"] = "500 cc";
        public void BuildFrame() => vehicle["frame"] = "Scooter Frame";
        public void BuildWheels() => vehicle["wheels"] = "2";
        public Vehicle GetVehicle() => vehicle;
    }
}