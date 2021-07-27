#include <iostream>
#include <fstream>
using namespace std;

int main()
{
	const int N = 10;
	int a[N] = { 2, 14, 7, 9, 1, 72, 6, 11, 30, 5 };
	int min = 0;
	int buf = 0;
	ofstream out;
	out.open("file.txt");
	out << "Исходный массив: ";
	for (int i = 0; i < N; i++) {
		out << a[i] << '\t';
	}
	for (int i = 0; i < N; i++) {
		min = i;
		for (int j = i + 1; j < N; j++)
			min = (a[j] < a[min]) ? j : min;
		if (i != min) {
			buf = a[i];
			a[i] = a[min];
			a[min] = buf;
		}
	}
	out << "\nОтсортированный массив: ";
	for (int i : a)
		out << i << '\t';
	out.close();
	return 0;
}
