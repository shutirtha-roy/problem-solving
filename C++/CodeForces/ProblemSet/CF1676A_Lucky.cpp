#include <bits/stdc++.h>

#define int long long int
#define F first
#define S second
#define pb push_back

using namespace std;


void solve() {
    string value;
    cin >> value;

    int first3Digit = 0;
    int last3Digit = 0;

    for(int i = 0; i < 6; i++)
    {
        int intValue = value[i] - '0';

        if(i <= 2)
        {
            first3Digit += intValue;
        }
        else if(i >= 3)
        {
            last3Digit += intValue;
        }
    }

    if(first3Digit == last3Digit)   cout << "YES" << "\n";
    else cout << "NO" << "\n";
}

int32_t main()
{
	ios_base::sync_with_stdio(0);cin.tie(0); cout.tie(0);

    #ifndef ONLINE_JUDGE
	    freopen("input.txt", "r", stdin);
	    freopen("output.txt", "w", stdout);
    #endif

	int tc = 1;
    cin >> tc;
    for (int t = 1; t <= tc; t++) {
        // cout << "Case #" << t << ": ";
        solve();
    }

    
}