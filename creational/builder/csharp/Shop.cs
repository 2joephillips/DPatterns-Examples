namespace csharp
{
/// <summary>
/// The 'Director' class
/// </summary>
    internal class Shop
    {
        public void Construct(IVehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }
}
