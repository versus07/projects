using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

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
            word = Console.ReadLine();
            Console.WriteLine("Введите его перевод ");
            translation = Console.ReadLine();
            EnRu.Add(word, translation);
        }

        //удаление слова
        public void WordEnRuDelete()
        {
            Console.WriteLine("Введите слово, которое хотите удалить из словаря");
            string word;
            word = Console.ReadLine();
            string value;
            if (EnRu.TryGetValue(word, out value))
            {
                EnRu.Remove(word);
                Console.WriteLine("Удалено!");
            }
            else
            {
                Console.WriteLine("Слово для удаление не найдено");
            }
        }


        //печать словаря
        public void PrintEnRuDict()
        {
            foreach (KeyValuePair<string, string> keyValue in EnRu)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
        }

        //поиск слова
        public void SearchEnRuDict()
        {
            Console.WriteLine("Введите английское слово, для которого надо найти перевод");
            string word;
            word = Console.ReadLine();
            string value;
            if (EnRu.TryGetValue(word, out value))
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("Перевод не найден!");
            }
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();

        }



        //сохранение словаря в файл
        public void SaveEnRuDict()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@"d:\enru.dic", true, System.Text.Encoding.UTF8))
                {
                    foreach (KeyValuePair<string, string> keyValue in EnRu)
                    {
                        sw.WriteLine(keyValue.Key +":"+ keyValue.Value);
                    }
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Запись словаря в файл...");
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();

        }

    //загрузка словаря из файла
    public void OpenEnRuDict()
        {
            string str;
            string words_keys;
            string words_values;
            int delim;
            try
            {
                using (StreamReader sw = new StreamReader(@"d:\enru.dic"))
                {
                    while (!sw.EndOfStream)//читаем построчно в цикле, пока не достигнем конца файла
                    {
                        str = sw.ReadLine();
                        delim = str.IndexOf(':');//находим позицию двоеточния (разделитель)
                        words_keys = str.Substring(0, delim);//тут получаем слово до двоеточия
                        delim++;
                        words_values = str.Substring(delim, str.Length - delim);//тут получаем слово после двоеточия
                        if (!EnRu.ContainsKey(words_keys))
                        {
                            EnRu.Add(words_keys, words_values);//добавляем пару "ключ-значение в словарь"
                        }
                        
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Словарь загружен");
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
}
}
