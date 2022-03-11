#include <bits/stdc++.h>
#define ll long long int
using namespace std;


ll lowerBound(vector<ll>& A, ll x)
{
	ll lo = 0, hi = A.size();
	while (lo < hi)
	{
		int md = (lo + hi) / 2;
		if (x <= A[md])
		{
			hi = md;
		}
		else if (x > A[md])
		{
			lo = md + 1;
		}
	}
	return hi;
}


ll upperBound(vector<ll>& A, ll x)
{
	ll lo = 0, hi = A.size();
	while (lo < hi)
	{
		int md = (lo + hi) / 2;
		if (x < A[md])
		{
			hi = md;
		}
		else if (x >= A[md])
		{
			lo = md + 1;
		}
	}
	return hi;
}



int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(NULL);

	int n;
	cin >> n;

	vector<ll> xValues;

	for (int i = 1; i <= n; i++)
	{
		ll x;
		cin >> x;
		xValues.push_back(x);
	}

	sort(xValues.begin(), xValues.end());

	int q;
	cin >> q;

	for (int i = 1; i <= q; i++)
	{
		ll m;
		cin >> m;
		int position = lowerBound(xValues, m);
		int positionUpper;

		if (position == xValues.size()) 
		{
			cout << position << endl;
		} 
		else if(m == xValues[position])
		{
			positionUpper = upperBound(xValues, m);
			
			cout << positionUpper << endl;
		}
		else
		{
			cout << position << endl;
		}
	}


}
