namespace csharp
{
    class Program
    {
        static void Main()
        {
            IVehicleBuilder builder;
            Shop shop = new Shop();

            builder = new ScooterBuilder();
            shop.Construct(builder);
            var scooter = builder.GetVehicle();
            scooter.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            Vehicle car = builder.GetVehicle();
            car.Show();
            
            builder = new MotorcycleBuilder();
			shop.Construct(builder);
			var motorcycle = builder.GetVehicle();
            motorcycle.Show();

        }
    }
}
