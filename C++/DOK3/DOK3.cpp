/*

DOK3 COP 2222
Professor Chapa
Oliver Conover and Cameron Nash

*/
#include <iostream>
#include <string>

using namespace std;

int toBinary(string input)
{

    for (int i = 0; i <= input.length(); i++)
    {
        int c = int(input[i]);

        string binary = "";

        while (c > 0)
        {
            (c % 2) ? binary.push_back('1') :
                binary.push_back('0');
            c /= 2;
        }
        reverse(binary.begin(), binary.end());

        cout << binary << " ";
    }

    return 0;

}

int main()
{
    string input;
    string output;
    int bitshift = 1;

    cout << "Enter a word: ";
    cin >> input;

    toBinary(input);
}