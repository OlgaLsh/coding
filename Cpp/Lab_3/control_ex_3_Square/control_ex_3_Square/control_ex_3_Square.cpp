#include <iostream>
#include <iomanip>
#include <cmath>
using namespace std;

double OneSide(double x1, double x2, double y1, double y2) {
	return (sqrt(pow((x1 - x2), 2) + pow((y1 - y2), 2)));
}
double OneSquare(double l1, double l2, double l3) {
	double p = (l1 + l2 + l3) / 2;
	return (sqrt(p * (p - l1) * (p - l2) * (p - l3)));
}

int main()
{
    system("chcp 1251");
	double Xa, Ya, Xb, Yb, Xc, Yc, Xd, Yd, Xe, Ye, lab, lbc, lac, lcd, lad, lde, lae,
		Sabc, Sacd, Saed, Stotal;
	cout << "Введите координаты точки А: ";
	cin >> Xa;
	cin >> Ya;
	cout << "Введите координаты точки В: ";
	cin >> Xb;
	cin >> Yb;
	cout << "Введите координаты точки С: ";
	cin >> Xc;
	cin >> Yc;
	cout << "Введите координаты точки D: ";
	cin >> Xd;
	cin >> Yd;
	cout << "Введите координаты точки E: ";
	cin >> Xe;
	cin >> Ye;

	lab = OneSide(Xa, Xb, Ya, Yb);
	lbc = OneSide(Xb, Xc, Yb, Yc);
	lac = OneSide(Xa, Xc, Ya, Yc);
	lcd = OneSide(Xc, Xd, Yc, Yd);
	lad = OneSide(Xa, Xd, Ya, Yd);
	lde = OneSide(Xd, Xe, Yd, Ye);
	lae = OneSide(Xa, Xe, Ya, Ye);

	Sabc = OneSquare(lab, lbc, lac);
	Sacd = OneSquare(lac, lcd, lad);
	Saed = OneSquare(lae, lde, lad);

	Stotal = Sabc + Sacd + Saed;
	cout << "Площадь фигуры: " << Stotal;
}

