#include <bits/stdc++.h>

#define int long long int
#define F first
#define S second
#define pb push_back

using namespace std;


void solve() {
	int n, lastDigit, secondLastDigit;
	cin >> n;

	if(n < 0)
	{
		n *= -1;
		lastDigit = n % 10;
		secondLastDigit = (n / 10) % 10;

		int removeHundredFromN = n / 100;

		if(removeHundredFromN == 0 && lastDigit == 0 || removeHundredFromN == 0 && secondLastDigit == 0)
		{
			cout << 0 << endl;
		}
		else if(secondLastDigit < lastDigit)
		{
			if(removeHundredFromN != 0)
			{
				cout << -1 * removeHundredFromN << secondLastDigit << endl;
			}
			else
			{
				cout << -1 * secondLastDigit << endl;
			}
			
		} 
		else
		{
			if(removeHundredFromN != 0)
			{
				cout << -1 * removeHundredFromN << lastDigit << endl;
			}
			else
			{
				cout << -1 * lastDigit << endl;
			}
			
		}
	}
	else 
	{
		cout << n << endl;
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