using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gardens
{
    class GardensOfSemiramida
    {
        private int TheNumber;
        private string TheName;
        private string ThePlace;

        public GardensOfSemiramida()
        {
            TheNumber = 2;
            TheName = "Висячие сады Семирамиды";
            ThePlace = "Вавилон";
        }

        public void Prn()
        {
            Console.WriteLine($"Номер чуда света - {TheNumber}");
            Console.WriteLine($"Название чуда света - {TheName}");
            Console.WriteLine($"Местонахождение чуда света - {ThePlace}");
        }
    }
}
