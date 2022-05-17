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
    cin >> n;

    vector<int> firstList(n, 0);
    vector<int> secondList(n - 1, 0);
    vector<int> thirdList(n - 2, 0);

    int firstValue = 0, secondValue = 0, thirdValue = 0;

    for(int i = 0; i < n; i++)
    {
        cin >> firstList[i];
        firstValue += firstList[i];
    }

    for(int i = 0; i < n - 1; i++)
    {
        cin >> secondList[i];
        secondValue += secondList[i];
    }


    cout << firstValue - secondValue << "\n";

    for(int i = 0; i < n - 2; i++)
    {
        cin >> thirdList[i];
        thirdValue += thirdList[i];
    }

    cout << secondValue - thirdValue << "\n";

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