﻿using System;
namespace FactoryPatternVehicles
{
    public class ConsoleLogger
    {
        public static void VehicleStartUpDialogue()
        {
            Console.WriteLine("Put key in ignition.");
            Thread.Sleep(1000);
            Console.WriteLine("Turn key!");
            Thread.Sleep(1000);
        }
    }
}
