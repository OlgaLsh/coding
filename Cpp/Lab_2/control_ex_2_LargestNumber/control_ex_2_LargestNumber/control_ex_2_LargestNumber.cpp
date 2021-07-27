#include <iostream>
using namespace std;

int main()
{
    system("chcp 1251");
    int a, b, c;
    cout << "Введите три числа, чтобы узнать, какое из них наибольшее: " << endl;
    cin >> a;
    cin >> b;
    cin >> c;
    if (a>b && a>c || a==b || a==c)
    {
        cout << "Наибольшее число: " << a << endl;
    }
    else
    {
        if (b > c || b == c)
        {
            cout << "Наибольшее число: " << b << endl;
        }
        else
        {
            cout << "Наибольшее число: " << c << endl;
        }
    }
}
