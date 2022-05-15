#include <bits/stdc++.h>
using namespace std;

#define int long long int
#define F first
#define S second
#define pb push_back
#define pll pair<int, int>
#define vll vector<ll>
int max(int a, int b) { return ((a > b) ? a : b); }
int min(int a, int b) { return ((a > b) ? b : a); }


void solve() {
    int n;
    cin >> n;
    char c;

    int count = 0;
    bool flag; // (
    int totalCount = 0;

    int openingRoundBracket = 0;
    int closingRoundBracket = 0;
    int totalCorrectPair = 0;

    for(int i = 1; i <= n; i++)
    {
    	cin >> c;

    	if(c == '(' && closingRoundBracket == 0)
        {
            openingRoundBracket++;
        }
        else if(c == ')' && openingRoundBracket > 0)
        {
            openingRoundBracket--;
            totalCorrectPair += 1;
        }
        
        /*
        cout << "Opening Round Bracket" << openingRoundBracket << "\n";
        cout << "Closing Round Bracket" << closingRoundBracket << "\n";
        cout << "Total Correct Pair" << totalCorrectPair << "\n"; 
        cout << "\n";
        */
    }

    cout << (n - totalCorrectPair * 2) / 2 << "\n";
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