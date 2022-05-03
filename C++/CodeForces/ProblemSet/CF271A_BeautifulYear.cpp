#include <bits/stdc++.h>

#define int long long int
#define F first
#define S second
#define pb push_back

using namespace std;

vector<int> numbers(4, 0);

void solve() {
    int y;
    cin >> y;

    int Y = ++y;
    while(true)
    {
    	for(int j = 0; j < 4; j++)
	    {
	    	numbers[j] = y % 10;
	    	y /= 10;
	    }

	    y = Y;

	    reverse(numbers.begin(), numbers.end());

	    int count = 0;

	    if(numbers[0] == numbers[1] || numbers[0] == numbers[2] || numbers[0] == numbers[3] || numbers[1] == numbers[2] || numbers[1] == numbers[3] || numbers[2] == numbers[3])
	    	count++;

	    if(!count)
	    {
	    	cout << y << "\n";
	    	break;
	    }


    	y++;
    	Y = y;
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