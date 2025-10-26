using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace _2
{

    class Phone
    {
        private int batteryLevel;
        public int BatteryLevel
        {
            get { return batteryLevel; }
            set
            {
                if (value >= 0 && value <= 100)
                    batteryLevel = value;
                else
                    Console.WriteLine("Заряд не может превышать 100.");
            }
        }
        public string Brand { get; private set; }
        public Phone (string Brand, int BatteryLevel)
        {
            this.Brand = Brand;
            this.BatteryLevel = BatteryLevel;
        }
        public void Use()
        {
            int BatteryLevel = batteryLevel - 10;
            if(BatteryLevel < 0)
                BatteryLevel = 0;
           batteryLevel = BatteryLevel;

            Console.WriteLine($"{Brand}: заряд {batteryLevel}%");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone("Samsung", 50);
            phone.Use();
            phone.Use();
            phone.Use();
            phone.BatteryLevel = 150;
        }
    }
}
