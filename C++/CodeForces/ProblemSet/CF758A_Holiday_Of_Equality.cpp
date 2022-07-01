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
    int t;
    cin >> t;

    vector<int> a;
    int value;

    for(int i = 0; i < t; i++)
    {
    	cin >> value;
    	a.push_back(value);
    }

    if(t == 1)
    	cout << 0 << "\n";
    else
    {
    	sort(a.begin(), a.end());

    	int count = 0;
    	int maxValue = a[a.size() - 1];

    	for(int i = 0; i < a.size() - 1; i++)
    	{
    		if(maxValue == a[i])
    			break;

    		count += maxValue - a[i];
    	}

    	cout << count << "\n";
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
    //cin >> tc;
    for (int t = 1; t <= tc; t++) {
        // cout << "Case #" << t << ": ";
        solve();
    }

    
}