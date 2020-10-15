using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fr
{
    class France
    {
        private string Capital;
        private double Population;

        public France()
        {
            Capital = "Париж";
            Population = 2148000;
        }

        public void Prn()
        {
            Console.WriteLine("Страна - Франция");
            Console.WriteLine($"Столица - {Capital}");
            Console.WriteLine($"Население - {Population}");
        }

        public double GetPopolation()
        {
            return Population;
        }
    }
}
