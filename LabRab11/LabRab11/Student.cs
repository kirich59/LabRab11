using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab11
{
    class Student : Person
    {
        protected byte degree;    //курс
        protected double average; //средний балл за сессию
        public byte Degree
        {
            get { return degree; }
            set { degree = value; }
        }
        public double Average
        {
            get { return average; }
            set { average = value; }
        }
        public Student() : base()
        {
            degree = 0;
            average = 0;
        }
        public Student(string Name, string SecondName, byte Degree, double Average) : base(Name, SecondName)
        {
            degree = Degree;
            average = Average;
        }
        public override void Show()
        {
            Console.WriteLine("\nSTUDENT Имя: " + name + " Фамилия: " + secondName + " Курс: " + degree + " Средний балл за сессию: " + average);
        }
    }
}
