#pragma once
#include <string>
#include <sstream>
#include <iostream>
class human {
public:
	virtual void get_data() {
		std::cout << "Фамилия: ";
		std::cin >> last_name;
		std::cout << "Имя: ";
		std::cin >> name;
		std::cout << "Отчество: ";
		std::cin >> second_name;
	}
	virtual void put_data() {
		std::cout << "Ф.И.О.: " << last_name << " " << name << " " << second_name << std::endl;
	}
private:
	std::string name;
	std::string last_name;
	std::string second_name;
};