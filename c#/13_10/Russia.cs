using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ru
{
    class Russia
    {
        private string Capital;
        private double Population;

        public Russia()
        {
            Capital = "Москва";
            Population = 12678079;
        }

        public void Prn()
        {
            Console.WriteLine("Страна - Россия");
            Console.WriteLine($"Столица - {Capital}");
            Console.WriteLine($"Население - {Population}");
        }

        public double GetPopolation()
        {
            return Population;
        }

    }
}
