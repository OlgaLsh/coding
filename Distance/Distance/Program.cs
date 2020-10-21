using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    struct Distance
    {
        public int A;
        public int B;
        public int C;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение A сначала в футах, затем в дюймах:");
            int f = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int A = f * 12 + d;
            Console.WriteLine("Введите значение B сначала в футах, затем в дюймах:");
            int f1 = Convert.ToInt32(Console.ReadLine());
            int d1 = Convert.ToInt32(Console.ReadLine());
            int B = f1 * 12 + d1;
            int C = A + B;
            int C1 = C / 12;
            int C2 = C % 12;
            Console.WriteLine(C1 + "'" +"-" + C2 + " '' " );
        }
    }
}
