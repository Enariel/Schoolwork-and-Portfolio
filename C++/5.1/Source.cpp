#include <iostream>

using namespace std;

void splitNumber(int num)
{
    int x1, x2, x3, x4, x5, x6, x7, x8, x9;

    x1 = num % 10;
    num /= 10;
    x2 = num % 10;
    num /= 10;
    x3 = num % 10;
    num /= 10;
    x4 = num % 10;
    num /= 10;
    x5 = num % 10;
    num /= 10;
    x6 = num % 10;
    num /= 10;
    x7 = num % 10;
    num /= 10;
    x8 = num % 10;
    num /= 10;
    x9 = num % 10;
    num /= 10;

    cout << x9 << endl;
    cout << x8 << endl;
    cout << x7 << endl;
    cout << x6 << endl;
    cout << x5 << endl;
    cout << x4 << endl;
    cout << x3 << endl;
    cout << x2 << endl;
    cout << x1 << endl;


}

int main()
{
    int input;

    cout << "Enter an integer: ";

    cin >> input;

    splitNumber(input);

    return 0;
}