using System;
namespace FactoryPatternVehicles
{
    public class Car : IVehicle
    {
        public Car()
        {
        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The car is driving at a safe pace. Oh boy!");
            
        }
    }
}
