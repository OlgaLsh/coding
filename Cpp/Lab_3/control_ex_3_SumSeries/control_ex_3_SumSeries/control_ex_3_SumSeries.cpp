#include <iostream>
#include<math.h>
#include<iomanip>
using namespace std;

int SumSeries(int n, int yournum)
{
    if (n == 1)
    {
        return yournum;
    }
    else
    {
        return (yournum * n + SumSeries(n - 1, yournum));
    }
}

int main()
{
    system("chcp 1251");
    int a, b;
    cout << "Введите число N: " << endl;
    cin >> a;
    cout << "Введите ваше число: " << endl;
    cin >> b;
    if (a > 0)
    {
        cout << SumSeries(a, b);
    }
    else
    {
        cout << "Error! N должно быть больше 0!";
    }
}

