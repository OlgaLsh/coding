#include <iostream>
using namespace std;

int main()
{
    system("chcp 1251");
    int year;
    cout << "Високосный ли год: ";
    cin >> year;
    if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) {
        cout << "Это високосный год";
    }
    else {
        cout << "Это не високосный год";
    }
}
