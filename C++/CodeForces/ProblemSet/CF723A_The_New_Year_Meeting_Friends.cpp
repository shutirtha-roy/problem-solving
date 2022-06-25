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
    int x1, x2, x3;
    cin >> x1 >> x2 >> x3;

    vector<int> nValues;
    nValues.push_back(x1);
    nValues.push_back(x2);
    nValues.push_back(x3);

    sort(nValues.begin(), nValues.end());

    int count = nValues[2] - nValues[1] + nValues[1] - nValues[0];
    
    cout << count << "\n";
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