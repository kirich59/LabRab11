using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab11
{
    class Program
    {
        private static void InputNumber(int left, int right, out int number)
        {
            bool ok;
            do

            {
                ok = int.TryParse(Console.ReadLine(), out number);
                if (!ok) Console.WriteLine("Неверный ввод, попробуйте снова");
                else
                {
                    if (number < left) { Console.WriteLine("Слишком маленькое число"); ok = false; };
                    if (number > right) { Console.WriteLine("Слишком большое число"); ok = false; };
                }
            }
            while (!ok);
        }
        private static void Demo() //ЗАДАНИЕ 1
        {
            Student s1 = new Student(); //без параметров
            Student s2 = new Student("Кирилл", "Баженов", 1, 7.5);
            Teacher t1 = new Teacher("Иванов", "Иван", "Математика");
            Worker w1 = new Worker("Петров", "Петр", 15);
            Person[] arr = new Person[4];
            arr[0] = s1;
            arr[1] = s2;
            arr[2] = t1;
            arr[3] = w1;
            foreach (Person p in arr)
                p.Show();
        }
        private static void StudentsByDegree()  //имена студентов указанного курса
        {
            Random rnd = new Random();
            Student[] arr = new Student[4];
            arr[0] = new Student("Иван", "Иванов", (Byte)rnd.Next(1, 5), rnd.Next(0, 11));
            arr[1] = new Student("Петр", "Петров", (Byte)rnd.Next(1, 5), rnd.Next(0, 11));
            arr[2] = new Student("Олег", "Синицын", (Byte)rnd.Next(1, 5), rnd.Next(0, 11));
            arr[3] = new Student("Фёдор", "Конюхов", (Byte)rnd.Next(1, 5), rnd.Next(0, 11));
            int degree;
            Console.WriteLine("Введите курс :");
            InputNumber(1, 4, out degree);
            Console.WriteLine("Студенты {0} курса: ", degree);
            foreach (Student s in arr)
                if (s.Degree == (byte)degree)
                    Console.WriteLine(s.Name + " " + s.SecondName);
            Console.WriteLine("Все студенты :");
            foreach (Student s in arr)
                s.Show();
        }
        private static void WorkersByExperience()  //Количество рабочих со стажем не менее заданного
        {
            Random rnd = new Random();
            Worker[] arr = new Worker[4];
            arr[0] = new Worker("Иван", "Иванов", rnd.Next(0, 81));
            arr[1] = new Worker("Петр", "Петров", rnd.Next(0, 81));
            arr[2] = new Worker("Олег", "Синицын", rnd.Next(0, 81));
            arr[3] = new Worker("Фёдор", "Конюхов", rnd.Next(0, 81));
            int experience;
            Console.WriteLine("Введите стаж :");
            InputNumber(0, 80, out experience);
            byte kol = 0;
            foreach (Worker s in arr)
                if (s.Experience >= experience)
                    kol++;
            Console.WriteLine("Число работников со стажем не менее {0} лет = {1} ", experience, kol);
            Console.WriteLine("Все работники :");
            foreach (Worker s in arr)
                s.Show();
        }
        private static void AverageMark()  //Средний балл за сессию заданного студента
        {
            Random rnd = new Random();
            Student[] arr = new Student[4];
            arr[0] = new Student("Иван", "Иванов", (Byte)rnd.Next(1, 5), rnd.Next(0, 11));
            arr[1] = new Student("Петр", "Петров", (Byte)rnd.Next(1, 5), rnd.Next(0, 11));
            arr[2] = new Student("Олег", "Синицын", (Byte)rnd.Next(1, 5), rnd.Next(0, 11));
            arr[3] = new Student("Фёдор", "Конюхов", (Byte)rnd.Next(1, 5), rnd.Next(0, 11));
            Console.WriteLine("Введите имя :");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию : ");
            string FName = Console.ReadLine();
            bool id = false;
            int num = -1;
            foreach (Student s in arr)
            {
                num++;
                if (s.Name == name && s.SecondName == FName)
                {
                    id = true;
                    break;
                }
            }
            if (!id) Console.WriteLine("Студент с таким именем не найден");
            else
            {
                Console.WriteLine("Средний балл за сессию студента {0} : {1}", name + " " + FName, arr[num].Average);
                Console.WriteLine("Все студенты :");
                foreach (Student s in arr)
                    s.Show();
            }
        }
        private static void TeachersByDepartment()  //Имена преподавателей указанной кафедры
        {
            Random rnd = new Random();
            Teacher[] arr = new Teacher[4];
            arr[0] = new Teacher("Иван", "Иванов", "Программирование");
            arr[1] = new Teacher("Петр", "Петров", "Философия");
            arr[2] = new Teacher("Олег", "Синицын", "Математика");
            arr[3] = new Teacher("Фёдор", "Конюхов", "Физика");
            Console.WriteLine("Введите кафедру :");
            string dep = Console.ReadLine();
            bool id = false;
            foreach (Teacher s in arr)
            {
                if (s.Department == dep)
                {
                    id = true;
                    break;
                }
            }
            if (!id) Console.WriteLine("Такой кафедры не найдено");
            else
            {
                Console.WriteLine("Имена преподавателей кафедры {0} :",dep);
                foreach (Teacher s in arr)
                    if (s.Department==dep)
                        Console.WriteLine(s.Name + " " + s.SecondName);
                Console.WriteLine("Все преподаватели :");
                foreach (Teacher s in arr)
                    s.Show();
            }
        }
        private static void Menu2()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1. Имена студентов указанного курса.\n"
                    + "2. Количество рабочих со стажем не менее заданного.\n"
                    + "3. Средний балл за сессию заданного студента.\n"
                    + "4. Имена преподавателей указанной кафедры.\n"
                    + "5. Выход.");
                int sw;
                InputNumber(1, 5, out sw);
                switch (sw)
                {
                    case 1:
                        StudentsByDegree();
                        break;
                    case 2:
                        WorkersByExperience();
                        break;
                    case 3:
                        AverageMark();
                        break;
                    case 4:
                        TeachersByDepartment();
                        break;
                    case 5:
                        exit = true;
                        break;
                }
            }
        }
        private static void ShowMenu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1. Задание 1 (демонстрационная программа).\n"
                    + "2. Задание 2.\n"
                    + "3. Задание 3.\n"
                    + "4. Выход.");
                int sw;
                InputNumber(1, 4, out sw);
                switch (sw)
                {
                    case 1:
                        Demo();
                        break;
                    case 2:
                        Menu2();
                        break;
                    case 3:
                        break;
                    case 4:
                        exit = true;
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            ShowMenu();
        }
    }
}
