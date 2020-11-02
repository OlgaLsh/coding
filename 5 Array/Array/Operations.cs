using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Operations
    {
        public static double ArrSum(double[] a)
        {
            double Sum = 0;
            for (int n = 0; n < a.Length; n++)
            {
                Sum += a[n];
            }
            return Sum;
        }

        public static double AverageNum(double[] a)
        {
            double AN = ArrSum(a) / a.Length;
            return AN;
        }


        public static double SumOfPlus(double[] a)
        {
            double Sum = 0;
            for (int n = 0; n < a.Length; n++)
            {
                if (a[n] > 0)
                {
                    Sum += a[n];
                }
            }
            return Sum;
        }

        public static double SumOfMinus(double[] a)
        {
            double Sum = 0;
            for (int n = 0; n < a.Length; n++)
            {
                if (a[n] < 0)
                {
                    Sum += a[n];
                }
            }
            return Sum;
        }
    }
}
