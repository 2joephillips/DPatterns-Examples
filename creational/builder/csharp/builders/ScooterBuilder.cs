using System;
using System.Collections.Generic;

namespace csharp
{
    internal class ScooterBuilder : VehicleBuilder 
    {
        public ScooterBuilder()
        {
            vehicle = new Vehicle("Scooter");
        }

        public override void BuildDoors()
        {
            vehicle["doors"] = "0";
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "500 cc";
        }

        public override void BuildFrame()
        {
            vehicle["frame"] = "Scooter Frame";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "2";
        }
    }
}