#include <bits/stdc++.h>

#define int long long int
#define F first
#define S second
#define pb push_back

using namespace std;


void solve() {
    int t, rating;
    cin >> t;

    for(int i = 0; i < t; i++)
    {
    	cin >> rating;

    	if(1900 <= rating) cout << "Division 1" << "\n";
    	else if(rating >= 1600 && rating <= 1899) cout << "Division 2" << "\n";
    	else if(rating >= 1400 && rating <= 1599) cout << "Division 3" << "\n";
    	else if(rating <= 1399) cout << "Division 4" << "\n";
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