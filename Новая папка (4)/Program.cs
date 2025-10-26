
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практика11
{
    class Car
    {
        private int speed;
        public string Model { get; set; } = "Unknown";
        public int Speed { get {  return speed; } set
            {
                if (value >= 0 && value <= 300)
                    speed = value;
                else
                    Console.WriteLine("Скорость не может превышать 300.");
            } }


        public Car(string model, int speed)
        {
                this.speed = speed; 
            this.Model = model;
        }
        public void Drive()
        {
            Console.WriteLine($"{Model} едет со скоростью {speed} км/ч");
        }
    }

     internal class Program
    {
        static void Main()
        {
            Car car = new Car("Dodge", 200);
            car.Drive();

            car.Speed = 400;
            car.Drive();

            car.Speed = -50;
            car.Drive();
        }
    }
}
