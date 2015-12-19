#include <iostream>

using namespace std;

int main()
{
	int k[38] = {};
	k[1] = 1;
	k[2] = 1;
	cout << k[1] << " " << k[2] << " ";
	for (int i = 3; i <= 37; i++)
	{
			k[i] = k[i - 1] + k[i - 2];
			cout << k[i] << " ";
	}
	return 0;
}
