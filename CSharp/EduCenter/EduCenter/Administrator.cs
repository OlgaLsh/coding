using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCenter
{
    class Administrator:Employee
    {
        private int lab;
        private static string position = "Администратор";


        public Administrator()
        { }
        public Administrator(long IDnumber, string name, string surname, int laboratory) : base(IDnumber, name, surname)
        {
            this.lab = laboratory;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Лаборатория: {0} \nДолжность: {1}\nСтаж работы (полных лет): {2}", lab, position, GetExperience());
        }

    }
}
