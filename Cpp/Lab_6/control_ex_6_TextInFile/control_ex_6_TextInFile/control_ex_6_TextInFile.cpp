#include <iostream>
#include <fstream>
#include <string>
#include <windows.h>
using namespace std;

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	char str[50];
	const int line = 4;
	ofstream out;
	out.open("file.txt");
	if (!out) {
		cout << "Файл открыть невозможно";
		return 1;
	}
	cout << "Напишите четверостишие: " << endl;
	for (int i = 0; i < line; i++) {
		cin.getline(str, 50);
		out << str << "\n";
	}
	out.close();
	return 0;

}

