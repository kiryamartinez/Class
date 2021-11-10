using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter[] fighters = { new Fighter("Alex", 500, 50, 0), new Fighter("Bob", 250, 80, 30), new Fighter("John", 100, 80, 50) };
            for (int i = 0; i < fighters.Length; i++)
            {
                Console.Write(i + 1  + " "); 
                fighters[i].ShowStats();
            }
            Console.Write("Выберите бойца левых ворот: ");
            Fighter leftFighter = fighters[Convert.ToInt32(Console.ReadLine()) - 1];
            Console.Write("Выберите бойца правых ворот: ");
            Fighter rightFighter = fighters[Convert.ToInt32(Console.ReadLine()) - 1];
            while (leftFighter.Health > 0 && rightFighter.Health > 0)
            {
                rightFighter.TakeDamage(leftFighter.Damage);
                leftFighter.TakeDamage(rightFighter.Damage);
                leftFighter.ShowStats();
                rightFighter.ShowStats();
                Console.WriteLine();
            }
        }
    }
    class Fighter
    {
        private string _name;
        public int Health { get; private set; }
        public int Damage { get; private set; }
        private int _armor;
        public Fighter(string name, int health, int damage, int armor)
        {
            _name = name;
            Health = health;
            Damage = damage;
            _armor = armor;
        }
        public void ShowStats()
        {
            Console.WriteLine($"Name: {_name} - HP {Health} - DMG {Damage} - ARMOR {_armor}");
        }
        public void TakeDamage(int damage)
        {
            Health -= damage - _armor;
        }
    }
}
