using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab11
{
    class Teacher : Person
    {
        protected string department; //кафедра
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public Teacher() : base()
        {
            department = "";
        }
        public Teacher(string Name, string SecondName, string Department) : base(Name, SecondName)
        {
            department = Department;
        }
        public override void Show()
        {
            Console.WriteLine("\nTEACHER Имя: " + name + " Фамилия: " + secondName + " Кафедра: " + department);
        }
    }
}
