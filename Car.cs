using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Car
    {
        public int id;
        public string mark;
        public string model;
        public DateTime productionYear;
        public string color;
        public int kmTraveled;

        public void GetInfo()
        {
            Console.WriteLine(
                $"Mark: {mark}; Model: {model}; Production Year: " +
                $"{productionYear}; Color: {color}; Km traveled: {kmTraveled}"
                );
        }

        public Car(int kmTraveled)
        {
            kmTraveled = 100;
        }
    }
}
