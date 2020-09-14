using System;

namespace FactoryPatternVehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfWheels;
            bool input = false;
            do
            {

                Console.WriteLine("Enter the amount of tires for the vehicle you'd like to create:");

                input = int.TryParse(Console.ReadLine(), out numOfWheels);

            } while (input == false);

            var vehicle = VehicleFactory.GetVehicle(numOfWheels); // this method gives us a new vehicle
            vehicle.Drive();
        }
    }
}
