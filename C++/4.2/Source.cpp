#include <iostream>

using namespace std;

void sortAlg(int x, int y, int z)
{
    if ( x > y )
    {
        swap(x, y);
    }
    if (y > z)
    {
        swap(y, z);
    }
    if (x > y)
    {
        swap(x, y);
    }

    cout << x << " " << y << " " << z << endl;
}

int main()
{
    int firstNum;
    int secNum;
    int thirdNum;

    int smallNum;
    int medNum;
    int bigNum;

    cout << "Input three numbers." << endl;
    cin >> firstNum >> secNum >> thirdNum;

    sortAlg(firstNum, secNum, thirdNum);
    
    return 0;
}