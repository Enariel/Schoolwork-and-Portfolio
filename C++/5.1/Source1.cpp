#include <iostream>
#include <iomanip>
#include <cmath>
using namespace std;

int main()
{
    double pi = 0;
    long i;
    long n;

    cout << "Enter the value of n: ";
    cout << endl;
    cin >> n;



    for (i = 0; i < n; i++)
    {

        if (i % 2 == 0)
        {
            pi = 1 + (1 / (2 * n + 1));
            cout << pi;
        }
        
        else
        {
            pi = 1 - (1 / (2 * n + 1));

            cout << pi;
        }
        pi = pi * 4;
    }

    
    
    cout << endl << "pi = " << pi << endl;
    return 0;
}