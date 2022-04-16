#include <bits/stdc++.h>

#define int long long int
#define F first
#define S second
#define pb push_back

using namespace std;

vector<int> generateLuckyNumber()
{
	vector<int> luckyNumbers;

	for(int i = 1; i <= 1000; i++)
	{
		string nValue = to_string(i);
		bool flag = true;
		for (char x : nValue)
		{
			if(x != '4' && x != '7')
			{
				flag = false;
			}
		}

		if(flag)
		{
			luckyNumbers.pb(i);
		}
	}

	return luckyNumbers;
}


void luckyNumber(int n) 
{
	vector<int> luckyNumbers = generateLuckyNumber();

	bool luckyValue = false;

	for(int x : luckyNumbers)
	{
		if(n % x == 0)
		{
			luckyValue = true;
			cout << "YES" << endl;
			break;
		}
	}

	if(!luckyValue)
	{
        cout << "NO" << endl;
	}
} 


void solve() 
{
	int n;
	cin >> n;
	luckyNumber(n);
}

int32_t main()
{
	ios_base::sync_with_stdio(0);cin.tie(0); cout.tie(0);

    #ifndef ONLINE_JUDGE
	    freopen("input.txt", "r", stdin);
	    freopen("output.txt", "w", stdout);
	    freopen("error.txt", "w", stderr);
    #endif

	

	int tc = 1;
    //cin >> tc;
    for (int t = 1; t <= tc; t++) {
        // cout << "Case #" << t << ": ";
        solve();
    }


    cin.clear();
	cin.get();
	return 0;
}