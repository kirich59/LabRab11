using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab11
{
    class Person
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
        public void Show()
        {
            Console.WriteLine("Имя: " + name + "\nФамилия: " + secondName);
        }
    }

}
