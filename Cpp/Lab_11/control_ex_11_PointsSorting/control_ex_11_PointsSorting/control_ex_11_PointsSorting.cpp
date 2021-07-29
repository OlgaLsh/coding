﻿#include <iostream>
#include <string>
#include <vector>
#include <algorithm> 
using namespace std;

class Point
{
    private:
	double x;
	double y;

    public:

	Point(double px, double py) :x(px), y(py)
	{}

	friend double DistToCenter(Point p)
	{
		return  sqrt((p.x) * (p.x) + (p.y) * (p.y));
	}

	friend bool operator< (const Point& p1, const Point& p2)
	{
		return DistToCenter(p1) < DistToCenter(p2);
	}
	friend ostream& operator<<(ostream& stream, const Point& p)
	{
		stream << "(" << p.x << ", " << p.y << ")";
		return stream;
	}

};


int main()
{
	std::vector<Point> v;
	v.push_back(Point(1, 2));
	v.push_back(Point(10, 12));
	v.push_back(Point(21, 7));
	v.push_back(Point(4, 8));	sort(v.begin(), v.end());
	for (auto& point : v)
		cout << point << '\n';
	return 0;
}