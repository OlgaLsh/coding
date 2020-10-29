using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_2
{
    class Program
    {
        static void Main(string[] args)
        {
                string answer;
                Console.WriteLine("Ваш треугольник равносторонний? да или нет:");
                answer = Console.ReadLine();
                if (answer == "да")
                {
                    
                        Console.WriteLine("Введите значение стороны треугольника:");
                        double n = double.Parse(Console.ReadLine());
                        double S = Operation.Square(n);
                        Console.WriteLine("Площадь ={0}",S);
                   
                }
                else
                {
                        Console.WriteLine("Введите значения трех сторон треугольника:");
                        double a = double.Parse(Console.ReadLine());
                        double b = double.Parse(Console.ReadLine());
                        double c = double.Parse(Console.ReadLine());
                        double S = Operation.Geron(a,b,c);
                        Console.WriteLine("Площадь = {0}", S);
                }

        }
    }
}
