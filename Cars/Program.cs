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
        static void Main(string[] args)
        {
            //Inializer();
            for(int a = 0; ;)
            {
                carsGUI();
            }
        }

        public static void carsGUI()
        {
            Console.WriteLine(" Welcome to Cars. Select number for continuation.");
            Console.WriteLine(" 1 - output all cars; 2 - add car; 3 - delete car; 4 - exit;");
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
            //Console.WriteLine("Enter year of production:");
            //DateTime productionYear = Console.ReadLine();
            Console.Write(" Enter car color: ");
            string color = Console.ReadLine();
            Console.WriteLine(" Enter, how much km car traveled: ");
            int kmTraveled = Int32.Parse(Console.ReadLine());

            Car car = new Car(kmTraveled);
            cars.Add(car);
            Console.WriteLine(" Car successfully added!");
        }

        public static void outputCars()
        {
            Console.WriteLine("Output cars");
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
                id = cars.Count,
                mark = "Opel",
                model = "Astra",
                color = "black",
                kmTraveled = 680
            };
        }





    }
}
