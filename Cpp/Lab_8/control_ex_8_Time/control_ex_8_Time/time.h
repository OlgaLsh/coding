#pragma once
using namespace std;


class Time
{
public:
    Time();
    Time(int, int, int);
    void setTime(int, int, int);
    Time sum(const Time&, const Time&);
    void showTime() const;

private:
    int hour;
    int min;
    int sec;
};

