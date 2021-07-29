#include <iostream>
#include <map>
#include <Windows.h>
#include <string>
#include <iterator>
using namespace std;
struct StudentGrade {
    string student_name;
    char grade;
};
int main()
{
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);
    StudentGrade student;
    map<string, char> all_students;
    int n;
    cout << "Введите число ваших студентов: ";
    cin >> n;
    for (int i = 0; i < n; i++) {
        cout << "Имя студента: ";
        cin >> student.student_name;
        student.grade = {};
        all_students.insert(make_pair(student.student_name, student.grade));
    }
    map<string, char>::iterator it = all_students.begin();
    cout << "Список студентов: " << endl;
    for (int i = 0; it != all_students.end(); it++, i++) {
        cout << i + 1 << ". " << it->first << " - " << it->second << endl;
    }
    cout << "Кому вы хотите поставить оценку? ";
    cin >> student.student_name;
    it = all_students.find(student.student_name);
    if (it != all_students.end()) {
        cout << "Поставьте оценку студенту " << it->first << endl;
        cin >> student.grade;
        it->second = student.grade;
    }
    else
        cout << "Такого студента нет в списке" << endl;
    it = all_students.begin();
    for (int i = 0; it != all_students.end(); it++, i++) {
        cout << i + 1 << ". " << it->first << " - " << it->second << endl;
    }
    return 0;
}
