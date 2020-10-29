using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_formula
{
    class Program
    {
        static void Main(string[] args)
        {       // ax2+bx+c=0 - квадратное уравнение
                Console.WriteLine("Введите значения коэффициентов квадратного уравнения A, B и C:");
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                double x1 = 0;
                double x2 = 0;
                double res = Solution.Formula(a, b, c, ref x1, ref x2);
                if (res == 1)
                {
                    Console.WriteLine("Корни уравнения с коэффициентами a = {0}, b = {1}, c = {2} равны: x1 = {3}, x2 = {4}", a, b, c, x1, x2);
                }
                else if (res == 0)
                {
                    Console.WriteLine("Корень уравнения с коэффициентами a = {0}, b = {1}, c = {2} один: x1 = x2 = {3}", a, b, c, x1);
                }
                else
                {
                    Console.WriteLine("Корней уравнения с коэффициентами a = {0}, b = {1}, c = {2} нет.", a, b, c);
                }

        }
    }
}
