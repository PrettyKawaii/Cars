using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Bus:Car
    {
        public Bus()
        {

        }
        public Bus(int seatingNum, string type)
        {
            seatingNum = 40;
            type = "Bus";
        }

        public static bool doorStatus;
        public int seatingNum;

        public void GetInfo()
        {
            Console.WriteLine($" Id: {id}; Type: {type}; Mark: {mark}; Model: {model}; " +
                $"Door status: {doorStatus}; Production Year: " +
                $"{productionYear}; Color: {color}; Km traveled: {kmTraveled}");
        }
     
        public static void doorOn()
        {
            doorStatus = true;
            Console.WriteLine("Door was turned on!");
        }
        public static void doorOff()
        {
            doorStatus = false;
            Console.WriteLine("Door was turned off!");
        }
    }
}
