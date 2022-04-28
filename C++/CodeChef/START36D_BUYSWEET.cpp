#include <bits/stdc++.h>

#define int long long int
#define F first
#define S second
#define pb push_back

using namespace std;


void solve() {
    int N, R, sweets = 0;
    cin >> N >> R;

    vector<int> A(N + 1, 0);
    vector<int> B(N + 1, 0);

    for(int i = 1; i <= N; i++)
        cin >> A[i];

    for(int i = 1; i <= N; i++)
        cin >> B[i];


    vector<tuple<int, int, int>> allCosts(N + 1, {0, 0, 0});

    for(int i = 1; i <= N; i++)
    {
        allCosts[i] = make_tuple(A[i] - B[i], A[i], B[i]);
    }


    sort(allCosts.begin(), allCosts.end());


    for (int i = 1; i <= N; i++) 
    {
        int effectiveCost = get<0>(allCosts[i]);
        int cost = get<1>(allCosts[i]);
        int returnedAmount = get<2>(allCosts[i]);

        if(R >= cost)
        {
            R -= cost;
            sweets++;

            sweets += R / effectiveCost;
            R %= effectiveCost;

            R += returnedAmount;
        }
    }

    cout << sweets << "\n";
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