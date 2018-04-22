using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab11
{
    class Worker : Person
    {
        protected int experience; //стаж
        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }
        public Worker() : base()
        {
            experience = 0;
        }
        public Worker(string Name, string SecondName,int Experience) : base(Name, SecondName)
        {
            experience = Experience;
        }
        public override void Show()
        {
            Console.WriteLine("\nWORKER Имя: " + name + " Фамилия: " + secondName + " Стаж: " + experience);
        }
    }
}
