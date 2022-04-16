#include <bits/stdc++.h>

#define int long long int
#define F first
#define S second
#define pb push_back

using namespace std;


bool isComposite(int x)
{
	if(x == 1) return false;

    for(int i = 2; i*i <= x; i++)
    {
        if(x % i == 0) return true;
    }

    return false;
}


void solve() {
    int n, x, y;
    cin >> n;

    for(int i = 4; i <= n / 2; i++)
    {
    	x = i;
    	y = n - i;

    	if(x % 2 == 0 && y % 2 == 0)
    	{
    		cout << x << " " << y << endl;
    		break;
    	} 
    	else if(isComposite(x) && isComposite(y))
    	{
    		cout << x << " " << y << endl;
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