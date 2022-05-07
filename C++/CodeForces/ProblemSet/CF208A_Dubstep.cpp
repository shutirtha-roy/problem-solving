#include <bits/stdc++.h>

#define int long long int
#define F first
#define S second
#define pb push_back

using namespace std;


string wub = "WUB";

string getString(char x)
{
    string s(1, x);
    return s;  
}

string withoutWUB(string s)
{
	//cout << s << "\n";


	if(s.length() == 0)
		return "";

	if(s.length() == 1)
		return getString(s[0]);


	if(wub.compare(s.substr(0, 0 + 3)) == 0)
	{
		return withoutWUB(s.substr(0 + 3));
	}

	if(wub.compare(s.substr(1, 1 + 2)) == 0)
	{
		return getString(s[0]) + " " + withoutWUB(s.substr(1 + 3));
	}
	else
	{
		return getString(s[0]) + withoutWUB(s.substr(0 + 1));
	}
	
	
}



void solve() {
    string s;
    cin >> s;

    string output = withoutWUB(s);

    if(output[output.length() - 1] == ' ')
    	cout << output.substr(0, output.length() - 1) << "\n";
    else
    	cout << output << "\n";
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