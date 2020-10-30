/*
****************************************************************
Author: Oliver (Matthew) Conover
Date: 06/Feb/2020
Professor: Chapa
Class: C++
****************************************************************
*/
#include <iostream>
#include <fstream>
#include <string>
#include <iomanip>

using namespace std;

int main()
{
    float mass;
    float density;
    float volume;

    ifstream inData;
    ofstream outData;

    inData.open("DataIn.txt");
    outData.open("DataOut.txt");

    inData >> mass >> density;
    
    volume = mass / density;

    outData << "This reads from InData to calculate the volume of lead if there was mass of " << mass << " grams of lead around." << endl;
    outData << "We know lead has a density of " << density << " grams/centimeters^3 at room temp" << endl;
    outData << setprecision(2);
    outData << "So for " << mass << " grams of lead, it will have a volume of " << volume << "g/cm^3" << endl;

    inData.close();
    outData.close();

    return 0;
}
