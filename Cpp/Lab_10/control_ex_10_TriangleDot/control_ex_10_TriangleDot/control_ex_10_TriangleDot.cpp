#include <iostream>
#include <windows.h>
#include <math.h>
#include <array>
#include "Dot.h"
using namespace std;


class Triangle
{
public:    

    Triangle(Dot *dot1, Dot *dot2, Dot *dot3)
    {        
        this->dot1 = dot1;
        this->dot2 = dot2;
        this->dot3 = dot3;
    }
      

    double Perimetr()
    {    
       double p = dot1->distanceTo(*dot2) + dot2->distanceTo(*dot3) + dot3->distanceTo(*dot1);
       cout << "Периметр треугольника равен " << p << endl;
       return p;
    }

    double Square()
    {
        double p = dot1->distanceTo(*dot2) + dot2->distanceTo(*dot3) + dot3->distanceTo(*dot1);
        double S = sqrt(p * (p - dot1->distanceTo(*dot2)) * (p - dot2->distanceTo(*dot3)) * (p - dot3->distanceTo(*dot1)));
        cout << "Площадь треугольника равна " << S << endl;
        return S;
    }

private:    
    Dot *dot1, *dot2, *dot3;
};

class Triangle2
{
public:

    Triangle2(Dot dot1, Dot dot2, Dot dot3)
    {
        this->dot1 = dot1;
        this->dot2 = dot2;
        this->dot3 = dot3;
    }

    double Perimetr()
    {
        double p = dot1.distanceTo(dot2) + dot2.distanceTo(dot3) + dot3.distanceTo(dot1);
        cout << "Периметр треугольника: " << p << endl;
        return p;
    }

    double Square()
    {
        double p = dot1.distanceTo(dot2) + dot2.distanceTo(dot3) + dot3.distanceTo(dot1);
        double S = sqrt(p * (p - dot1.distanceTo(dot2)) * (p - dot2.distanceTo(dot3)) * (p - dot3.distanceTo(dot1)));
        cout << "Площадь треугольника: " << S << endl;
        return S;
    }


private:

    Dot dot1, dot2, dot3;
};

int main()
{
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);
    array<Dot, 3> d;
    for (int i = 0; i < 3; i++)
    {
        double x, y;
        cout << "Введите координаты X и Y точки " << i + 1 << endl;
        cin >> x;
        cin >> y;
        d[i] = Dot(x, y);    }

    Triangle* tr = new Triangle(&d[0], &d[1], &d[2]);
    
    tr->Perimetr();
    tr->Square();

    array<Dot, 3> d1;

    for (int i = 0; i < 3; i++)
    {
        double x, y;
        cout << "Введите координаты X и Y точки " << i + 1 << endl;
        cin >> x;
        cin >> y;
        d[i] = Dot(x, y);
    }
    Triangle2* tr1 = new Triangle2(d[0], d[1], d[2]);

    tr1->Perimetr();
    tr1->Square();

    return 0;
}