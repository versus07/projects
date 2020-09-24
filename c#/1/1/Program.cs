using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Дано значение температуры T в градусах Фаренгейта. 
 * Определить значение этой же температуры в градусах Цельсия. 
 * Температура по Цельсию TC и температура по Фаренгейту TF 
 * связаны следующим соотношением:
 * TC = (TF – 32)·5 / 9.
*/

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
                double tF, tC;
                Console.WriteLine("Введите температуру в градусах Фаренгейта ");
                tF = Convert.ToDouble(Console.ReadLine());
                tC = Math.Round((tF - 32) * 5 / 9);
                Console.WriteLine("Температура в градусах Целься равна " + tC);
            }
        }
    }
