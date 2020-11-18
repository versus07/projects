using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DictApp
{
    class EnRuDict
    {
        protected Dictionary<string, string> EnRu;

        //Создание словаря
        public EnRuDict()
        {
            EnRu = new Dictionary<string, string>();

        }
        
        //добавление слова
        public void WordEnRuAdd()
        {
            string word, translation;
            
            Console.WriteLine("Введите английское слово ");
            word=Console.ReadLine();
            Console.WriteLine("Введите его перевод ");
            translation = Console.ReadLine();
            EnRu.Add(word, translation);
        }

        //удаление слова


        //печать словаря
        public void PrintEnRuDict()
        {
            foreach (KeyValuePair<string, string> keyValue in EnRu)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
        }

        //поиск слова


        //сохранение словаря в файл


        //загрузка словаря из файла

    }
}
