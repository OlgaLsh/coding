#include <iostream>
#include<math.h>
#include<iomanip>
using namespace std;

int DecToBin(int n)
{
    if (n < 0) {
        cout << "Значение не может быть меньше 0";
        //DecToBin(-n);
    }
    else if (n < 2) {
        cout << n;
        return n;
    }
    else {
        DecToBin(n / 2);
        int bin = n % 2;
        cout << bin;
    }
}

int main()
{
    int a;
    system("chcp 1251");
    cout << "Введите десятичное число для перевода его в бинарное: " << endl;
    cin >> a;
    DecToBin(a);
}

