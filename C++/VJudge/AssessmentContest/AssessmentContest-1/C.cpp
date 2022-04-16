#include<bits/stdc++.h>
using namespace std;


int main()
{
    int n;
    cin >> n;
    int number;
    
    vector<int> A;

    for (int i = 0; i < n; i++)
    {
        cin >> number;
        A.push_back(number);
    }

    sort(A.begin(), A.end());

    int subtractedNumber = 0;
    double result = 0;
    bool flag = false;


    for (int i = n - 1; i >= 0; i--)
    {
        for (int j = 0; j < n; j++)
        {
            if (j <= i)
            {
                subtractedNumber = A[i] - A[j];

                for (int z = 0; z < n; z++)
                {
                    if (z != i && z != j)
                    {
                        result = subtractedNumber % A[z];

                        if (result != 0) 
                        {
                            flag = true;
                        }
                    }
                }
            }
        }
    }

    if (flag)
    {
        cout << "no" << endl;
    }
    else
    {
        cout << "yes" << endl;
    }

    return 0;
}
