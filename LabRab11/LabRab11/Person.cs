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
            name = "";
            secondName = "";
        }
        public Person(string Name, string SecondName)
        {
            name = Name;
            secondName = SecondName;
        }
        virtual public void Show()
        {
            Console.WriteLine("PERSON Имя: " + name + "\nФамилия: " + secondName);
        }
        public int CompareTo(object obj)
        {
            Person p = (Person)obj;
            if (this.Name.CompareTo(p.Name) == 0) return this.SecondName.CompareTo(p.SecondName);
            return this.Name.CompareTo(p.Name);
        }
        public string Description()
        {
            return null;
        }
    }

}
