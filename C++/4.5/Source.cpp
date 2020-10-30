#include <iostream>
#include <cmath>

using namespace std;

void doStuff(int a, int b, int c)
{
    if (pow(a, 2) == pow(b, 2) + pow(c, 2))
    {
        cout << "It is a right angled triangle";
    }
    else if (pow(b, 2) == pow(a, 2) + pow(c, 2))
    {
        cout << "It is a right angled triangle";
    }
    else if (pow(c, 2) == pow(a, 2) + pow(b, 2))
    {
        cout << "It is a right angled triangle";
    }
    else
    {
        cout << "It is not a right angled triangle";
    }
}

int main()
{
    int sideA, sideB, sideC;

    cout << "Enter triangle sides" << endl;
    cin >> sideA >> sideB >> sideC;

    doStuff(sideA, sideB, sideC);

    return 0;
}