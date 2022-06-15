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
    int x, n, m;
    int xprev = -1;
    cin >> x >> n >> m;

    while ((n > 0 || m > 0))
    {
        if (n > 0 && x > 20)
        {
            x = (x / 2) + 10;
            n--;
        }
        else if (m > 0)
        {
            x = x - 10;
            m--;
        }

        if (xprev == x)
            break;

        xprev = x;
    }

    if (x <= 0)
        cout << "YES" << "\n";
    else
        cout << "NO" << "\n";
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