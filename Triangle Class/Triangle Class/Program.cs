using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Class
{
    class Program
    {
        static void Main(string[] args)
        {
                Triangle ABC, KMN;
                ABC = new Triangle(5, 8, 7);
                KMN = new Triangle(5, 5, 5);
                CheckTriangle(ABC);
                Print(ABC);
                CheckTriangle(KMN);
                Print(KMN);
        }
        static void Print(Triangle abc)
        {
            if (abc.SideA() == abc.SideB() && abc.SideB() == abc.SideC())
            {
                Console.WriteLine("Это равносторонний треугольник");
                Console.WriteLine("Стороны треугольника равны и их значение = {0} ", abc.SideA());
                Console.WriteLine("Периметр треугольника = {0}", abc.Perimetr());
                Console.WriteLine("Площадь треугольника = {0}", abc.Square());
            }
            else
            {
                Console.WriteLine("Стороны треугольника {0}, {1}, {2} ", abc.SideA(), abc.SideB(), abc.SideC());
                Console.WriteLine("Периметр треугольника = {0}", abc.Perimetr());
                Console.WriteLine("Площадь треугольника = {0}", abc.Square());
            }
        }

        public static void CheckTriangle(Triangle abc)
        {
                if (!((abc.SideA() + abc.SideB()) > abc.SideC() && (abc.SideA() + abc.SideB()) > abc.SideC() && (abc.SideB() + abc.SideC()) > abc.SideA()))
                    throw new Exception("Треугольник не существует");
                else { Console.WriteLine("Треугольник существует"); }
        }
    }
}
