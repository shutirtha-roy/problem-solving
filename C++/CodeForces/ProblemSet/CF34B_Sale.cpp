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
    int n, m;
    cin >> n >> m;
    vector<int> a(n, 0);

    for(int i = 0; i < n; i++)
    {
    	cin >> a[i];
    }

    sort(a.begin(), a.end());

    int total = 0;

    for(int i = 0; i < m; i++)
    {
    	if(a[i] >= 0) 
    		break;

    	if(a[i] < 0)
    		total += -a[i];
    }

    cout << total << "\n";
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