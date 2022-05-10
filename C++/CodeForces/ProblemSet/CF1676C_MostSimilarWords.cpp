#include <bits/stdc++.h>

#define int long long int
#define F first
#define S second
#define pb push_back

using namespace std;


int getTotalIntChar(string value)
{
	if(value.length() == 0)
		return 0;

	if(value[0] == 'z')
		return (int)value[0] - 1 + getTotalIntChar(value.substr(1));

	if(value[0] == 'a')
		return (int)value[0] + 1 + getTotalIntChar(value.substr(1));

	return (int)value[0] + getTotalIntChar(value.substr(1));
}


int getTwoComparisonChar(string valueOne, string valueTwo)
{
	if(valueOne.length() == 0)
		return 0;


	if((int)valueOne[0] >= (int)valueTwo[0])
		return (int)valueOne[0] - (int)valueTwo[0] + getTwoComparisonChar(valueOne.substr(1), valueTwo.substr(1));
	else 
		return (int)valueTwo[0] - (int)valueOne[0] + getTwoComparisonChar(valueOne.substr(1), valueTwo.substr(1));
}


void solve() {
	
    int n, m;
    cin >> n >> m;

    vector<string> A(n, "");

    for(int i = 0; i < n; i++)
    {
    	cin >> A[i];
    	//cout << A[i];
    }
	
	//cout << getTwoComparisonChar(A[0], A[1]) << "\n";

	int minumumDiff = 1e9;

	for(int i = 0; i < n - 1 ; i++)
	{
		//A[i]
		for(int j = i + 1; j < n; j++)
		{
			int diff = getTwoComparisonChar(A[i], A[j]);
			if(diff < minumumDiff)
				minumumDiff = diff;
		}
	}

	cout << minumumDiff << "\n";



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