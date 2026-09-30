using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ServiceRobot : Robot
    {
        public string serviceTask;

        public ServiceRobot(
            string modelName,
            int batteryCapacity,
            string softwareVersion,
            string serviceTask)
        {
            this.modelName = modelName;
            this.batteryCapacity = batteryCapacity;
            this.softwareVersion = softwareVersion;
            this.serviceTask = serviceTask;
        }

        public override void PerformTask()
        {
            Console.WriteLine("Performing Service Task");
        }
    }
}

