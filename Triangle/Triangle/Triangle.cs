using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение периметра равностороннего треугольника:");
            double P = Convert.ToDouble(Console.ReadLine());
            double k = P / 3; // сторона треугольника
            double pp = P / 2; // полупериметр
            double S = Math.Sqrt(pp * Math.Pow((pp - k), 3)); // площадь треугольника
            Console.WriteLine("Сторона\t\tПлощадь");
            Console.WriteLine($"{k:.##}" + "\t\t" + $"{S:.##}");

        }
    }
}
