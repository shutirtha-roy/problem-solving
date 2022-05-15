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
    int n, a, b;
    bool flag = false;
    cin >> n;

    vector<pair<int, int>> pairList(n + 1, {0, 0});

    for(int i = 1; i <= n; i++)
    {
    	cin >> a >> b;
    	pairList[i] = {a, b};
    }

    sort(pairList.begin(), pairList.end());

    for(int i = 1; i <= n - 1; i++)
    {
    	if(pairList[i].first < pairList[i+1].first && pairList[i].second > pairList[i+1].second)
		{
			flag = true;
			break;
		}
    }
    
    if(flag) cout << "Happy Alex" << "\n";
    else cout << "Poor Alex" << "\n";

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