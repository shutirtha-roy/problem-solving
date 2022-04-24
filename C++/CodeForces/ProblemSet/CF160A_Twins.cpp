#include <bits/stdc++.h>

#define int long long int
#define F first
#define S second
#define pb push_back

using namespace std;


void solve() {
    int n, a;
    cin >> n;
    vector<int> aValues;

    int totalSum = 0, addSum = 0;

    for(int i = 0; i < n; i++)
    {
    	cin >> a;
    	aValues.pb(a);
        totalSum += a;
    }

    sort(aValues.begin(), aValues.end());


    for(int i = 0; i < n; i++)
    {
        totalSum -= aValues[n - i - 1];
        addSum += aValues[n - i - 1];
        
        if(addSum > totalSum)
        {
            cout << i + 1 << "\n";
            break;
        }
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