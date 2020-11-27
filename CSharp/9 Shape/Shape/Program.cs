using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Program
    {
        static void Main()
        {
            {

                Triangle t1 = new Triangle(8);
                Triangle t2 = new Triangle(5, 4, 3);
                Circle c1 = new Circle(10);
                Square s1 = new Square(6);

                t1.Print();
                t2.Print();
                c1.Print();
                s1.Print();

                t1.Degree = 90;
                t2.Degree = 180;
                s1.Degree = 30;

                t1.Rotation();
                t2.Rotation();
                s1.Rotation();

            }

        }
    }
}
