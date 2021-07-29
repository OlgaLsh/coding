#include <iostream>
#include "time.h"

Time::Time()
{
    hour = min = sec = 0;
}

Time::Time(int Thour, int Tminute, int Tsecond)
{
    setTime(Thour, Tminute, Tsecond);
}

void Time::setTime(int Thour, int Tminute, int Tsecond)
{
    if ((Thour < 0) || (Tminute < 0) || (Tsecond < 0))
    {
        throw Time::TimeException("Время не может быть отрицательным.");
    }
    else
    {
        if (Tsecond >= 60)
        {
            Tminute += Tsecond / 60;
            Tsecond = Tsecond % 60;
        }
        if (Tminute >= 60)
        {
            Thour += Tminute / 60;
            Tminute = Tminute % 60;
        }
        hour = Thour;
        min = Tminute;
        sec = Tsecond;
    }
}

Time Time::sum(const Time& t1, const Time& t2)
{
    Time sumTime;
    sumTime.setTime(t1.hour + t2.hour, t1.min + t2.min, t1.sec + t2.sec);
    return sumTime;
}

void Time::showTime() const
{
    if (hour < 10)
    {
        cout << "0" << hour;
    }
    else
    {
        cout << hour;
    }
    if (min < 10)
    {
        cout << ":0" << min;
    }
    else
    {
        cout << ":" << min;
    }
    if (sec < 10)
    {
        cout << ":0" << sec << endl;
    }
    else
    {
        cout << ":" << sec << endl;
    }
}

Time::TimeException::TimeException(std::string error)
{
    origin = error;
}