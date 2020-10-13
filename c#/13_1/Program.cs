using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Описать стуктуру Article, содержащую следующие поля:
 * код товара
 * название товара
 * цена товара
 */
namespace _13_1
{
    struct Article
    {
        public int ProductId;
       public string ProductName;
        public double ProductPrice;
    }
    
    struct Client
    {
        public int ClientId;
        public string ClientName;
        public string ClientAddress;
        public string ClientPhone;
        public int ClientOrdersCount;
        public double ClientAllOrdersSum;
    }

    struct RequestItem
    {
        public string ItemName;

    }

    class Program
    {
        static void Main(string[] args)
        {
            Article a = new Article();
            a.ProductId = 1;
            a.ProductName = "телевизор";
            a.ProductPrice = 3500;

            Console.WriteLine($"Код товара - {a.ProductId}\nНазвание товара - {a.ProductName}\nЦена продукта - {a.ProductPrice}");
            
        }
    }
}
