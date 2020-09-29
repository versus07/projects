using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

/*
 * В двумерном массиве MxN поменять местами заданные столбцы
 */
namespace HW_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива M x N");
            int M, N;
            M = Convert.ToInt32(Console.ReadLine());
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[,] Array = new int[M, N];

            Random rnd = new Random();

            for (int i=0;i<M;i++)
            {
                for (int j=0;j<N;j++)
                {
                    Array[i, j] = rnd.Next() % 10;
                    Console.Write(Array[i, j] + "   ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Введите номера столбцов, которые нужно поменять местами ");
            int column1, column2,tmp;
            column1 = Convert.ToInt32(Console.ReadLine());
            column2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            //Обмен столбцов
            for (int i=0;i<M;i++)
            {
                tmp=Array[i, column1];
                Array[i, column1] = Array[i, column2];
                Array[i, column2] = tmp;
            }
            /////////////
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    
                    Console.Write(Array[i, j] + "   ");
                }
                Console.WriteLine();
            }

        }
    }
}
