#include <iostream>
#include <cmath>
using namespace std;


int main()
{
	system("chcp 1251");
	float a1, a2, b1, b2, c1, c2, d1, d2, e1, e2, S;
	cout << "Для расчета площади пятиугольника задайте его вершины." << endl;
	cout << "Введите координаты точки А по оси x и y: ";
	cin >> a1;
	cin >> a2;
	cout << "Введите координаты точки B по оси x и y: ";
	cin >> b1;
	cin >> b2;
	cout << "Введите координаты точки C по оси x и y: ";
	cin >> c1;
	cin >> c2;
	cout << "Введите координаты точки D по оси x и y: ";
	cin >> d1;
	cin >> d2;
	cout << "Введите координаты точки E по оси x и y: ";
	cin >> e1;
	cin >> e2;
	S = abs(a1 * b2 + b1 * c2 + c1 * d2 + d1 * e2 + e1 * a2 - b1 * a2 - c1 * b2 - d1 * c2 - e1 * d2 - a1 * e2) / 2;
	cout << "Площадь пятиугольника равна: " << S;
}

