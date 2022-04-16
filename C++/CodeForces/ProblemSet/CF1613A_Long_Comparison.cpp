#include <bits/stdc++.h>

#define int long long int
#define F first
#define S second
#define pb push_back

using namespace std;

int getPowerValue(int x, int p)
{
	int newX = x;

	for(int i = 1; i <= p; i++) 
    {
    	newX *= 10;
    }

	return newX;
}

char comparison(int x1, int x2)
{
	if(x1 == x2) return '=';
	else if(x1 > x2) return '>';
	else return '<';
}


void solve() {
    int x1, p1, x2, p2;
    cin >> x1 >> p1 >> x2 >> p2;

    int value = min(p1, p2);
    p1 = p1 - value;
    p2 = p2 - value;

    if(p1 >= 7) 
    {
    	cout << '>' << endl;
    }
    else if(p2 >= 7) 
    {
    	cout << '<' << endl;
    }
    else
    {
	    x1 = getPowerValue(x1, p1);
	    x2 = getPowerValue(x2, p2);
	    cout << comparison(x1, x2) << endl;
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