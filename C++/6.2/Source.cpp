#include <iostream>
#include <string>

using namespace std;

bool isVowel(char chr)
{
    char vowels[10] = { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };

    for (int i = 0; i < 10; i++)
    {
        if (chr == char(vowels[i]))
        {
            return true;
        }
    }
    return false;
}

int main()
{
    char input;
    
    cin >> input;

    cout << input << " is a vowel: " << isVowel(input);

    return 0;
}
