#include <iostream>

using namespace std;

int num, i, j, d;

int main()
{
	d = 0;
	cin >> num;
	for (i = 2; i <= num; ++i)
	{
		for (j = 2; j < i / 2; ++j)
		{
			if ((i % j) == 0)
			{
				++d;
			}
		}
		if (d == 0)
		{
			cout << i << ' ';
		}
		d = 0;
	}
}
