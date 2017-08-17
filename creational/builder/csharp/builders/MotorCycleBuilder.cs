using System;
using System.Collections.Generic;

namespace csharp
{
    class MotorcycleBuilder : IVehicleBuilder
	{
		public Vehicle vehicle { get; set; }
		public MotorcycleBuilder()
		{
			vehicle = new Vehicle("MotorCycle");
		}

		public  void BuildFrame()
		{
			vehicle["frame"] = "MotorCycle Frame";
		}

		public  void BuildEngine()
		{
			vehicle["engine"] = "500 cc";
		}

		public  void BuildWheels()
		{
			vehicle["wheels"] = "2";
		}

		public  void BuildDoors()
		{
			vehicle["doors"] = "0";
		}

        public Vehicle GetVehicle()
        {
            return vehicle;
        }
    }

}