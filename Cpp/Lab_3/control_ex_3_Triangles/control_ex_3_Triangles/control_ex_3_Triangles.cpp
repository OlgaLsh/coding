#include <iostream>
#include<math.h>
using namespace std;

double TrSquare(double a)
{
	double square, pp;
	pp = (a * 3) / 2;
	square = sqrt(pp * pow((pp - a), 3));
	return square;
}
double TrSquare(double a, double b, double c)
{
	double square, pp;
	pp = (a + b + c) / 2;
	square = sqrt(pp * (pp - a) * (pp - b) * (pp - c));
	return square;
}


int main()
{
	system("chcp 1251");
	string triangle;
	cout << "Ваш треугольник равносторонний? да/нет: " << endl;
	cin >> triangle;
	if (triangle == "да")
	{
		cout << "Введите сторону равностороннего треугольника: " << endl;
		double side;
		cin >> side;
		cout << " Площадь равностороннего треугольника:  " << TrSquare(side) << endl;
	}
	else
	{
		double side1;
		double side2;
		double side3;
		cout << "Введите три стороны разностороннего треугольника: " << endl;
		cin >> side1;
		cin >> side2;
		cin >> side3;
		cout << "Площадь разностороннего треугольника " << TrSquare(side1, side2, side3) << endl;
	}
}
