using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Robot
    {
        public string modelName;
        public int batteryCapacity;
        public string softwareVersion;

        public abstract void PerformTask();

        public Robot Clone()
        {
            return (Robot)this.MemberwiseClone();
        }
    }
}
