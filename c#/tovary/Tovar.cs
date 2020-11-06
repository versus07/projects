using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tovary
{
   abstract class Tovar
    {
        public double Cena { get; set; } //цена товара
        public string Nazv { get; set; } // название товара
        public int Kolvo { get; set; } //количество товара 

        public  Tovar (string nazv, double cena, int kolvo)
        {
            Cena = cena;
            Nazv = nazv;
            Kolvo = kolvo;
        }

        public abstract override string ToString();
    }
}
