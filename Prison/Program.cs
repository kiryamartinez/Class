using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prison
{
    class Program
    {
        static void Main(string[] args)
        {
            Prison prison = new Prison(new Prisoner[] { new Prisoner("Вася", 500), new Prisoner("Катя",250) });
            prison.ShowPrisoner(250);
        }
    }
    class Prison
    {
        private Prisoner[] _prisoners;
        public Prison(Prisoner[] prisoners)
        {
            _prisoners = prisoners;
        }
        public void ShowPrisoner(int number)
        {
            for (int i = 0; i < _prisoners.Length; i++)
            {
                if(_prisoners[i].Number == number)
                {
                    _prisoners[i].ShowInfo();
                }
            }
        }
    }
    class Prisoner
    {
        private string _name;
        public int Number { get; private set ;}
        public Prisoner(string name, int number)
        {
            _name = name;
            Number = number;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Заключенный: " + Number + " Имя: " + _name);
        }
    }
}
