#include<bits/stdc++.h>
using namespace std;


int main()
{
    string oldString;
    string newString = "";

    for (int i = 0; i < 3; i++)
    {
        cin >> oldString;
        if (oldString == "tapioka" || oldString == "bubble")
        {
        }
        else
        {
            newString += oldString + " ";
        }
    }

    if (newString == "") 
    {
        newString = "nothing";
    }
    else
    {
        newString.pop_back();
    }

    cout << newString << endl;

}

