#pragma once
#include <string>
#include <sstream>
#include <iostream>
class human {
public:
	virtual void get_data() {
		std::cout << "�������: ";
		std::cin >> last_name;
		std::cout << "���: ";
		std::cin >> name;
		std::cout << "��������: ";
		std::cin >> second_name;
	}
	virtual void put_data() {
		std::cout << "�.�.�.: " << last_name << " " << name << " " << second_name << std::endl;
	}
private:
	std::string name;
	std::string last_name;
	std::string second_name;
};