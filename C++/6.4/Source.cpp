#include <iostream>
#include <cmath> 
#include <iomanip>

using namespace std;

const double PI = 3.14159;
double r;

double volume(double r)
{
	double volume;

	volume = (4.0 / 3.0) * PI * pow(r, 3);

	return volume;
}

double surfaceArea(double r)
{
	double sArea;
	sArea = 4 * PI * pow(r, 2);
	return sArea;
}

int main()
{
	cin >> r;

	cout << fixed << showpoint << setprecision(2);
	cout << "Surface area of the sphere: 4 * PI * " << r << " ^ 2 = " << surfaceArea(r) << endl;
	cout << "Volume of the sphere: 4 / 3 * PI * " << r << " ^ 3 = " << volume(r) << endl;
}