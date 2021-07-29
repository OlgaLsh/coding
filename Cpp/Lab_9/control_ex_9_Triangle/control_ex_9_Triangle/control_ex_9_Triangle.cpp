#include <iostream>
#include "triangle.h"
using namespace std;

int main()
{
	system("chcp 1251");
	double a, b, c, s;
	cout << "Введите стороны вашего треугольника:" << endl;
	cin >> a >> b >> c;
	try
	{
		Triangle myTriangle = Triangle(a, b, c);
		s = myTriangle.area(myTriangle);
		cout << "Площадь треугольника =  " << s << endl;
	}
	catch (Triangle::TriangleExisting ex)
	{
		cout << "Исключение: " << ex.origin;
	}
}