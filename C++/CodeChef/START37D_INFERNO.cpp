#include <bits/stdc++.h>

#define int long long int
#define F first
#define S second
#define pb push_back

using namespace std;


void solve() {
    int N, X;
    int singleScore = 0, multiScore = 0;
    cin >> N >> X;

    vector<int> A(N, 0);

    for(int i = 0; i < N; i++)
    {
        cin >> A[i];
    }

    multiScore = *std::max_element(A.begin(), A.end());

    for(int i = 0; i < N; i++)
    {
        while(A[i] > 0)
        {
            singleScore++;
            A[i] -= X;
        }
    }


    cout << min(singleScore, multiScore) << "\n";
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