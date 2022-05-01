#include <bits/stdc++.h>

#define int long long int
#define F first
#define S second
#define pb push_back

using namespace std;

map<char, int> letterValues;

void initializeMap()
{
	int j = 1;

	for(char i = 'a'; i <= 'z'; i++, j++)
	{
		letterValues[i] = j;
	}
}

void solve() {
    int n;
    string s;
    cin >> n;

    while(n--)
    {
    	int aliceScore = 0, bobScore = 0;
    	cin >> s;

    	if(s.length() == 1)
		{
			bobScore = letterValues[s[0]];
		}
		else
		{
			for(int i = 1; i < s.length() - 1; i++)
			{
				aliceScore += letterValues[s[i]];
			}

			if(s.length() % 2 == 0) 
			{
				aliceScore += letterValues[s[0]];
				aliceScore += letterValues[s[s.length() - 1]];
				bobScore = 0;
			}
			else
			{
				if(letterValues[s[0]] > letterValues[s[s.length() - 1]])
				{
					aliceScore += letterValues[s[0]];
					bobScore = letterValues[s[s.length() - 1]];
				}
				else
				{
					aliceScore += letterValues[s[s.length() - 1]];
					bobScore = letterValues[s[0]];
				}
			}
		}

   
		if(bobScore > aliceScore) cout << "Bob " << bobScore - aliceScore << "\n";
		else cout << "Alice " << aliceScore - bobScore << "\n";
    }
}

int32_t main()
{
	ios_base::sync_with_stdio(0);cin.tie(0); cout.tie(0);

    #ifndef ONLINE_JUDGE
	    freopen("input.txt", "r", stdin);
	    freopen("output.txt", "w", stdout);
    #endif

	initializeMap();

	int tc = 1;
    // cin >> tc;
    for (int t = 1; t <= tc; t++) {
        // cout << "Case #" << t << ": ";
        solve();
    }

    
}