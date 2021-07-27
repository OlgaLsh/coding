#include <iostream>
#include<math.h>
#include<iomanip>
using namespace std;

int Myroot(double, double, double, double&, double&);

int Myroot(double a, double b, double c, double& x1, double& x2)
{
    int n = 0;
    double D = pow(b, 2) - 4 * a * c;
    if (D > 0)
    {
        n = 1;
        x1 = (-b + sqrt(D)) / (2 * a);
        x2 = (-b - sqrt(D)) / (2 * a);
    }
    else if (D == 0)
    {
        n = 0;
        x1 = (-b) / (2 * a);
    }
    else if (D < 0)
    {
        n = -1;
    }
    return n;
}

int main()
{
    system("chcp 1251");
    double a, b, c;
    double x1 = 0;
    double x2 = 0;
    int result = 0;
    cout << "Первый коэффициент квадратного уравнения: ";
    cin >> a;
    cout << "Второй коэффициент квадратного уравнения: ";
    cin >> b;
    cout << "Третий коэффициент квадратного уравнения: ";
    cin >> c;
    result = Myroot(a, b, c, x1, x2);
    if (result == 1)
    {
        cout << "Уравнение имеет два корня: x1 = " << x1 << ", x2 = " << x2;
    }
    else if (result == 0)
    {
        cout << "Уравнение имеет равные корни: x1, x2 = " << x1;
    }
    else if (result == -1)
    {
        cout << "Корней нет";
    }


}

