/*
 * Создать приложение «Словари».
Основная задача проекта: хранить словари на разных языках и разрешать поль-
зователю находить перевод нужного слова или фразы.
Интерфейс приложения должен предоставлять такие возможности:
■ ■ Создавать словарь. При создании нужно указать тип словаря. Например,
англо-русский или русско-английский.
■ ■ Добавлять слово и его перевод в уже существующий словарь. Так как у
слова может быть несколько переводов, необходимо поддерживать воз-
можность создания нескольких вариантов перевода.
■ ■ Заменять слово или его перевод в словаре.
■ ■ Удалять слово или перевод. Если удаляется слово, все его переводы уда-
ляются вместе с ним. Нельзя удалить перевод слова, если это последний
вариант перевода.
■ ■ Искать перевод слова.
■ ■ Словари должны храниться в файлах.
■ ■ Слово и варианты его переводов можно экспортировать в отдельный файл
результата.
■ ■ При старте программы необходимо показывать меню для работы с про-
граммой. Если выбор пункта меню открывает подменю, то тогда в нем
требуется предусмотреть возможность возврата в предыдущее меню.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;




namespace DictApp
{
    class Program
    {
        static EnRuDict EnglishDict = new EnRuDict();//Глобальный объект для англо-русского словаря
        static void Main(string[] args)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("\tПРОГРАММА  С Л О В А Р Ь");
            Console.WriteLine("====================================");
            Console.WriteLine("Нажмите 1 для работы с Англо-Русским словарем");
            Console.WriteLine("Нажмите 2 для работы с Русско-Английским словарем");

           

            int MainMenu; //Переменная для выбора, с каким словарем будем работать

            MainMenu = Convert.ToInt32(Console.ReadLine());

            switch (MainMenu)
            {
                case 1:
                    WorkWithEnRuDict();
                    break;
                case 2:
                    WorkWithRuEnDict();
                    break;
                default:
                    Console.WriteLine("Выберите вариант работы");
                    break;
            }
            
                        
        }
        //Работа с Англо-русским словарем
        static void WorkWithEnRuDict()
        {
            Console.Clear();
            Console.WriteLine("АНГЛО-РУССКИЙ СЛОВАРЬ\n");
            Console.WriteLine("<1>\t Загрузить словарь");
            Console.WriteLine("<2>\t Сохранить словарь");
            Console.WriteLine("<3>\t Печать словаря");
            Console.WriteLine("<4>\t Добавить слово");
            Console.WriteLine("<5>\t Найти слово");
            Console.WriteLine("<6>\t Удалить слово");

            int v; //Переменная выбора режима работы со словарем
            v = Convert.ToInt32(Console.ReadLine());
            switch (v)
            {
                case 1:
                    {
                       //Загрузка словаря
                        break;
                    }
                case 2:
                    {
                        //Сохранение словаря
                        try
                        {
                            using (StreamWriter sw = new StreamWriter("@c:\\ENRU.dic", true, System.Text.Encoding.Default))
                            {
                                sw.WriteLine("TEST");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        Console.WriteLine("Запись словаря в файл...");
                        WorkWithEnRuDict();
                        break;
                    }
                case 3:
                    {
                        //Печать словаря
                        EnglishDict.PrintEnRuDict();
                        break;
                    }
                case 4:
                    {
                        //Добавление слов
                        EnglishDict.WordEnRuAdd();
                        WorkWithEnRuDict();
                    
                        break;
                    }
                case 5:
                    {
                        //Поиск слова
                        break;
                    }
                case 6:
                    {
                        //Удаление слова
                        break;
                    }
            }

            



            

            
        }

       
        /// /////////////////////////////////
       
        //Работа с Русско-английским словарем
        static void WorkWithRuEnDict()
        {
            Console.Clear();
            Console.WriteLine("РУССКО-АНГЛИЙСКИЙ СЛОВАРЬ");
        }
    }

}
