using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_2
{
    public class Operation
    {
        static bool Existance(double a, double b, double c)
        {
            bool exist;
            if ((a + b) > c && (a + c) > b && (c + b) > a)
            {
                exist = true;
                Console.WriteLine("Треугольник существует");
            }
            else
            {
                exist = false;
                Console.WriteLine("Треугольник не существует");
            }
            return exist;
        }
        public static double Geron(double a, double b, double c)
        {
            bool exist;
            exist = Operation.Existance(a, b, c);
            if (exist)
            {
                double P = a + b + c;
                double pp = P / 2;
                double S = Math.Sqrt(pp * (pp - a) * (pp - b) * (pp - c));
                return S;
            }
            else
            {
                return 0;
            }
        }
        public static double Square(double a)
        {
            double P = a * 3;
            double pp = P / 2;
            double S = Math.Sqrt(pp * Math.Pow((pp - a), 3));
            return S;
        }
    }

}
