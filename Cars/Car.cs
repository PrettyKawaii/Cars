using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Car
    {
        public int id;
        public string mark;
        public string model;
        public int productionYear;
        public string color;
        public int kmTraveled;
        public string type;

        public void GetInfo()
        {
            Console.WriteLine(
                $" Id: {id}; Type: {type}; Mark: {mark}; Model: {model}; Production Year: " +
                $"{productionYear}; Color: {color}; Km traveled: {kmTraveled}"
                );
        }
        public Car()
        {

        }
        public Car(int kmTraveled, string type) 
        {
            kmTraveled = 100;
            type = "Car";
        }
    }
}
