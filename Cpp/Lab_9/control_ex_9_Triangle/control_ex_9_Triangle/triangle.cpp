#include <math.h>
#include "triangle.h"

Triangle::TriangleExisting::TriangleExisting(std::string error)
{
	origin = error;
}

Triangle::Triangle(int a1, int b1, int c1)
{
	setTriangle(a1, b1, c1);
}

bool Triangle::isTriangle(int a, int b, int c)
{
	if ((a + b > c) && (b + c > a) && (a + c > b))
	{
		return true;
	}
	else
	{
		throw Triangle::TriangleExisting("Треугольник с такими стоорнами не существует!");
		return false;
	}
}

void Triangle::setTriangle(int a1, int b1, int c1)
{
	if (isTriangle(a1, b1, c1))
	{
		a = a1;
		b = b1;
		c = c1;
	}
}

double Triangle::area(Triangle& triangle)
{
	double p = (triangle.a + triangle.b + triangle.c) / 2;
	return sqrt(p * (p - triangle.a) * (p - triangle.b) * (p - triangle.c));
}