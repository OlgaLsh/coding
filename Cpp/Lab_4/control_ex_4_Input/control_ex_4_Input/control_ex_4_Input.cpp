#include <iostream>
#include<math.h>
#include<iomanip>
using namespace std;

int Input(int&, int&);

int Input(int& a, int& b)
{
    cout << "Введите параметры А и В: " << endl;
    cin >> a; cin >> b;
    if (a <= 0 || b <= 0)
    {
        return 0;
    }
    else
    {
        return 1;
    }
}


int main()
{
    system("chcp 1251");
    int a, b;
    if (Input(a, b) == false) // if(!Input(a,b))
    {
        cerr << "error";
        return 1;
    }
    int s = a + b;
    
    cout << "a + b = " << s << endl;

    return 0;
}
