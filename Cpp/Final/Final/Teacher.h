#pragma once
#include "Person.h"
#include <string>
#include <iostream>
using namespace std;

class Teacher : public Person
{
public:
	void setData()
	{
		Person::setData();
		Person::setCategory("Преподаватели");
	}
};