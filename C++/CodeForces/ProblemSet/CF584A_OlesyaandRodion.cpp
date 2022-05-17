#include <bits/stdc++.h>
using namespace std;

#define int long long int
#define F first
#define S second
#define pb push_back
#define pll pair<int, int>
#define vll vector<ll>
int max(int a, int b) { return ((a > b) ? a : b); }
int min(int a, int b) { return ((a > b) ? b : a); }


void solve() {
    int n, t;
    cin >> n >> t;

	if(t == 10)
	{
		if(n == 1) cout << -1 << "\n";
		else
		{
			for(int i = 1; i <= n - 1; i++)
			{
				cout << 1;
			}

			cout << 0 << "\n";
		}
	}
	else
	{
		for(int i = 1; i <= n; i++)
			cout << t;
		cout << "\n";
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