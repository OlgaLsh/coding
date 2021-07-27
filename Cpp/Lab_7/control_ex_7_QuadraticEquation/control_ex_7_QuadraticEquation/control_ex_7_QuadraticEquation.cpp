#include <iostream>
#include<math.h>
using namespace std;

struct Roots {
    double x1;
    double x2;
};
Roots QuadRoots(double a, double b, double c)
{
    Roots x;
    double D = pow(b, 2) - 4 * a * c;
    if (D > 0)
    {
        x.x1 = (-b + sqrt(D)) / (2 * a);
        x.x2 = (-b - sqrt(D)) / (2 * a);
    }
    else if (D == 0)
    {
        x.x1 = x.x2 = (-b) / (2 * a);
    }
    else if (D < 0) {
        x.x1 = numeric_limits<double>::quiet_NaN();
        x.x2 = numeric_limits<double>::quiet_NaN();
    }

    return x;
}
void ShowRoots(Roots x) {
    if (isnan(x.x1) && isnan(x.x2)) {
        cout << "Корней нет";
    }
    else if (x.x1 != x.x2) {
        cout << "Корни уравнения: " << x.x1 << " и " << x.x2;
    }
    else if (x.x1 == x.x2) {
        cout << "Корень уравнения один: " << x.x1;
    }
}
int main()
{
    system("chcp 1251");
    double a, b, c;
    Roots x;
    x.x1 = 0;
    x.x2 = 0;
    cout << "Введите три коэффициента квадратного уравнения: ";
    cin >> a;
    cin >> b;
    cin >> c;
    x = QuadRoots(a, b, c);
    ShowRoots(x);
}