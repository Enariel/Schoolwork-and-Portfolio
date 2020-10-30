#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
    double kilos;
    double lbs;
    const double convert = 2.2;

    cin >> kilos;

    lbs = kilos * convert;

    cout << setprecision(2) << fixed << showpoint;
    cout << lbs;

    return 0;
}