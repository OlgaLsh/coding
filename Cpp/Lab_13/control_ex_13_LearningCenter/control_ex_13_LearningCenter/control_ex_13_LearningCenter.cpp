#include <iostream>
#include <vector>
#include "human.h"
#include "student.h"
#include "teacher.h"
#include <Windows.h>
using namespace std;

int main()
{
	system("chcp 1251");
	human* arr[100];
	int n = 0;
	char choice;
	do {
		cout << "Вы студент или учитель? (s/t): ";
		cin >> choice;
		if (choice == 's')
			arr[n] = new student;
		else
			arr[n] = new teacher;
		arr[n++]->get_data();
		cout << "Продолжать? (y/n): ";
		cin >> choice;
	} while (choice == 'y');
	for (int j = 0; j < n; j++)
		arr[j]->put_data();
	cout << endl;
	return 0;
}