#include <bits/stdc++.h>

#define int long long int
#define F first
#define S second
#define pb push_back

using namespace std;


void solve() {
    int n, k, value;
    cin >> n >> k;

    if(n % 2 == 0)
    {
        if(k - n / 2 >= 1)
        {
            cout << (k - n / 2) * 2 << "\n";
        }
        else
        {
            cout << k * 2 - 1 << "\n";
        }
    }
    else if(n % 2 != 0)
    {
        if(k - (n + 1) / 2 >= 1)
        {
            cout << (k - (n + 1) / 2) * 2 << "\n";
        }
        else
        {
            cout << k * 2 - 1 << "\n";
        }
    }
}

int32_t main()
{
	ios_base::sync_with_stdio(0);cin.tie(0); cout.tie(0);

    #ifndef ONLINE_JUDGE
	    freopen("input.txt", "r", stdin);
	    freopen("output.txt", "w", stdout);
    #endif

	int tc = 1;
    // cin >> tc;
    for (int t = 1; t <= tc; t++) {
        // cout << "Case #" << t << ": ";
        solve();
    }

    
}