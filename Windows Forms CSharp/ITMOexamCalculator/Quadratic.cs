using System;

namespace SimpleCalculator
{
    class Quadratic
    {
        public static string Gg(double a, double b, double c)
        {
            double d = Deskr(a, b, c);
            double x1;
            double x2;

            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return $"x1 = {x1:f2}; x2 = {x2:f2}";
            }

            else if (d == 0)
            {
                x1 = x2 = (-b + Math.Abs(d)) / (2 * a);
                return $"x1 = x2 = {x1:f2}";
            }
            else
            {
                return $"Нет корней";
            }
        }

        public static double Deskr(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }
    }
}
