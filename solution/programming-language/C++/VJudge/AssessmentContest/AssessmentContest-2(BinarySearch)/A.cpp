#include <bits/stdc++.h>
using namespace std;



int lowerBound(vector<int>& A, int x)
{
	int lo = 0, hi = A.size();
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

int upperBound(vector<int>& A, int x)
{
	int lo = 0, hi = A.size();
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


int main() {
	
	int N;
	scanf("%d", &N);

	vector<int> height;

	for (int i = 1; i <= N; i++)
	{
		int value;
		scanf("%d", &value);
		height.push_back(value);
	}

	int Q;
	scanf("%d", &Q);

	for (int i = 1; i <= Q; i++)
	{
		int newValue;
		scanf("%d", &newValue);
		
		int lower = lowerBound(height, newValue) - 1;
		int upper = upperBound(height, newValue);

		if (lower < 0)
		{
			cout << 'X' << " ";
		}
		else 
		{
			cout << height[lower] << " ";
		}

		if (upper == height.size())
		{
			cout << 'X' << "\n";
		}
		else 
		{
			cout << height[upper] << "\n";
		}
	}
	
}