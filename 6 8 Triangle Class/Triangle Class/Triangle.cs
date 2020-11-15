using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Class
{
    class Triangle
    {
        private double Aside;
        private double Bside;
        private double Cside;

        public double SideA()
        {
            return Aside;
        }

        public double SideB()
        {
            return Bside;
        }

        public double SideC()
        {
            return Cside;
        }

        public Triangle(double a, double b, double c)
        {
            Aside = a;
            Bside = b;
            Cside = c;
        }

        public void TriangleSides(double a, double b, double c) // разносторонний треугольник с заданными длинами сторон
        {
            Aside = a;
            Bside = b;
            Cside = c;
        }
        public void TriangleSameSides(double a, double b, double c) // равносторонний треугольник
        {
            Aside = a;
            Bside = a;
            Cside = a;
        }

        public double Perimetr()
        {
            double Perimetr = Aside + Bside + Cside;
            return Perimetr;
        }

        public double Square() // по формуле Герона
        {
            double PP = Perimetr() / 2;
            double Square = Math.Sqrt(PP * (PP - Aside) * (PP - Bside) * (PP - Cside));
            return Square;
        }

    }
}
