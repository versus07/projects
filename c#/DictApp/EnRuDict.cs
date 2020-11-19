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
                        
        }

    //загрузка словаря из файла
    public void OpenEnRuDict()
        {
            string str;
            string[] words;
            
            try
            {
                using (StreamReader sw = new StreamReader(@"d:\enru.dic"))
                {
                    str = sw.ReadToEnd();
                    words = str.Split(new char[] { ':' });
                    foreach (string s in words)
                    {
                        Console.WriteLine(s);
                        //EnRu.Add(s)
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
}
}
