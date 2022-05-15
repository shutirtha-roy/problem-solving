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
    bool flag = false;
    cin >> n >> t;

    vector<int> a(n, 0);

    for(int i = 1; i <= n - 1; i++)
    {
    	cin >> a[i];
    }

    

    for(int loc = 1; loc <= n; loc += a[loc])
    {
    	if(loc > t)	break;

    	if(loc == t) flag = true;
    }

    if(flag)	cout << "YES" << "\n";
    else 	cout << "NO" << "\n";
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