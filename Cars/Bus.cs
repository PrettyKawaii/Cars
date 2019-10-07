using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Bus:Car
    {
        public Bus(int seatingNum)
        {
            seatingNum = 40;
        }

        public Bus()
        {
        }

        public static bool doorStatus;
        public int seatingNum;

        public void GetInfo()
        {
            Console.WriteLine($" Id: {id}; Mark: {mark}; Model: {model};" +
                $"Door status: {doorStatus}; Production Year: " +
                $"{productionYear}; Color: {color}; Km traveled: {kmTraveled}");
        }
        public void doorTurn()
        {
            Console.WriteLine("1 - open door; 2 - close door");
            int selection = Int32.Parse(Console.ReadLine());
            switch(selection)
            {
                case 1:
                    doorOn();
                    break;
                case 2:
                    doorOff();
                    break;
            }
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
