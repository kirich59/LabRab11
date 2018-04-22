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
        private static void Menu2()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1. Имена студентов указанного курса.\n"
                    + "2. Количество рабочих со стажем не менее заданного.\n"
                    + "3. Средний балл за сессию заданного студента.\n"
                    + "4. Имена преподавателей указанной кафедры.\n"
                    + "5. Выход.\n");
                int sw;
                InputNumber(1, 5, out sw);
                Random rnd = new Random();
                switch (sw)
                {
                    case 1:
                        Student s1 = new Student("Иван", "Иванов",(Byte)rnd.Next(1, 5), rnd.Next(0, 11));
                        Student s2 = new Student( "Петр", "Петров", (Byte)rnd.Next(1, 5), rnd.Next(0, 11));
                        Student s3 = new Student("Олег", "Синицын", (Byte)rnd.Next(1, 5), rnd.Next(0, 11));
                        Student s4 = new Student("Фёдор", "Конюхов", (Byte)rnd.Next(1, 5), rnd.Next(0, 11));
                        
                        break;
                    case 2:
                        
                        break;
                    case 3:
                        break;
                    case 4:
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
                    + "4. Выход.\n");
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
