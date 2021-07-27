#include <iostream>
#include<math.h>
using namespace std;


struct Time
{
    int hours;
    int minutes;
    int seconds;
};

Time InputTime() 
{
    Time t;
    cout << "\nВведите часы: ";
    cin >> t.hours;
    cout << "\nВведите минуты: ";
    cin >> t.minutes;
    if (t.minutes >= 60)
        cout << "Максимальное значение минут - 60!";
    cout << "\nВведите секунды: ";
    cin >> t.seconds;
    if (t.seconds >= 60)
        cout << "Максимальное значение секунд - 60!";
    return t;
}

Time AddTime(const Time& t1, const Time& t2) {
    Time t;
    t.hours = t1.hours + t2.hours;
    t.minutes = t1.minutes + t2.minutes;
    t.seconds = t1.seconds + t2.seconds;
    if (t.seconds >= 60.0) {
        t.seconds -= 60.0;
        t.minutes++;
    }
    if (t.minutes >= 60.0) {
        t.minutes -= 60.0;
        t.hours++;
    }

    return t;
}
Time DiffTime(const Time& t1, const Time& t2) {
    Time t;
    int diff;
    diff = abs((t1.hours * 3600 + t1.minutes * 60 + t1.seconds) - (t2.hours * 3600 + t2.minutes * 60 + t2.seconds));
    t.hours = diff / 3600;
    t.minutes = (diff - (t.hours * 3600)) / 60;
    t.seconds = diff - t.hours * 3600 - t.minutes * 60;
    return t;
}
void ShowTime(Time t) {
    cout << t.hours << " : " << t.minutes << " : " << t.seconds << endl;;
}


int main()
{
    system("chcp 1251");
    Time t1 = InputTime();
    Time t2 = InputTime();
    Time t3 = AddTime(t1, t2);
    Time t4 = DiffTime(t1, t2);
    ShowTime(t3);
    ShowTime(t4);
}

