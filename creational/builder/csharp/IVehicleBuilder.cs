namespace csharp
{
    interface  IVehicleBuilder
    {
         Vehicle GetVehicle();
         void BuildFrame();
         void BuildEngine();
         void BuildWheels();
         void BuildDoors();
    }
}
