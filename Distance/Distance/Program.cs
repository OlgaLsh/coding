using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    struct Distance
    {
        public int feet;
        public int inch;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Distance A;
            Distance B;
            Distance C;

            Console.WriteLine("Введите значение A сначала в футах, затем в дюймах:");
            A.feet = Convert.ToInt32(Console.ReadLine());
            A.inch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение B сначала в футах, затем в дюймах:");
            B.feet = Convert.ToInt32(Console.ReadLine());
            B.inch = Convert.ToInt32(Console.ReadLine());
            C.feet = A.feet + B.feet;
            C.inch = A.inch + B.inch;
            C.feet = C.feet + (C.inch / 12);
            C.inch = C.inch % 12;
            Console.WriteLine("C = {0}\'-{1}\"", C.feet, C.inch);
        }
    }
}
