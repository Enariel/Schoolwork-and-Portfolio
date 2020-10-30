#include <iostream>
#include <iomanip>
#include <string>
#include <fstream>

using namespace std;

int main()
{
	string firstName;
	string lastName;

	double curSal;
	double bonus;
	double updatedSalary;

	ifstream inData;
	ofstream outData;

	inData.open("Ch3_Ex5Data.txt");
	outData.open("Ch3_Ex5Data.dat");

	while (inData >> lastName >> firstName >> curSal >> bonus)
	{
		bonus = bonus * .01;
		updatedSalary = curSal + (curSal * bonus);
		outData << setprecision(2) << fixed << showpoint;
		outData << firstName << " " << lastName << " " << updatedSalary << endl;
	}

	inData.close();
	outData.close();

	return 0;
}