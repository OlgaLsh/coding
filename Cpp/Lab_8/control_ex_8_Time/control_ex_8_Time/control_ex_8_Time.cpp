#include <iostream>
#include "time.h"
using namespace std;

int main()
{
	system("chcp 1251");
	Time t0;
	t0.showTime();
	int hour = -1;
	int min = -1;
	int sec = -1;

	cout << "Введите отрезок времени в формате чч:мм:сс: ";
	cin >> hour >> min >> sec;

	while (hour < 0 || min < 0 || sec < 0)
	{
		cout << "Время не может быть отрицательным. Повторите ввод: ";
		cin >> hour >> min >> sec;
	}
	const Time t1(hour, min, sec);
	t1.showTime();

	cout << "Введите второй отрезок времени в формате чч:мм:сс: ";
	cin >> hour >> min >> sec;
	while (hour < 0 || min < 0 || sec < 0)
	{
		cout << "Время не может быть отрицательным. Повторите ввод: ";
		cin >> hour >> min >> sec;
	}
	const Time t2(hour, min, sec);
	t2.showTime();

	t0 = t0.sum(t1, t2);

	cout << "Суммарно времени: ";
	t0.showTime();
}