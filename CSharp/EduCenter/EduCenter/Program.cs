using System;
using System.Collections;


namespace EduCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(2020101, "Анна", "Сидорова");
            student.SetBirthday(12, 10, 1998);
            student.Faculty = "Экономики и управления";
            student.Group = 105;
            student.Show();
            Console.WriteLine("Возраст:{0}", student.GetAge());

            Student student2 = new Student(2020115, "Пётр", "Иванов");
            student2.SetBirthday(24, 05, 1999);
            student2.Faculty = "Филологии";
            student2.Group = 106;
            student2.Show();
            Console.WriteLine("Возраст:{0}", student.GetAge());

            Teacher teacher = new Teacher(2020145, "Глеб", "Павлов");
            teacher.SetBirthday(17, 07, 1980);
            teacher.SetJob(01, 03, 2005);
            teacher.Faculty = "Экономики и управления";
            teacher.Position = "Доцент";
            teacher.Show();
            teacher.Bonus = 0.15;
            teacher.Rate = 100;
            Console.WriteLine("Зарплата:{0} руб.", teacher.CalculateSalary(250));
            teacher.IfVacation = true;
            teacher.Vacation();

            Manager manager = new Manager(2020134, "Людмила", "Васильева", "Филологии");
            manager.SetBirthday(12, 12, 1976);
            manager.SetJob(05, 08, 2010);
            manager.Bonus = 0.1;
            manager.Rate = 100;
            manager.Show();
            Console.WriteLine("Зарплата:{0} руб.", manager.CalculateSalary(200));

            Teacher teacher2 = new Teacher(2020058, "Александр", "Боярский");
            teacher2.SetBirthday(12, 01, 1985);
            teacher2.SetJob(15, 04, 2015);
            teacher2.Faculty = "Менеджмента";
            teacher2.Position = "Профессор";
            teacher2.Show();
            teacher2.Bonus = 0.16;
            teacher2.Rate = 100;
            Console.WriteLine("Зарплата:{0} руб.", teacher2.CalculateSalary(300));

            ArrayList Employees = new ArrayList(); // создание коллекции с объектами
            Employees.Add(manager);
            Employees.Add(teacher);
            Employees.Add(teacher2);
            ShowArray(Employees);
        }

        public static void ShowArray(ArrayList a)
        {
            foreach (Person o in a)
                o.Show();

        }
    }
}
