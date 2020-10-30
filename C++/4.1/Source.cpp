#include <iostream>

using namespace std;

int main()
{
    int input;

    cin >> input;

    if ( input > 0 ) {
        cout << input << endl;
        cout << "This is a positive number" << endl;
    }
    else if (input < 0)
    {
        cout << input << endl;
        cout << "This number is negative" << endl;
    }
    else if (input == 0)
    {
        cout << input << endl;
        cout << "This number is Zero" << endl;
    }
    return 0;
}
