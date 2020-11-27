using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCenter
{
    class Manager:Employee
    {
        private string faculty;
        private static string position = "Менеджер";


        public Manager()
        { }
        public Manager(long IDnumber, string name, string surname, string faculty) : base(IDnumber, name, surname)
        {
            this.faculty = faculty;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Факультет: {0} \nДолжность: {1}\nСтаж работы: {2}", faculty, position, GetExperience());
        }

    }
}
