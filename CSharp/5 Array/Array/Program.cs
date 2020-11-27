using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] Array = new double[5];
            Console.WriteLine("Введите 5 элементов массива: ");
            for (int n = 0; n < Array.Length; n++)
            {
                Array[n] = double.Parse(Console.ReadLine());
            }

            double Sum = Operations.ArrSum(Array);
            Console.WriteLine("Сумма всех элементов массива = {0}", Sum);

            double Average = Operations.AverageNum(Array);
            Console.WriteLine("Среднее значение массива = {0}", Average);

            double Plus = Operations.SumOfPlus(Array);
            Console.WriteLine("Сумма положительных элементов = {0}", Plus);

            double Minus = Operations.SumOfMinus(Array);
            Console.WriteLine("Сумма отрицательных элементов = {0}", Minus);

        }
    }
}
