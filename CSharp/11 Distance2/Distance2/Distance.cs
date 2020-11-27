using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceNew
{
    class Distance
    {
        private int feet;
        private double inches;

        public Distance()
        { }

        public Distance(int feet, double inches)
        {
            this.feet = feet;
            this.inches = inches;
        }

        public static Distance operator +(Distance D1, Distance D2)
        {
            int newFeet = D1.feet + D2.feet;
            double newInches = D1.inches + D2.inches;
            newFeet += (int)(newInches / 12);
            newInches %= 12;
            return new Distance(newFeet, newInches);
        }

        public static Distance operator -(Distance D1, Distance D2)
        {
            int newFeet = D1.feet - D2.feet;
            double newInches = D1.inches - D2.inches;
            return new Distance(newFeet, newInches);
        }

        public override string ToString()
        {
            return string.Format("{0}\'-{1}\"", feet, inches);
        }

        private double TotalInches()
        {
            return feet * 12 + inches;
        }

        private double Compare(Distance other)
        {
            double A = TotalInches();
            double B = other.TotalInches();

            int result;
            if (A < B)
                result = -1;
            else if (A > B)
                result = +1;
            else
                result = 0;

            return result;
        }

        public static bool operator ==(Distance A, Distance B)
        {
            return A.Compare(B) == 0;
        }

        public static bool operator !=(Distance A, Distance B)
        {
            return A.Compare(B) != 0;
        }

        public static bool operator <(Distance A, Distance B)
        {
            return A.Compare(B) < 0;
        }

        public static bool operator >(Distance A, Distance B)
        {
            return A.Compare(B) > 0;
        }

        public static bool operator <=(Distance A, Distance B)
        {
            return A.Compare(B) <= 0;
        }

        public static bool operator >=(Distance A, Distance B)
        {
            return A.Compare(B) >= 0;
        }

    }
}
