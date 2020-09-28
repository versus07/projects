using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Сжать массив, удалив из него все нули. Освободившиеся место справа заполнить -1
 */
namespace HW_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Array = new int[10] { 2, 0, 0, 4, 5, -7, 2, 9, 6, 0 };
            Console.WriteLine("Исходный массив");
            foreach (int i in Array)
            {
                Console.Write(i + " ");
            }

            //////////////////
            ///Находим в массиве нулевые элементы и уменьшаем размерность массива
            ////
            int n, s;
            s = 9;
            n= 0;
            while (n<s)
            {
                if (Array[n] == 0)
                {
                    s--;
                    for (int j = n; j < s; j++)
                    {
                        Array[j] = Array[j + 1];
                    }
                }
                else
                {
                    n++;
                }
                
            }
            Console.WriteLine();
            //////////////Дописываем в массив до исходной размерности значения -1
            for (int i=s;i<10;i++)
            {
                Array[i] = -1;
            }
            //////////////Выводим новый массив
            foreach (int i in Array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
