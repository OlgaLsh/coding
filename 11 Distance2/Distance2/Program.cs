using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Distance A = new Distance(15, 8);
            Distance B = new Distance(12, 7);
            Distance d1;
            Distance d2;
            d1 = A + B;
            d2 = A - B;
            Console.WriteLine("Расстояние A = " + A.ToString());
            Console.WriteLine("Расстояние B = " + B.ToString());
            Console.WriteLine("A + B = " + d1.ToString());
            Console.WriteLine("A - B = " + d2.ToString());
            if (A == B)
                Console.WriteLine("A = B");
            else
            if (A > B)
                Console.WriteLine("A больше B");
            else
                Console.WriteLine("B больше A");

        }
    }
}
