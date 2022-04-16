#include<bits/stdc++.h>
using namespace std;


int main()
{
    int v, a, r, p, h;
    cin >> v; //Vincent
    cin >> a; //Anthony
    cin >> r; //Rene
    cin >> p; //Pierre
    cin >> h; // 3 of them -> h

    int personHeight[4] = { v, a, r, p };
    sort(personHeight, personHeight + 4);
    int arrSize = sizeof(personHeight) / sizeof(personHeight[0]);
    int totalMaxHeight = 0;

    for (int i = 1; i < arrSize; i++)
    {
        totalMaxHeight += personHeight[i];
    }

    if (totalMaxHeight >= h) 
    {
        cout << "WAW";
    }
    else 
    {
        cout << "AWW";
    }

    return 0;
}
