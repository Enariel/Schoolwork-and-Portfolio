#include <iostream>
#include <string>

using namespace std;

bool isPalindrome(string str)
{
    int length = str.length();

    for (int i = 0; i < length / 2; i++)
    {
        if ( str[i] != str[length – 1 – i] )
        {
            return false;
        }  
    }
    return true;
}

int main()
{
    string input;

    cin >> input;

    cout << isPalindrome(input);
    
    return 0;
}