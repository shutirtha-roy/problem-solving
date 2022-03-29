#include <bits/stdc++.h>

#define int long long int
#define F first
#define S second
#define pb push_back

using namespace std;


void solve() {
    string keyboardKeys = "qwertyuiopasdfghjkl;zxcvbnm,./";
    //cout << keyboardKeys.find('u');
    char pos;
    cin >> pos;
    string sequence;
    cin >> sequence;

    int findIndex;

    for(char character :  sequence)
    {
    	findIndex = keyboardKeys.find(character);

    	if(pos == 'R')
    	{
    		if(findIndex == 0)
    		{
    			cout << character;
    		}
    		else
    		{
    			cout << keyboardKeys[findIndex - 1];
    		}
    	}
    	else if(pos == 'L')
    	{
    		if(findIndex == keyboardKeys.length() - 1)
    		{
    			cout << character;
    		}
    		else
    		{
    			cout << keyboardKeys[findIndex + 1];
    		}
    	}
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