#include <iostream>
#include "time.h"
using namespace std;

int main()
{
	system("chcp 1251");
	Time t0;
	t0.showTime();
	int hour, min, sec;

	try
	{
		cout << "Введите первый отрезок времени в формате чч:мм:сс: ";
		cin >> hour; 
		cin >> min; 
		cin >> sec;

		const Time t1(hour, min, sec);
		t1.showTime();

		cout << "Введите первый отрезок времени в формате чч:мм:сс: ";
		cin >> hour >> min >> sec;
		const Time t2(hour, min, sec);
		t2.showTime();

		t0 = t0.sum(t1, t2);

		cout << "Суммарно времени: ";
		t0.showTime();
	}
	catch (Time::TimeException ex)
	{
		cout << "Ошибка: " << ex.origin;
	}

}