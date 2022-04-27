#include <bits/stdc++.h>

#define int long long int
#define F first
#define S second
#define pb push_back

using namespace std;


void solve() {
    int X, Y, Z;
    cin >> X >> Y >> Z;

    if(Z % X == 0 && Z % Y == 0) cout << "ANY" << "\n";
    else if(Z % X == 0) cout << "CHICKEN" << "\n";
    else if(Z % Y == 0) cout << "DUCK" << "\n";
    else cout << "NONE" << "\n"; 
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