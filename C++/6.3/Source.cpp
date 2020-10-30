#include <iostream>
#include <string>

using namespace std;

int isVowel(string chr)
{
    int count = 0;
    char vowels[10] = { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };

    for (int i = 0; i < chr.length(); i++)
    {
        for (int n = 0; n < 10; n++)
        {
            if (chr[i] == char(vowels[n]))
            {
                count++;
            }
        }
    }
    return count;
}

int main()
{
    string input;

    getline(cin, input);

    cout << input;
    cout << "There are " << isVowel(input) << " vowels in this sentence.";

    return 0;
}