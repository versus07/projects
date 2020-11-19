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
            
            MainMenu();
            
                        
        }

        //Главное меню
        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("\tПРОГРАММА  С Л О В А Р Ь");
            Console.WriteLine("====================================");
            Console.WriteLine("Нажмите 1 для работы с Англо-Русским словарем");
            Console.WriteLine("Нажмите 2 для работы с Русско-Английским словарем");
            Console.WriteLine("Нажмите 3 для выхода из программы");

            int choise; //Переменная для выбора, с каким словарем будем работать

            choise = Convert.ToInt32(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    WorkWithEnRuDict();
                    break;
                case 2:
                    WorkWithRuEnDict();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Выберите вариант работы");
                    System.Threading.Thread.Sleep(3000);
                    MainMenu();
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
            Console.WriteLine("<0>\t Вернуться в предыдущее меню");

            int v; //Переменная выбора режима работы со словарем
            v = Convert.ToInt32(Console.ReadLine());
            switch (v)
            {
                case 1:
                    {
                        //Загрузка словаря
                        EnglishDict.OpenEnRuDict();
                        System.Threading.Thread.Sleep(3000);
                        WorkWithEnRuDict();
                        break;
                    }
                case 2:
                    {
                        //Сохранение словаря
                        EnglishDict.SaveEnRuDict();
                        System.Threading.Thread.Sleep(3000);
                        WorkWithEnRuDict();
                        break;
                    }
                case 3:
                    {
                        //Печать словаря
                        EnglishDict.PrintEnRuDict();
                        Console.WriteLine("Нажмите любую клавишу...");
                        Console.ReadKey();
                        //System.Threading.Thread.Sleep(3000);
                        WorkWithEnRuDict();
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
                case 0:
                    {
                        //Возврат в главное меню
                        MainMenu();
                        break;
                    }
                default:
                    Console.WriteLine("Выберите корректный режим");
                    System.Threading.Thread.Sleep(3000);
                    WorkWithEnRuDict();
                    break;
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
