#include <iostream>
#include<math.h>
#include<iomanip>
using namespace std;

void showArray(int[], const int);
int sumAllElem(int[], const int);
double meanValueElem(int[], const int);
int sumNegativeElem(int[], const int);
int sumPositiveElem(int[], const int);
int sumOddIndex(int[], const int);
int sumEvenIndex(int[], const int);
int maxElemIndex(int[], const int);
int minElemIndex(int[], const int);
int ProdElemBetweenMaxMin(int[], const int);
void bubbleSort(int[], const int);


int main()
{
    system("chcp 1251");
    const int n = 10;
    int mas[n] = { 2, -3, 0, -7, 24, -15, 13, -8, 4, 6 };
    /*for (int i = 0; i < n; i++)
    {
        cout << "mas[" << i << "]=";
        cin >> mas[i];
    }*/

    cout << "Ваш массив: "<< endl;
    showArray(mas, n);

    cout << "\nСумма элементов массива: " << sumAllElem(mas, n) << endl;

    cout << "Среднее значение элементов массива: " << meanValueElem(mas, n) << endl;

    cout << "Сумма отрицательных элементов массива: " << sumNegativeElem(mas, n) << endl;

    cout << "Сумма положительных элементов массива: " << sumPositiveElem(mas, n) << endl;

    cout << "Сумма элементов с нечётным индексом: " << sumOddIndex(mas, n) << endl;

    cout << "Сумма элементов с чётным индексом: " << sumEvenIndex(mas, n) << endl;

    int maxIndex = maxElemIndex(mas, n);
    cout << "Наибольший элемент массива: " << mas[maxIndex] << " с индексом " << maxIndex << endl;

    int minIndex = minElemIndex(mas, n);
    cout << "Наименьший элемент массива: " << mas[minIndex] << " с индексом " << minIndex << endl;

    cout << "Произведение элементов массива, расположенных между максимальным и минимальным элементами: " << ProdElemBetweenMaxMin(mas, n) << endl;

    cout << "Сортировка: ";
    bubbleSort(mas, n);
}

void showArray(int Arr[], const int N) {
    for (int i = 0; i < N; i++) {
        cout << Arr[i] << " ";
    }
}

int sumAllElem(int Arr[], const int N)
{
    int s = 0;
    for (int i = 0; i < N; i++)
    {
        s += Arr[i];
    }
    return s;
}

double meanValueElem(int Arr[], const int N)
{
    return ((double)sumAllElem(Arr, N) / N);
}

int sumNegativeElem(int Arr[], const int N)
{
    int s = 0;
    for (int i = 0; i < N; i++) {
        if (Arr[i] < 0) {
            s += Arr[i];
        }
    }
    return s;
}

int sumPositiveElem(int Arr[], const int N)
{
    int s = 0;
    for (int i = 0; i < N; i++) {
        if (Arr[i] > 0) {
            s += Arr[i];
        }
    }
    return s;
}

int sumOddIndex(int Arr[], const int N)
{
    int s = 0;
    for (int i = 1; i < N; i += 2) {
        s += Arr[i];
    }
    return s;
}

int sumEvenIndex(int Arr[], const int N)
{
    int s = 0;
    for (int i = 0; i < N; i += 2) {
        s += Arr[i];
    }
    return s;
}

int maxElemIndex(int Arr[], const int N)
{
    int maxElem = 0;
    int maxIndex = 0;
    for (int i = 0; i < N; i++) {
        if (Arr[i] > maxElem) {
            maxElem = Arr[i];
            maxIndex = i;
        }
    }
    return maxIndex;
}

int minElemIndex(int Arr[], const int N)
{
    int minElem = 0;
    int minIndex = 0;
    for (int i = 0; i < N; i++) {
        if (Arr[i] < minElem) {
            minElem = Arr[i];
            minIndex = i;
        }
    }
    return minIndex;
}

int ProdElemBetweenMaxMin(int Arr[], const int N)
{
    int res = 1;
    int minIndex = minElemIndex(Arr, N);
    int maxIndex = maxElemIndex(Arr, N);
    if (minIndex < maxIndex) {
        for (int i = minIndex + 1; i < maxIndex; i++) {
            res *= Arr[i];
        }
    }
    else {
        for (int i = maxIndex + 1; i < minIndex; i++) {
            res *= Arr[i];
        }
    }
    return res;
}

void bubbleSort(int Arr[], const int N)
{
    int min = 0;
    int temp = 0;
    for (int i = 0; i < N; i++) {
        //min = i;
        for (int j = i + 1; j < N; j++) {
            min = (Arr[j] < Arr[i]) ? j : i;
            if (i != min)
            {
                temp = Arr[i];
                Arr[i] = Arr[min];
                Arr[min] = temp;
            }
        }
    }
    showArray(Arr, N);
}

