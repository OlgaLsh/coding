#include <iostream>
#include<math.h>
using namespace std;


double Root_1(int a) 
{
    return pow(a, 1.0 / 3);
}

double Root_2(int a)
{
    double x, x1;
    x = a;
    do {
        x1 = x;
        x = 0.5 * (x + 3 * a / (2 * x * x + a / x));

    } while (abs(x - x1) > 1 / 100000);

    return x;
}

int main()
{
    system("chcp 1251");
    double a, x1, x2;
    cout << "Введите a: ";
    cin >> a;
    x1 = Root_1(a);
    x2 = Root_2(a);
    cout << "Стандартная функция: " << x1 << endl;
    cout << "Итерационная формула: " << x2 << endl;
    return 0;
}

