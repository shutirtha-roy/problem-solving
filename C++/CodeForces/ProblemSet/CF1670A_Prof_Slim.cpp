#include <bits/stdc++.h>

#define int long long int
#define F first
#define S second
#define pb push_back

using namespace std;


void solve() {
    int n;
    cin >> n;

    vector<int> a(n, 0);

    for(int i = 0; i < n; i++)
    {
    	cin >> a[i];
    }

    int initialPosition = 0;
    for(int i = 0; i < n; i++)
    {
        if(a[i] < 0)
        {
            a[initialPosition] *= -1;
            initialPosition++;
            a[i] *= -1;
        }
    }   

    if(is_sorted(a.begin(), a.end()))
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