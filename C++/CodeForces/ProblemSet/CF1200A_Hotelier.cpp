#include <bits/stdc++.h>

#define int long long int
#define F first
#define S second
#define pb push_back

using namespace std;


void solve() {
    int n;	string nString;
    cin >> n >> nString;

    vector<int> roomOrder(10, 0);

    for(int i = 0; i < n; i++)
    {
    	if(nString[i] == 'L')
    	{
    		for(int j = 0; j < 10; j++)
    		{
    			if(roomOrder[j] == 0)
    			{
    				++roomOrder[j];
    				break;
    			}
    		}
    	}
    	else if(nString[i] == 'R')
    	{
    		for(int j = 10 - 1; j >= 0; j--)
    		{
    			if(roomOrder[j] == 0)
    			{
    				++roomOrder[j];
    				break;
    			}
    		}
    	}
    	else
    	{
    		int value = nString[i] - '0';
    		roomOrder[value] = 0;
    	}
    }

    for(int i : roomOrder) cout << i << "";
    cout << "\n";



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