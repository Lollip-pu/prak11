using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Player
    {
        private int level;
        private int health;
        public int Level
        {
            get { return level; }
            set
            {
                if (value > 0 && value <= 100)
                    level = value;
                else
                    Console.WriteLine("Уровень должен быть от 1 до 100.");
            }
        }
        public int Health { get { return health; } set {
                if (value >= 0 && value <= 100)
                    level = value;
                else Console.WriteLine("Здоровье должно быть от 1 до 100.");
            } }
        public string name;
        public string Name { get; private set; }
        public bool IsAlive { get { return Health > 0; } }
        public Player(string name, int level, int health)
        {
            this.name = name;
            this.level = level;
            this.health = health;
        }
        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0) Health = 0;

            string alive = IsAlive ? "да" : "нет";
            Console.WriteLine($"Игрок: {name}, уровень: {Level}, здоровье: {Health}, жив: {alive}");
        }
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Alex", 5 , 70);
            player.TakeDamage(30);
            player.TakeDamage(40);
           

        }
    }
}
