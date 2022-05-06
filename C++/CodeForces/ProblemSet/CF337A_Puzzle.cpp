#include <bits/stdc++.h>

#define int long long int
#define F first
#define S second
#define pb push_back

using namespace std;


void solve() {
    int n, m;
    cin >> n >> m;

    vector<int> f(m, 0);
    for(int i = 0; i < m; i++)
    {
    	cin >> f[i];
    }

    sort(f.begin(), f.end());

    int minumum = 1000;

    for(int i = 0; n + i <= m; i++)
    {
        if(f[n - 1 + i] - f[i] < minumum)
        {
            minumum = f[n - 1 + i] - f[i];
        }
    }

    cout << minumum << "\n";
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