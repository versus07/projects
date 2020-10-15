using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Egipet
{
    class EgiptPiramids
    {
        private int TheNumber;
        private string TheName;
        private string ThePlace;

        public EgiptPiramids()
        {
            TheNumber = 1;
            TheName = "Египесткие пирамиды";
            ThePlace = "Египет";
        }

        public void Prn()
        {
            Console.WriteLine($"Номер чуда света - {TheNumber}");
            Console.WriteLine($"Название чуда света - {TheName}");
            Console.WriteLine($"Местонахождение чуда света - {ThePlace}");
        }

        
    }
}
