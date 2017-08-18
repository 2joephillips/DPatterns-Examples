using System;
using System.Collections.Generic;

namespace csharp
{
    class CarBuilder : IVehicleBuilder
	{
		public Vehicle vehicle { get; set; }
        public CarBuilder() => vehicle = new Vehicle("Car");
        public void BuildFrame() => vehicle["frame"] = "Car Frame";
        public void BuildEngine() => vehicle["engine"] = "2500 cc";
        public  void BuildWheels() => vehicle["wheels"] = "4";
		public  void BuildDoors() => vehicle["doors"] = "4";
        public Vehicle GetVehicle() => vehicle;
    }

}