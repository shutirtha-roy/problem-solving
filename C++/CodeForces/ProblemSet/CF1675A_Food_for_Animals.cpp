#include <bits/stdc++.h>

#define int long long int
#define F first
#define S second
#define pb push_back

using namespace std;


void solve() {
    int a, b, c, x, y;
    cin >> a >> b >> c >> x >> y;

    a -= x;
    b -= y;

    if(a >= 0 && b >= 0)
    	cout << "YES" << "\n";
    else
    {
    	if(a < 0)
    		c += a;

    	if(b < 0)
    		c += b;

    	if(c < 0) 
    		cout << "NO" << "\n";
    	else
    		cout << "YES" << "\n";
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