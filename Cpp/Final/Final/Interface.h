#pragma once
#include <iostream>
#include <fstream>
#include <vector>
#include "Person.h"
#include "Teacher.h"
#include "Student.h"
#include "Colleague.h"
using namespace std;



	class Interface
	{
	public:
		void help()
		{
			cout << "Создать новый контакт - нажмите 1 " << endl;
			cout << "Просмотр списка контактов - нажмите 2" << endl;
			cout << "Выход - нажмите 3" << endl;
		}
		void run()
		{
			int input = 0;
			vector<Person> notes;
			help();

			while (true)
			{
				cout << "Введите команду: ";
				cin >> input;

				if (input == 1)
				{
					int inputCat = 0;
					string n, p, a;
					cout << endl;
					cout << "Новый контакт" << endl;
					cout << endl;
					cout << "Выберите группу для добавления контакта: " << endl;
					cout << "1 - Студенты" << endl;
					cout << "2 - Преподаватели" << endl;
					cout << "3 - Коллеги" << endl;
					cin >> inputCat;

					if (inputCat == 1) {
						Person* students = new Student;
						cout << endl;
						students->setData();
						cout << endl;
						cout << "Создать контакт" << students->toString() << endl;
						notes.push_back(*students);
						ofstream infile("AddressBook.txt");
						infile.is_open();
						for (auto& note : notes)
							infile << note << '\n';
						infile.close();
					}
					else if (inputCat == 2)
					{
						Person* teachers = new Teacher;
						cout << endl;
						teachers->setData();
						cout << endl;
						cout << "Создать контакт" << teachers->toString() << endl;
						notes.push_back(*teachers);
						ofstream infile("AddressBook.txt");
						infile.is_open();
						for (auto& note : notes)
							infile << note << '\n';
						infile.close();
					}
					else if (inputCat == 3)
					{
						Person* colleagues = new Colleague;
						cout << endl;
						colleagues->setData();
						cout << endl;
						cout << "Создать контакт" << colleagues->toString() << endl;
						notes.push_back(*colleagues);
						ofstream infile("AddressBook.txt");
						infile.is_open();
						for (auto& note : notes)
							infile << note << '\n';
						infile.close();
					}
				}
				else if (input == 2)
				{
					cout << endl;
					cout << "Просмотр всех контактов:\n" << endl;
					cout << endl;
					for (auto& note : notes)
						cout << note << '\n';
				}
				else if (input == 3)
				{
					break;
				}
			}
		}

	};
