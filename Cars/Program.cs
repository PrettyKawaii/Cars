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
            Console.WriteLine(" 1 - output all buses; 2 - manage doorStatus; 3 - add bus; 4 - delete bus; 5 - travel; 6 - exit; ");
            string selection = Console.ReadLine();
            switch (selection)
                case "1":
                    outputCars();
                    break;
                case "2":
                    Bus bus = new Bus();
                    bus.doorTurn();
                    break;
                case "3":
                    addCar();
                    break;
                case "4":
                    deleteCar();
                    break;
                case "5":
                    travel();
                    break;
                case "6":
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

        public static void carsType()
        {
            Console.WriteLine("Welcome, select, with what you've want work:");
            Console.WriteLine("1 - Cars; 2 - Buses");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    carsGUI();
                    break;
                case "2":
                    busesGUI();
                    break;
            }
        }

            public static void carsGUI()
        {
            Console.WriteLine(" Welcome to Cars. Select number for continuation.");
            Console.WriteLine(" 1 - output all cars; 2 - add car; 3 - delete car; 4 - travel; 5 - exit;");
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
                    travel();
                    break;
                case "5":
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

        public static void Initializer()
        {
            Car car1 = new Car()
            {
                id = cars.Count,
                mark = "Renaut",
                model = "DUSTER",
                color = "gray",
                kmTraveled = 0
            };

            Car car2 = new Car()
            {
                id = cars.Count+1,
                mark = "Opel",
                model = "Astra",
                color = "black",
                kmTraveled = 680
            };
            cars.Add(car1);
            cars.Add(car2);

            //cars.AddRange(new[] {
            //    car1,
            //    car2
            //});

            //cars.AddRange(cars);
        }

        public static void travel()
        {
            Car car = selectCar();
            Console.Write(" Enter, how much km you've want travel: ");
            int travelKm = Int32.Parse(Console.ReadLine());
            car.kmTraveled = travelKm;
            Console.WriteLine(" Travel is successfully!");
        }




    }
}
