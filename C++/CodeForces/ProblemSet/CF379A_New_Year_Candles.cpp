#include <bits/stdc++.h>

#define int long long int
#define F first
#define S second
#define pb push_back

using namespace std;


double candleCount(double a, int b)
{
	if(a < 1)
	{
		return a;
	}

	return a + candleCount(a / b, b);
}


void solve() {
	int a, b;
	cin >> a >> b;

	//cout << 123 % 5 << "\n";
	cout << (int)candleCount((double)a, b) << "\n";
}

int32_t main()
{
	ios_base::sync_with_stdio(0);cin.tie(0); cout.tie(0);

    #ifndef ONLINE_JUDGE
	    freopen("input.txt", "r", stdin);
	    freopen("output.txt", "w", stdout);
	    freopen("error.txt", "w", stderr);
    #endif


	int tc = 1;
    //cin >> tc;
    for (int t = 1; t <= tc; t++) {
        // cout << "Case #" << t << ": ";
        solve();
    }


    
}