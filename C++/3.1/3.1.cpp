//Author: Oliver Conover
#include <iostream>
#include <fstream>
#include <string>
#include <iomanip>

using namespace std;

float PayCheck(float gross, float bonusPercent, float taxPercent)
{
	float payCheck;
	float bPercent = bonusPercent * .01;
	float tPercent = taxPercent * .01;

	float tBonus = gross * bPercent;
	float preTax = gross + tBonus;
	
	payCheck = preTax - (preTax * tPercent);

	return payCheck;
}

float AverageSpeed(float totalDistance, float travelTime)
{
	float averageSpeed = totalDistance / travelTime;

	return averageSpeed;
}

float TotalSales(int itemsSold, float itemCost)
{
	float totalSales = itemsSold * itemCost;
	
	return totalSales;
}

int main() 
{

	ifstream inFile;
	ofstream outFile;
	
	//File content variables
	string fName, lName, department, fullName;

	float gSal, mBonus, tax, paycheck;
	float tDistance, tTime, avgSpeed;
	
	int coffeeSold;
	float cCost, tSales;

	//Open files
	inFile.open("inData.txt");
	outFile.open("outData.txt");

	//Get all the variables for employee information to fill gaps.
	inFile >> fName >> lName >> department >> gSal >> mBonus >> tax >> tDistance >> tTime >> coffeeSold >> cCost;

	//Fill the variable gaps with functions
	fullName = fName + " " + lName;
	paycheck = PayCheck(gSal, mBonus, tax);
	avgSpeed = AverageSpeed(tDistance, tTime);
	tSales = TotalSales(coffeeSold, cCost);

	outFile << fixed << showpoint << setprecision(2);

	outFile << "Name: " << fullName << ", " << "Department: " << department << endl;
	outFile << "Monthly Gross Salary: " << "$" << gSal << ", " << "Monthly Bonus: " << mBonus << "%, " << "Taxes: " << tax << "%" << endl;
	outFile << "Paycheck: $" << paycheck << endl;
	outFile << endl;
	outFile << "Distance Traveled: " << tDistance << " miles, " << "Traveling Time: " << tTime << " hours" << endl;
	outFile << "Average Speed: " << avgSpeed << " miles per hour" << endl;
	outFile << endl;
	outFile << "Number of Coffee Cups Sold: " << coffeeSold << ", Cost: $" << cCost << " per cup" << endl;
	outFile << "Sales Amount = $" << tSales;

	//Close the files
	inFile.close();
	outFile.close();

	return 0;
}
