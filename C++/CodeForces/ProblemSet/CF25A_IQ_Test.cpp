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
    int n;
    cin >> n;

    int totalEven = 0, totalOdd = 0;
    int num, evenIndex, oddIndex;
    int index = 1;
    while(n--)
    {
    	cin >> num;

    	if(num % 2 == 0)
    	{
    		evenIndex = index;
    		totalEven++;
    	}
    	else if(num % 2 == 1)
    	{
    		oddIndex = index;
    		totalOdd++;
    	}

    	index++;
    }

    if(totalEven == 1)
    	cout << evenIndex << "\n";
    else if(totalOdd == 1)
    	cout << oddIndex << "\n";
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