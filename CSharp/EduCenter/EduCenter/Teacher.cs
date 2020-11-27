using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCenter
{
    class Teacher:Employee
    {
        public string Faculty { get; set; }
        public string Position { get; set; }


        public Teacher()
        {
        }

        public Teacher(long IDnumber, string name, string surname) : base(IDnumber, name, surname)
        {
        }
        public Teacher(long IDnumber, string name, string surname, string faculty, string position) : base(IDnumber, name, surname)
        {
            Faculty = faculty;
            Position = position;
        }


        public override void Show()
        {
            base.Show();
            Console.WriteLine("Факультет: {0} \nДолжность: {1} \nСтаж работы: {2}", Faculty, Position, GetExperience());
        }

    }
}
