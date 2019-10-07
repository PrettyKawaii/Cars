using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class CarSystem
    {
        static List<Car> cars = new List<Car>();
        static List<Bus> buses = new List<Bus>();
        static void Main(string[] args)
        {
            Initializer();
            for (int a = 0; ;)
            {
                carsType();
            }

        }

        public static void busesGUI()
        {
            Console.WriteLine("Welcome to the busesGUI, select number: ");
            Console.WriteLine(" 1 - output all buses; 2 - manage doorStatus; 3 - add bus; 4 - delete bus; 5 - travel; exit - exit; ");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    outputBus();
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
                    travelBus();
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine(" Unknowh choice.");
                    break;
            }
        }

        public static void outputBus()
        {
            foreach(Bus item in buses)
            {
                item.GetInfo();
            }
        }

        public static Bus selectBus()
        {
            Console.Write("Select bus id: ");
            outputBus();
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
        
        public static void travelBus()
        {
            Bus bus = selectBus();
            bus.kmTraveled = bus.kmTraveled + manageKm();
            Console.WriteLine(" Travel is successfully!");
        }

        public static void carsType()
        {
            Console.WriteLine("Welcome, select, with what you've want work:");
            Console.WriteLine("1 - Cars; 2 - Buses; exit - exit");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    carsGUI();
                    break;
                case "2":
                    busesGUI();
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
            }
            
        }

            public static void carsGUI()
        {
            Console.WriteLine(" Welcome to Cars. Select number for continuation.");
            Console.WriteLine(" 1 - output all cars; 2 - add car; 3 - delete car; 4 - travel; exit - exit;");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    outputCars();
                    break;
                case "2":
                    addCar();
                    break;
                case "3":
                    deleteCar();
                    break;
                case "4":
                    travelCar();
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine(" Unknowh choice.");
                    break;
            }
        }
        
        
    

        public static void addCar()
        {
            Console.Write(" Enter car mark: ");
            string mark = Console.ReadLine();
            Console.Write(" Enter car type: ");
            string type = Console.ReadLine();
            Console.Write(" Enter car model: ");
            string model = Console.ReadLine();
            Console.Write(" Enter year of production: ");
            int productionYear = Int32.Parse(Console.ReadLine());
            Console.Write(" Enter car color: ");
            string color = Console.ReadLine();
            Console.Write(" Enter, how much km car traveled: ");
            int kmTraveled = Int32.Parse(Console.ReadLine());
            Car car = new Car();
            car.mark = mark;
            car.type = type;
            car.model = model;
            car.productionYear = productionYear;
            car.color = color;
            car.kmTraveled = kmTraveled;
            car.id = cars.Count;
            cars.Add(car);
            Console.WriteLine(" Car successfully added!");  
        }

        public static void outputCars()
        {
            foreach(Car item in cars)
            {
                item.GetInfo();
            }
        }

        public static void deleteCar()
        {
            Car car = selectCar();
            cars.Remove(car);
            Console.WriteLine(" Car successfully deleted!");
            
        }

        public static Car selectCar()
        {
            Console.Write(" Select car id: ");
            outputCars();
            int selection = Int32.Parse(Console.ReadLine());
            Car car = cars.Single(x => x.id == selection);
            return car;
        }

        public static int manageKm()
        {
            Console.Write(" Enter, how much km you've want travel: ");
            int travelKm = Int32.Parse(Console.ReadLine());
            return travelKm;
        }

        public static void travelCar()
        {
            Car car = CarSystem.selectCar();
            car.kmTraveled = car.kmTraveled + manageKm();           
            Console.WriteLine(" Travel is successfully!");
        }

        public static void Initializer()
        {
            Bus bus1 = new Bus()
            {
                id = buses.Count,
                mark = "MA3",
                model = "103",
                color = "green",
                kmTraveled = 1450,
                seatingNum = 24,
                productionYear = 1996,
                type = "Bus"
            };
            Car car1 = new Car()
            {
                id = cars.Count,
                mark = "Renaut",
                model = "DUSTER",
                color = "gray",
                kmTraveled = 0,
                type = "Car"
            };

            Car car2 = new Car()
            {
                id = cars.Count+1,
                mark = "Opel",
                model = "Astra",
                color = "black",
                kmTraveled = 680,
                type = "Car"
            };
            cars.Add(car1);
            cars.Add(car2);
            buses.Add(bus1);

            //cars.AddRange(new[] {
            //    car1,
            //    car2
            //});

            //cars.AddRange(cars);
        }

       




    }
}
