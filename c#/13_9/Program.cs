using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Egipet;
using Gardens;

namespace _13_9
{
    class Program
    {
        static void Main(string[] args)
        {
            EgiptPiramids w1 = new EgiptPiramids();
            w1.Prn();
            Console.WriteLine("------------------------");

            GardensOfSemiramida w2 = new GardensOfSemiramida();
            w2.Prn();
            Console.WriteLine("------------------------");

        }
    }
}
