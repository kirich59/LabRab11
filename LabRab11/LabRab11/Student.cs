using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab11
{
    class Student : Person, ICloneable
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
            Random rnd = new Random();
            degree = (byte)rnd.Next(0, 6);
            average = Math.Round(rnd.Next(0, 10) + rnd.NextDouble(), 2);
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
        public Student ShallowCopy()  //поверхностное копирование
        {
            return (Student)this.MemberwiseClone();
        }
        public object Clone()        //глубокое клонирование
        {
            return new Student("Клон " + name, secondName, degree, average);
        }
        public override string Description()
        {
            return "Имя: " + name + " Фамилия: " + secondName + " Курс: " + degree + " Средний балл за сессию: " + average;
        }
    }
}
