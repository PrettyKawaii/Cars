using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    static class BusGui
    {
        static List<Bus> buses = new List<Bus>();

        public static void busesGUI()
        {
            Console.WriteLine("Welcome to the busesGUI, select number: ");
            Console.WriteLine(" 1 - output all buses; 2 - manage doorStatus; 3 - add bus; 4 - delete bus; 5 - travel; exit - exit; ");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    //outputBus();
                    break;
                case "2":
                    doorTurn();
                    break;
                case "3":
                    addBus();
                    break;
                case "4":
                    deleteBus();
                    break;
                case "5":
                    //travelBus();
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine(" Unknowh choice.");
                    break;
            }
        }



        public static Bus selectBus()
        {
            Console.Write("Select bus id: ");
            //outputBus();
            int selection = int.Parse(Console.ReadLine());
            Bus bus = buses.Single(x => x.id == selection);
            return bus;
        }

        public static void doorTurn()
        {
            Bus bus = selectBus();
            Console.WriteLine("1 - open door; 2 - close door");
            int selection = Int32.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    Bus.doorOn();
                    break;
                case 2:
                    Bus.doorOff();
                    break;
            }
        }

        public static void addBus()
        {
            Console.Write(" Enter bus mark: ");
            string mark = Console.ReadLine();
            Console.Write(" Enter bus type: ");
            string type = Console.ReadLine();
            Console.Write(" Enter bus model: ");
            string model = Console.ReadLine();
            Console.Write(" Enter bus year of production: ");
            int productionYear = Int32.Parse(Console.ReadLine());
            Console.Write(" Enter bus color: ");
            string color = Console.ReadLine();
            Console.Write(" Enter, how much km bus traveled: ");
            int kmTraveled = Int32.Parse(Console.ReadLine());
            Console.Write(" Enter, how much seating have bus: ");
            int seatingNum = Int32.Parse(Console.ReadLine());
            Bus bus = new Bus();
            bus.mark = mark;
            bus.type = type;
            bus.model = model;
            bus.productionYear = productionYear;
            bus.color = color;
            bus.kmTraveled = kmTraveled;
            bus.seatingNum = seatingNum;
            bus.id = buses.Count;
            buses.Add(bus);
            Console.WriteLine(" Bus successfully added!");
        }

        public static void deleteBus()
        {
            Bus bus = selectBus();
            buses.Remove(bus);
            Console.WriteLine(" Bus successfuly deleted!");
        }

        //public static void travelBus()
        //{
        //    Bus bus = selectBus();
        //    bus.kmTraveled = bus.kmTraveled + manageKm();
        //    Console.WriteLine(" Travel is successfully!");
        //}

    }
}
