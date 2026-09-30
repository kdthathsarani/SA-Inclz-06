using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class EntertainmentRobot : Robot
    {
        public string entertainmentFeature;

        public EntertainmentRobot(
            string modelName,
            int batteryCapacity,
            string softwareVersion,
            string entertainmentFeature)
        {
            this.modelName = modelName;
            this.batteryCapacity = batteryCapacity;
            this.softwareVersion = softwareVersion;
            this.entertainmentFeature = entertainmentFeature;
        }

        public override void PerformTask()
        {
            Console.WriteLine("Performing Entertainment Feature");
        }
    }
}
