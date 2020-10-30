#include <iostream>

using namespace std;

int main()
{
    int input;

    cout << "Enter an integer between 0 and 35" << endl;
    cin >> input;

    if ( input <= 9 )
    {
        cout << input;
    }
    else if ( input >= 10 )
    {
        input += 55;
        static_cast<char>(input);
        cout << input;
    }
    return 0;
}