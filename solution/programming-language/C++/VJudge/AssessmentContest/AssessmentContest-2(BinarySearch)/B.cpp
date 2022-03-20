#define _CRT_SECURE_NO_WARNINGS
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

	int T;
	scanf("%d", &T);

	

	for (int i = 1; i <= T; i++)
	{
		int n, q;
		scanf("%d", &n);
		scanf("%d", &q);

		vector<int> points;
		for (int j = 1; j <= n; j++)
		{
			int value;
			scanf("%d", &value);
			points.push_back(value);
		}

		printf("Case %d:\n", i);
		for (int j = 1; j <= q; j++)
		{
			int A, B;
			scanf("%d", &A);
			scanf("%d", &B);

			int countValues = upperBound(points, B) - lowerBound(points, A);

			cout << countValues << "\n";
		}
		
		points.clear();

	}
}