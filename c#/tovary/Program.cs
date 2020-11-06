/*
    Разработать архитектуру классов иерархии товаров
    при разработке системы управления потоками товаров для
    дистрибьюторской компании. Прописать члены классов.
    Создать диаграммы взаимоотношений классов.
    Должны быть предусмотрены разные типы товаров,
    в том числе:
    • бытовая химия;
    • продукты питания.
    Предусмотреть классы управления потоком товаров
    (пришло, реализовано, списано, передано).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace tovary
{
    class Program
    {
        static void Main(string[] args)
        {
            Tovar[] goodsLot1 =
            {
                new Pitanie("Молоко", 1.20, 15),
                new Himiya("Стиральный порошок", 12.70, 20),
                new Himiya("Фэйри", 3.15, 30),
                new Pitanie("Макароны", 1.90, 15),
                new Himiya("Сыр", 5.20, 45)
            };

            Dvizh flow1 = new Dvizh(goodsLot1, Status.PRISHLO);
            flow1.Show();

            flow1.Condition = Status.PRODANO;
            Console.WriteLine(flow1.ToString());

            flow1.Show();

            Console.ReadKey();
        }
    }
    
}
