using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class IndustrialRobot : Robot
    {
        public string industrialTask;

        public IndustrialRobot(
            string modelName,
            int batteryCapacity,
            string softwareVersion,
            string industrialTask)
        {
            this.modelName = modelName;
            this.batteryCapacity = batteryCapacity;
            this.softwareVersion = softwareVersion;
            this.industrialTask = industrialTask;
        }

        public override void PerformTask()
        {
            Console.WriteLine("Performing Industrial Task");
        }
    }
}

