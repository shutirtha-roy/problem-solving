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
    string name = "";
    string names[5] = { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard"}; 
    cin >> n;

    if(n <= 5)
    {
    	name = names[n - 1];
    }
    else
    {
    	int i = 0;
	    n -= 5;
	    while(n > (2 << i))
	    {	
	    	if(n - 5 * (2 << i) < 0) break;

	    	n -= 5 * (2 << i);
	    	i++;
	    }

	    for(int j = 0; j < 5; j++)
	    {
	    	n -= (2 << i);
	    	
	    	if(n < 0)
	    	{
	    		name = names[j];
	    		break;
	    	}
	    }
    }
    
    cout << name << "\n";
   
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