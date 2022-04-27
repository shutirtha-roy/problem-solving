#include <bits/stdc++.h>

#define int long long int
#define F first
#define S second
#define pb push_back

using namespace std;


void solve() {
    int N;
    cin >> N;

    int Aprevious, Apresent, temp;
    int count = 0;
    cin >> Aprevious;

    for(int i = 1; i < N; i++)
    {
    	cin >> Apresent;


    	if(Aprevious > Apresent)
    	{
    		count++;
    		temp = Apresent;
    		Apresent = Aprevious;
    		Aprevious = temp;
    	}
    	else
    	{
    		Aprevious = Apresent;
    	}
    }


    if(count == 0 || count == 1)
    {
    	cout << "YES" << "\n";
    }
    else
    {
    	cout << "NO" << "\n";
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