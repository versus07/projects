using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tovary
{
    enum Status
    {
        PRISHLO, PRODANO, PEREDANO, SPISANO
    }
    class Dvizh
    {
        public Tovar[] Lot { get; set; }
        public Status Condition { get; set; }

        public Dvizh(Tovar[] lot, Status condition)
        {
            Lot = lot;
            Condition = condition;
        }

        public override string ToString()
        {
            return string.Format("Уставить состояние:\t{0}\n",
                Condition);
        }

        public void Show()
        {
            foreach (var item in Lot)
            {
                Console.WriteLine($"Состояние:\t{Condition}");
                Console.WriteLine(item);
            }
        }

    }
}

        

