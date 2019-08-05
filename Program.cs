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
        }

        //public static void carsGUI()
        //{
        //    Console.WriteLine(" Welcome to Cars. Select number for continuation.");
        //    Console.WriteLine(" 1 - add car; 2 - delete car; 3 - exit")
        //    string selection = Console.ReadLine(); 
        //    switch(selection)
        //    {
        //        case "1"
        //    }
        //}
        
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
            Console.WriteLine("Car successfully added!");
        }

        public static void outputCars()
        {
            Console.WriteLine("Output cars");
            foreach(Car item in cars)
            {
                item.GetInfo();
            }
        }





    }
}
