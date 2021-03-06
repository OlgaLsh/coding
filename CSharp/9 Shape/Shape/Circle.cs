﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Circle:Shape
    {
        private double r;

        public Circle(double r) : base(shapeName: "Круг")
        {
            this.r = r;
        }
        public Circle() { }
        public double R()
        {
            return r;
        }
        public override double P()
        {
            return 2 * Math.PI * r;
        }
        public override double S()
        {
            return Math.PI * Math.Pow(r, 2);
        }
        new public void Print()
        {
            base.Print();
            Console.WriteLine("Радиус круга: {0}", R());
            Console.WriteLine("Площадь круга: {0}\n", P());
        }

    }
}
