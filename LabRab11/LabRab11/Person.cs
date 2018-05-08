using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab11
{
    public interface IPeople
    {
        string Description();
    }
    abstract public class Person : IPeople, IComparable
    {
        protected string name;
        protected string secondName;
        protected string[] names = ("Август, Августин, Аврор, Агап, Адам, Аксён, Алевтин, Александр, Алексей, Алексий, Альберт, Анастасий, Анатолий, Анвар, Андрей, Андрон, " +
    "Гавриил, Гаврила, Гайдар, Гаспар, Гений, Геннадий, Георгий, Герман, Гермоген, Глеб, Григорий, Дан, Даниил, Данила, Дар, Дементий, Демид, Демократ, Демьян, Денис, Дидим, " +
    "Казимир, Капитон, Каспар, Ким, Кир, Кирилл, Клавдий, Клементий, Кондратий, Кондрат, Константин, Краснослав, Кузьма, Лавр, Лаврентий, Лазарь, Ларион, Лев, Леонид, Леонтий, " +
    "Октябрь, Олег, Ольгерд, Онисим, Осип, Оскар, Остап, Остромир, Павел, Пантелеймон, Панфил, Парамон, Пахом, Пересвет, Пётр, Платон, Потап,").Replace(",", "").Replace("ё", "е").Split(' ');
        protected string[] surnames = ("Иванов Смирнов Кузнецов Попов Васильев Петров Соколов Михайлов Новиков Федоров Морозов Волков Алексеев Лебедев Семенов Егоров " +
            "Павлов Козлов Степанов Николаев").Split(' ');
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }
        public Person()
        {
            System.Threading.Thread.Sleep(50);
            Random rnd = new Random();
            name = names[rnd.Next(0, names.Length)];
            secondName = surnames[rnd.Next(0, surnames.Length)];
        }
        public Person(string Name, string SecondName)
        {
            name = Name;
            secondName = SecondName;
        }
        public abstract void Show();
        public int CompareTo(object obj)
        {
            Person p = (Person)obj;
            if (this.Name.CompareTo(p.Name) == 0) return this.SecondName.CompareTo(p.SecondName);
            return this.Name.CompareTo(p.Name);
        }
        public abstract string Description();
    }

}
