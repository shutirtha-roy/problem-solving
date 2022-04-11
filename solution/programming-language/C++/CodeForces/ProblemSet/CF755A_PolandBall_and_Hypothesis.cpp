#include <bits/stdc++.h>

#define int long long int
#define F first
#define S second
#define pb push_back

using namespace std;


bool isPrime(int x)
{
	if(x == 1) return false;

    for(int i = 2; i*i <= x; i++)
    {
        if(x % i == 0) return false;
    }

    return true;
}


void solve() {
	int n;
	cin >> n;

    for(int m = 1; m <= 1000; m++) 
    {
    	if(!isPrime(n * m + 1))
    	{
    		cout << m << endl;
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
    // cin >> tc;
    for (int t = 1; t <= tc; t++) {
        // cout << "Case #" << t << ": ";
        solve();
    }

    
}