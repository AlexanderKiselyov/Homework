#include <iostream>

using namespace std;

int a, b, k;

int main()
{
	cin >> a >> b;
	if (b == 0)
	{
		cout << "Mistake";
	}
	else
	{
		if ((a >= 0) && (b > 0))
		{
			while (a - b >= 0)
			{
				a = a - b;
				k = k + 1;
			}
		}
		if ((a < 0) && (b < 0))
		{
			while (a - b <= 0)
			{
				a = a - b;
				k = k + 1;
			}
		}
		if ((a > 0) && (b < 0))
		{
			while (a + b >= 0)
			{
				a = a + b;
				k = k - 1;
			}
		}
		if ((a < 0) && (b > 0))
		{
			while (a + b <= 0)
			{
				a = a + b;
				k = k - 1;
			}
		}
		cout << k;
	}
	return 0;
}
