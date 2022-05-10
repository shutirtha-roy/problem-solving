#include <bits/stdc++.h>

#define int long long int
#define F first
#define S second
#define pb push_back

using namespace std;


void solve() {
    int n;
    cin >> n;

    vector<int> A(n, 0);


    for(int i = 0; i < n; i++)
    {
    	cin >> A[i];
    }

    sort(A.begin(), A.end());

    int minimum = A[0];

    int count = 0;

    for(int i = 1; i < n; i++)
    {
    	count += A[i] - A[0];
    }

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
    cin >> tc;
    for (int t = 1; t <= tc; t++) {
        // cout << "Case #" << t << ": ";
        solve();
    }

    
}