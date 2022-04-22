#include <bits/stdc++.h>

#define int long long int
#define F first
#define S second
#define pb push_back

using namespace std;




void solve() {
    int t, n, count, a, flag, output;


    cin >> t;

    while(t) 
    {
    	cin >> n;
        vector<int> arr(n + 1, 0);
        flag = 0;

    	while(n)
    	{
    		cin >> a;
    		arr[a]++;

    		if(arr[a] == 3) 
    		{
    			flag++;
    			if(flag == 1) cout << a << "\n";
    		}

    		n--;
    	}

    	if(flag == 0) cout << -1 << endl;

    	t--;
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