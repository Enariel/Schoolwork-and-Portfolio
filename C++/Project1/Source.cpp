// Oliver (Matt) Conover
// Professor Chapa
// C++
// DOK1 1/22/2020

#include <iostream>
#include <string>

using namespace std;

int main() 
{
	string name;
	int age;
	int modifier;

	modifier = 5;
	
	cout << "Enter your name: ";
	cin >> name;
	cout << "Enter your current age: ";
	cin >> age;

	cout << "Hello! " << name << "In " << modifier << "years you will be " << modifier + age << endl;

	return 0;
}