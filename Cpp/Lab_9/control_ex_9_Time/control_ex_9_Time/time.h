#pragma once
using namespace std;

class Time
{
public:
    class TimeException {
    public:
        std::string origin;
        TimeException(std::string error);
    };

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