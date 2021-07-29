#pragma once
#include <iostream>

class Triangle
{
public:
	class TriangleExisting {
	public:
		std::string origin;
		TriangleExisting(std::string error);
	};

	Triangle(int, int, int);
	bool isTriangle(int, int, int);
	void setTriangle(int, int, int);
	double area(Triangle&);

private:
	double a;
	double b;
	double c;
};