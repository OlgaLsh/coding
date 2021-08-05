#pragma once
#include "Person.h"
#include <string>
#include <iostream>
using namespace std;

class Student : public Person
{
public:
	void setData()
	{
		Person::setData();
		Person::setCategory("Студенты");
	}
};
