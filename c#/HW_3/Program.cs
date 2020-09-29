using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
/*
 * написать программу, которая предлагает ввести число и ищет, сколько раз это число встречается в массиве
 */
namespace HW_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE= 10;

            int[] Array= new int[SIZE];

            Random rnd = new Random();

            for (int i=0;i<SIZE;i++)
            {
                Array[i]=rnd.Next()%10- rnd.Next() % 10;
                Console.Write(Array[i] + " ");
            }
            Console.WriteLine("\nВведите число ");
            int n = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            for (int i=0;i<SIZE;i++)
            {
                if (Array[i]==n)
                {
                    count++;
                }
            }
            Console.WriteLine($"Число {n} встречатеся в массиве {count} раз(а)");
        }
    }
}
