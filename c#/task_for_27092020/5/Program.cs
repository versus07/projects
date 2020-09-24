using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Начальный вклад в банке равен 1000 руб. Через каждый месяц размер вклада увеличивается 
 * на P процентов от имеющейся суммы. По данному P определить, через сколько месяцев размер 
 * вклада превысит 1100 руб., и вывести найденное количество месяцев K и итоговый размер вклада S
 */
namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int vklad_nach= 1000;
            double P,S;
            int K;
            Console.WriteLine("Введите значение % ");
            P = Convert.ToDouble(Console.ReadLine());
            S = vklad_nach;
            K = 1;
            while (S<1100)
            {
                Console.WriteLine(K + "  " + S);
                S = S + S*P / 100;
                K++;
            }

            Console.WriteLine($"Количество месяцев {K} \n Итоговый размер вклада - {S}");


        }
    }
}
