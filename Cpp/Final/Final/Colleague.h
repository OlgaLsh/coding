#pragma once
#include "Person.h"
#include <string>
#include <iostream>
using namespace std;

class Colleague : public Person
{
public:
	void setData()
	{
		Person::setData();
		Person::setCategory("Коллеги");
	}
};