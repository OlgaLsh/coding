#include <iostream>
#include <cmath>
using namespace std;

int main()
{
    system("chcp 1251");
    int a = 1;
    int b = 2;
    int c = 5;
    int d = 10;
    int S;
    cout << "Введите денежную сумму для расчета монет: "; cin >> S;
    int d1 = S / d;
    int tempD = S % d;
    int c1 = tempD / c;
    int tempC = tempD % c;
    int b1 = tempC / b;
    int tempB = tempC % b;
    int a1 = tempB / a;
    cout << "Монеты номиналом 10 руб: " << d1 << endl;
    cout << "Монеты номиналом 5 руб: " << c1 << endl;
    cout << "Монеты номиналом 2 руб: " << b1 << endl;
    cout << "Монеты номиналом 1 руб: " << a1 << endl;
    int itog = d1 + c1 + b1 + a1;
    cout << "Наименьшее число монет для " << S << " рублей: " << itog <<endl;
}
