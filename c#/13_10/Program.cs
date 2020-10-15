using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ru;
using Us;
using Fr;

namespace _13_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Russia c1 = new Russia();
            c1.Prn();
            USA c2 = new USA();
            c2.Prn();
            France c3 = new France();
            c3.Prn();

            double p1, p2, p3;
            p1 = c1.GetPopolation();
            p2 = c2.GetPopolation();
            p3 = c3.GetPopolation();

            double max;
            max = 0;
            
            if (p1 > p2 && p1 > p3)
            {
                max = p1;
                Console.WriteLine($"Столица с наибольшим населением - {max} - Москва");
            }
           
            if (p2 > p1 && p2 > p3)
                {
                    max = p2;
                Console.WriteLine($"Столица с наибольшим населением - {max} - Вашингтон");
            }
            
            if (p3 > p2 && p3 > p1)
                {
                    max = p3;
                Console.WriteLine($"Столица с наибольшим населением - {max} - Париж");
            }
                      
        


        }
    }
}
