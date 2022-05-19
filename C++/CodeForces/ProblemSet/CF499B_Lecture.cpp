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
    int n, m;
    string a, b;
    cin >> n >> m;

    vector<pair<string, string>> ab(m);
    vector<string> professorWord(n);

    for(int i = 0; i < m; i++)
    {
    	cin >> a >> b;
    	ab[i] = {a, b};
    }

    for(int i = 0; i < n; i++)
    {
    	cin >> professorWord[i];
    }

    for(string word : professorWord)
    {
    	for(int i = 0; i < m; i++)
    	{
    		if(word == ab[i].first)
    		{
    			if(ab[i].first.length() <= ab[i].second.length())
    			{
    				cout << ab[i].first << " ";
    				break;
    			}
    			else
    			{
    				cout << ab[i].second << " ";
    				break;
    			}
    		}
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