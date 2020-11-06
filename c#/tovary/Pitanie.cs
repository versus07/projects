using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tovary
{
    class Pitanie:Tovar
    {
        string Gruppa { get; set; }

        public Pitanie(string nazv, double cena, int kolvo, string gruppa = "Продукты питания") : base(nazv, cena, kolvo)
        {
            Gruppa = gruppa;
        }

        public override string ToString()
        {
            return string.Format("Группа товара " + Gruppa + "\nНазвание товара " + Nazv + "\nЦена товара " + Cena + "\nКоличество товара " + Kolvo);
        }
    }
}
