#include <bits/stdc++.h>

#define int long long int
#define F first
#define S second
#define pb push_back

using namespace std;

string getXRemoval(string n)
{
	if(n.length() == 0) return "";

	if(n.length() >= 3)
	{
		if(!n.substr(0, 3).compare("xxx"))
		{

			return getXRemoval(n.substr(1));
		}
	}

	return n[0] + getXRemoval(n.substr(1));
}


void solve() {
	int n;
	string letter;
	cin >> n >> letter;

    int remainingLength = getXRemoval(letter).length();
    cout << n - remainingLength << "\n";

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