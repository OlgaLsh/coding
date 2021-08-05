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
			cout << "������� ����� ������� - ������� 1 " << endl;
			cout << "�������� ������ ��������� - ������� 2" << endl;
			cout << "����� - ������� 3" << endl;
		}
		void run()
		{
			int input = 0;
			vector<Person> notes;
			help();

			while (true)
			{
				cout << "������� �������: ";
				cin >> input;

				if (input == 1)
				{
					int inputCat = 0;
					string n, p, a;
					cout << endl;
					cout << "����� �������" << endl;
					cout << endl;
					cout << "�������� ������ ��� ���������� ��������: " << endl;
					cout << "1 - ��������" << endl;
					cout << "2 - �������������" << endl;
					cout << "3 - �������" << endl;
					cin >> inputCat;

					if (inputCat == 1) {
						Person* students = new Student;
						cout << endl;
						students->setData();
						cout << endl;
						cout << "������� �������" << students->toString() << endl;
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
						cout << "������� �������" << teachers->toString() << endl;
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
						cout << "������� �������" << colleagues->toString() << endl;
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
					cout << "�������� ���� ���������:\n" << endl;
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
