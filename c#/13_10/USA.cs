using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Us
{
    class USA
    {
        private string Capital;
        private double Population;

        public USA()
        {
            Capital = "Вашингтон";
            Population = 754909;
        }

        public void Prn()
        {
            Console.WriteLine("Страна - Соединенные Штаты Америки");
            Console.WriteLine($"Столица - {Capital}");
            Console.WriteLine($"Население - {Population}");
        }

        public double GetPopolation()
        {
            return Population;
        }
    }
}
