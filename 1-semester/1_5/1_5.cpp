#include <iostream>
#include <math.h>

using namespace std;

const int m = 7, n = 3;
char s[m+n],c;
int i;

int main()
{
	cin >> s;
	for (i = 0; i <= (floor((m-1) / 2)); i++)
	{
		c = s[i];
		s[i] = s[m - 1 - i];
		s[m - 1 - i] = c;
	}
		for (i = m; i <= (m + floor((n-1) / 2)); i++)
		{
			c = s[i];
			s[i] = s[2*m + n - 1 - i];
			s[2*m + n - 1 - i] = c;
		}
			for (i = 0; i <= (floor((m + n - 1) / 2)); i++)
			{
				c = s[i];
				s[i] = s[m + n - 1 - i];
				s[m + n - 1 - i] = c;
			}
			for (i = 0; i <= m + n - 1; i++)
			{
				cout << s[i];
			}
return 0;
}
