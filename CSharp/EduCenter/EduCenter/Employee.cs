using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCenter
{
    class Employee:Person, IEmployee
    {
        private int Experience; //стаж
        private DateTime job; //дата начала работы
        public decimal Rate { get; set; } // ставка
        public double Bonus { get; set; } // коэффициент
        private decimal salary; // зарплата

        public Employee()
        { }
        public Employee(long IDnumber, string name, string surname) : base(IDnumber, name, surname)
        {
        }

        public void SetJob(int day, int month, int year) // расчёт начала работы
        {
            job = new DateTime(year, month, day);
        }
        public DateTime GetJob()
        {
            return job;
        }

        public int GetExperience()
        {
            Experience = DateTime.Now.Year - job.Year;
            if (DateTime.Now.Month < job.Month || (DateTime.Now.Month == job.Month && DateTime.Now.Day < job.Day))
            {
                Experience--;
            }
            return Experience;
        }

        public decimal CalculateSalary(int hours)
        {

            return salary = Rate * (decimal)(hours * (GetExperience() * Bonus));
        }


        public bool IfVacation
        {
            get;
            set;
        }
        public void Vacation()
        {
            Console.WriteLine("{1} {2} в отпуске: {0}", IfVacation, name, surname);
        }

        //public bool IfSick
        //{
        //    get;
        //    set;
        //}
        //public void SickLeave()
        //{
        //    Console.WriteLine("{1} {2} на больничном: {0}", IfSick, name, surname);
        //}

    }
}
