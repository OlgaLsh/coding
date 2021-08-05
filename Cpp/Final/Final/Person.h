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
		cout << "Введите Ф.И.О.: ";
		getline(cin, name);
		cout << "Введите номер телефона: ";
		getline(cin, phone);
		cout << "Введите дату рождения: ";
		getline(cin, birthday);
	}

	virtual string toString() const
	{
		ostringstream note;
		note << "\nГруппа: " << this->group << "\nФ.И.О.: " << this->name << "\nТелефон: " << this->phone << "\nДень рождения: " << this->birthday << " ";
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