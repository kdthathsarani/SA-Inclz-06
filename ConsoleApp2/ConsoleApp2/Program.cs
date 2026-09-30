using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ServiceRobot original = new ServiceRobot(
                "SR-100",
                10,
                "V1.0",
                "Customer Assistance"
            );

            ServiceRobot cloned = (ServiceRobot)original.Clone();

            cloned.batteryCapacity = 15;
            cloned.softwareVersion = "V2.0";

            Console.WriteLine("Original Robot");
            Console.WriteLine("Model: " + original.modelName);
            Console.WriteLine("Battery: " + original.batteryCapacity + " hours");
            Console.WriteLine("Software: " + original.softwareVersion);

            Console.WriteLine();

            Console.WriteLine("Cloned Robot");
            Console.WriteLine("Model: " + cloned.modelName);
            Console.WriteLine("Battery: " + cloned.batteryCapacity + " hours");
            Console.WriteLine("Software: " + cloned.softwareVersion);

            Console.WriteLine();

            cloned.PerformTask();

            Console.ReadLine();
        }
    }
}
