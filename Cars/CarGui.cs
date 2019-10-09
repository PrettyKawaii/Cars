using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    static class CarGui
    {
        static List<Car> cars = new List<Car>();

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
                    //busesGUI();
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
            foreach (Car item in cars)
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
            Car car = selectCar();
            car.kmTraveled = car.kmTraveled + manageKm();
            Console.WriteLine(" Travel is successfully!");
        }

        public static void Initializer()
        {
            //Bus bus1 = new Bus()
            //{
            //    id = buses.Count,
            //    mark = "MA3",
            //    model = "103",
            //    color = "green",
            //    kmTraveled = 1450,
            //    seatingNum = 24,
            //    productionYear = 1996,
            //    type = "Bus"
            //};
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
                id = cars.Count + 1,
                mark = "Opel",
                model = "Astra",
                color = "black",
                kmTraveled = 680,
                type = "Car"
            };
            cars.Add(car1);
            cars.Add(car2);
            //buses.Add(bus1);

            //cars.AddRange(new[] {
            //    car1,
            //    car2
            //});

            //cars.AddRange(cars);
        }

    }
}
