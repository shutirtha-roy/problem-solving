#include <bits/stdc++.h>

#define int long long int
#define F first
#define S second
#define pb push_back

using namespace std;

map<int, int> allValues;

void initializeAllValues()
{
	for(int i = 1; i <= 1001; i++)
	{
		allValues[i] = 0;
	}
}


void solve() {
	initializeAllValues();
	
    int n, A;
    cin >> n;

    vector<pair<int, int>> vec1;

    for(int i = 0; i < n; i++)
    {
    	cin >> A;
    	if(i == 0) allValues[A] = -1;
    	else allValues[A] = i;
    	
    	//vec1.push_back(make_pair(i, allValues[A]));
    }

    
    for(int i = 1; i <= 1000; i++)
	{
		if(allValues[i] == 0) continue;
		
		vec1.push_back(make_pair(allValues[i], i));
	}


	sort(vec1.begin(), vec1.end());
	int N = sizeof(vec1)/sizeof(vec1[0]);

	int count = 0;
	vector<int> rightValues;

    for(auto i : vec1)
    {
    	if(i.first == 0) continue;
    	
    	rightValues.push_back(i.second);
    	count++;
    }

    cout << count << "\n";
    for(auto i : rightValues)
    {
    	cout << i << " ";
    }

    cout << "\n";
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