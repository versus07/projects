using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13_8
{
    class Student
    {
        private int StudentID;
        private string StudentName;
        private string StudentGroupe;
        private int StudentAge;
        private int [][] StudentMarks=new int[3][];



        public void StudentInit(int _studentid, string _studentname, string _studentgroupe, int _studentage)
        {
            StudentID = _studentid;
            StudentName = _studentname;
            StudentGroupe = _studentgroupe;
            StudentAge = _studentage;

            
        }

        public void StudentMarksInit()
        {
            StudentMarks[0] = new int[15]; //Оценки по программированию
            StudentMarks[1] = new int[10]; //Оценки по администрированию
            StudentMarks[2] = new int[8]; //Оценки по дизайну

            Random rnd = new Random();

            Console.Write("Оценки студента по программированию:\t");
            for (int i = 0; i < 15; i++)
            {
                StudentMarks[0][i] = rnd.Next(8)+2;
                Console.Write(StudentMarks[0][i] + " ");
            }
            Console.WriteLine();

            Console.Write("Оценки студента по администрированию:\t");
            for (int i = 0; i < 10; i++)
            {
                StudentMarks[1][i] = rnd.Next(8) + 2;
                Console.Write(StudentMarks[1][i] + " ");
            }
            Console.WriteLine();

            Console.Write("Оценки студента по дизайну:\t\t");
            for (int i = 0; i < 8; i++)
            {
                StudentMarks[2][i] = rnd.Next(8) + 2;
                Console.Write(StudentMarks[2][i] + " ");
            }
            Console.WriteLine();
        }

        public double AverageMark1()//средний балл по программированию
        {
            
            double am;
            am = StudentMarks[0].Average();
            return am;
        }

        public double AverageMark2()//средний балл по программированию
        {

            double am;
            am = StudentMarks[1].Average();
            return am;
        }

        public double AverageMark3()//средний балл по программированию
        {

            double am;
            am = StudentMarks[2].Average();
            return am;
        }


        public void StudentPrint()
        {
            Console.WriteLine($"ID студента - {StudentID}\nФИО студента - {StudentName}");
            Console.WriteLine($"Группа - {StudentGroupe}\nВозраст студента - {StudentAge}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.StudentInit(1, "Иванов Иван Иванович", "A-3452", 21);

            st.StudentPrint();
            st.StudentMarksInit();
            double sb;
            sb = st.AverageMark1();
            Console.WriteLine($"Средний балл по программированию - {String.Format("{0:0.#}",sb)}");
            sb = st.AverageMark2();
            Console.WriteLine($"Средний балл по администрированию - {String.Format("{0:0.#}", sb)}");
            sb = st.AverageMark3();
            Console.WriteLine($"Средний балл по дизайну - {String.Format("{0:0.#}", sb)}");

        }
    }
}
