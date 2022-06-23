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

int withdrawCount(int bills, int &num)
{
	int total = num / bills;
	num %= bills;
    return total;
}

void solve() {
    int n, count = 0;
    cin >> n;

    count += withdrawCount(100, n);
    count += withdrawCount(20, n);
    count += withdrawCount(10, n);
    count += withdrawCount(5, n);
    count += n;

    cout << count << "\n";

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