#pragma once
#include <string>
#include <sstream>
#include <iostream>
using namespace std;

class Person
{
public:
	virtual void setData()
	{
		cin.clear();
		cin.ignore(32767, '\n');
		cout << "������� �.�.�.: ";
		getline(cin, name);
		cout << "������� ����� ��������: ";
		getline(cin, phone);
		cout << "������� ���� ��������: ";
		getline(cin, birthday);
	}

	virtual string toString() const
	{
		ostringstream note;
		note << "\n������: " << this->group << "\n�.�.�.: " << this->name << "\n�������: " << this->phone << "\n���� ��������: " << this->birthday << " ";
		return note.str();
	}

	void setCategory(string c)
	{
		group = c;
	}

	string getPhone() { return this->phone; }
	string getBday() { return this->birthday; }

	friend std::ostream& operator<< (std::ostream& out, const Person& pers)
	{
		out << pers.toString();
		return out;
	}
private:
	string group;
	string name;
	string phone;
	string birthday;
};