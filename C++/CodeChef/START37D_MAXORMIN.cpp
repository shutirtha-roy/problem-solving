#include <bits/stdc++.h>

#define int long long int
#define F first
#define S second
#define pb push_back

using namespace std;



void solve() {
    int N, Avalue;
    cin >> N;
    vector<int> binaryVector(2, 0);

    while(N--)
    {
        cin >> Avalue;
        binaryVector[Avalue]++;
    }

    if(binaryVector[0] > binaryVector[1]) cout << 0 << "\n";
    else if(binaryVector[0] <= binaryVector[1]) cout << 1 << "\n";
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