using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NotUniqInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr=new int[10] {5,4,2,3,4,6,8,0,1,3};
            Console.WriteLine("Исходный массив:");
            foreach (int i in Arr)
            {
                Console.Write(Arr[i] + " ");
            }
            Console.WriteLine();


            Array.Sort(Arr);
            Console.WriteLine("Отсортированный массив:");
            foreach (int i in Arr)
            {
                Console.Write(Arr[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Неуникальные значения:");
            for (int i=0;i<10;i++)
            {
                if (Array.IndexOf(Arr,Arr[i],i+1)!=-1)
                {
                    Console.Write(Arr[i]+" ");
                }
            }
            Console.WriteLine();
        }
    }
}
