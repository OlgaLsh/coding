using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_formula
{
    public class Solution
    {
        public static double Formula(double a, double b, double c, ref double x1, ref double x2)
        {
            double D = Math.Pow(b,2) - 4 * a * c;
            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / 2 * a;
                x2 = (-b - Math.Sqrt(D)) / 2 * a;
                return 1;
            }
            else if (D == 0)
            {
                x1 = -b / (2 * a);
                return 0;
            }
            else
            {
                return -1;
            }
        }

    }
}
