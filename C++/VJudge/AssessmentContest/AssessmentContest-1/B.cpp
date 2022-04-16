#include<bits/stdc++.h>
using namespace std;

int main()
{
    long long int n;
    string userName;
    string changedUserName;
    cin >> n;

    for (int i = 0; i < n; i++)
    {
        cin >> userName;
        changedUserName = userName + ": F";
        cout << changedUserName << endl;
    }

    return 0;
}