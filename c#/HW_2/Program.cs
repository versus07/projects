using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

/*
 * Преобразовать массив так, чтобы сначала шли все отрицательные элементы, а потом - положительные.
 * 0 - положительный
 */
 
namespace HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 10;

            int[] Array = new int[size] { -5, 5, 0, 4, -3, -2, 6, 8, 1,6};

            foreach (int i in Array)
            {
                Console.Write(i + " ");            
            }
            Console.WriteLine();
            ////
            ///
            int temp;
            for (int i=0;i<size;i++)
            {
                for (int j=size-1;j>i;j--)
                {
                    if ((!(Array[j-1]<0))&&(Array[j]<0))
                    {
                        temp = Array[j];
                        Array[j] = Array[j-1];
                        Array[j-1] = temp;
                    }
                }
            }
            foreach (int i in Array)
            {
                Console.Write(i + " ");
            }
        }
        
    }
}
