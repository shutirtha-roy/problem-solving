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
    int n, total = 0;
    int totalCount = 0;
    cin >> n;
    vector<int> h(n, 0);
    bool flag = true;

    for(int i = 0; i < n; i++)
    {
    	cin >> h[i];
    }

    for(int i = 0; i < n; i++)
    {
        totalCount += i;
        total += h[i];

        if(total < totalCount)
        {
            flag = false;
            break;
        }
    }

    if(flag)
    {
        cout << "YES" << "\n";
    }
    else
    {
        cout << "NO" << "\n";
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
    cin >> tc;
    for (int t = 1; t <= tc; t++) {
        // cout << "Case #" << t << ": ";
        solve();
    }

    
}