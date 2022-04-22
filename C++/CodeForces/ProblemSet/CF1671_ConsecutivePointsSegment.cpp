#include <bits/stdc++.h>

#define int long long int
#define F first
#define S second
#define pb push_back

using namespace std;


void solve() {
	int t;
	string s;
	bool flag;

	cin >> t;

    string aDoubleString = "aa";
    string aTripleString = "aaa";
    string bDoubleString = "bb";
    string bTripleString = "bbb";

    while(t) 
    {	
    	cin >> s;
    	flag = 1;

    	string newString = "";
    	newString += s[0];

    	for(int i = 1; i < s.length(); i++)
    	{
    		if(s[i-1] == s[i]) 
    		{
    			newString += s[i];
    		} 
    		else 
    		{
    			if(i == s.length() - 1) 
    			{
    				newString += s[i];
    			}

    			int aCount = count(newString.begin(), newString.end(), 'a');
    			int bCount = count(newString.begin(), newString.end(), 'b');


				if(s[i - 1] == 'a')
    			{

    				if(aCount < 2 || bCount == 1) 
	    			{
	    				flag = 0;
	    				break;
	    			}

	    			newString = s[i];
    			}
    			else
    			{
    				if(bCount < 2 || aCount == 1)
	    			{
	    				flag = 0;
	    				break;
	    			}

	    			newString = s[i];
    			}
    			
    		}
    	}



    	if(flag == 1 && s.length() != 1) cout << "YES" << "\n";
    	else cout << "NO" << "\n";


    	t--;
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