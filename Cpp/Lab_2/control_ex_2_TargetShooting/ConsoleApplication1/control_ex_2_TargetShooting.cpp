#include <iostream>
#include <cmath>
using namespace std;

int main()
{
	system("chcp 1251");
	int Total;
	double x, y;
	double length;
	int Level1 = 1;
	int Level2 = 2;
	int Level3 = 3;
	int Scores = 0;
	int N = 0, i = 0;
	cout << "Общее число очков, которое вы хотите набрать: ";
	cin >> Total;
	while (i < Total) {
		cout << "Введите кординаты X и Y: " << endl;
		cin >> x;
		cin >> y;
		length = sqrt(pow(x, 2) + pow(y, 2));
		if (length <= Level1) {
			Scores = 10;
		}
		else if (length > Level1 && length <= Level2) {
			Scores = 5;
		}
		else if (length > Level2 && length <= Level3) {
			Scores = 1;
		}
		else if (length > Level3) {
			Scores = 0;
		}
		N++;
		i += Scores;
	}
	cout << "Выстрелов: " << N << endl;
	if (N == Total/10) {
		cout << "Снайпер";
	}
	else if (N == ((Total % 10) / 5)) {
		cout << "Стрелок";
	}
	else if (N > ((Total % 10) % 5)) {
		cout << "Новичок";
	}
}

