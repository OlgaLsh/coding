#include <iostream>
#include <windows.h>
using namespace std;

template <class T>
T average(T arr[], int size)
{
	T sum = 0;
	for (int i = 0; i < size; i++) {
		sum += arr[i];
	}
	return sum / size;
}

int main()
{
	SetConsoleOutputCP(1251);
	int arr[] = { 5,-3,7,14,0,47,-21,4,12 };
	long arrl[] = { 1456854737563, 74615387947257, 5465168767527, 2649616577527, 484654684375272, 654684687543752 };
	double arrd[] = { 2.75,4.71,-1.69,6.6,1.43,2.4,3.7,-2.98,3.25 };
	char arrc[] = { 'h','e','l','l','o','w','o','r','l','d' };
	int k1 = sizeof(arr) / sizeof(arr[0]);
	int k2 = sizeof(arrd) / sizeof(arrd[0]);
	int k3 = sizeof(arrl) / sizeof(arrl[0]);
	int k4 = sizeof(arrc) / sizeof(arrc[0]);

	cout << "Average of int: " << average(arr, k1) << endl;
	cout << "Average of double: " << average(arrd, k2) << endl;
	cout << "Average of long: " << average(arrl, k3) << endl;
	cout << "Average of char: " << int(average(arrc, k4)) << " " << average(arrc, k4) << endl;
}