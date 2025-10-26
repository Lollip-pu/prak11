using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Product
    {
        private double price;
        private double discount;
        public string Name { get; set; } = "Без названия";

        public double Price
        {
            get => price; set
            {
                if (value > 0)
                    price = value;
                else Console.WriteLine("Цена не может быть отрицательной.");
            }
        }
        public double Discount
        {
            get => discount; set
            {
                if (value >= 0 && value <= 100)
                    discount = value;
            }
        }
        public double FinalPrice => Price * (1 - Discount / 100);

        public Product(double price, double discount)
        {
            Price = price;
            Discount = discount;
        }
        public void Show()
        {
            Console.WriteLine($"{Name}:{FinalPrice}(скидка {Discount}%)");
        }
    }


        internal class Program
    {
        static void Main(string[] args)
        {
                Product product = new Product(800 , 20);
                product.Name = "Ноутбук";
                product.Show();
                product.Discount = 10;
                product.Show();
            Product product1 = new Product(-100, 10);
            product.Show();

        }
    }
}
