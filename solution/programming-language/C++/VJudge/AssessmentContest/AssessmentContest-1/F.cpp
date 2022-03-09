#include<bits/stdc++.h>
using namespace std;

int main()
{
    int T;
    cin >> T;

    double AB;
    double AC;
    double BC;
    double ratio;
    double AD;

    for (int i = 0; i < T; i++)
    {
        cin >> AB;
        cin >> AC;
        cin >> BC;
        cin >> ratio;

        AD = sqrt(ratio / (ratio + 1)) * AB;

        cout << "Case " << i+1 << ": " << setprecision(10) << AD << endl;
    }
}
