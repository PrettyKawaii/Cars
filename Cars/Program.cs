using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class CarSystem
    {
        static void Main(string[] args)
        {
            Bus bus1 = new Bus(11, "Bus1");
            Bus bus2 = new Bus(1, "Bus2");

            //bus1.doorOn();
            //bus2.doorOff();
            Bus.doorStatus = true;

            bus1.GetInfo();
            bus2.GetInfo();
        }
    }
}
