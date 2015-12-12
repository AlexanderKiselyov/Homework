#include <iostream>

using namespace std;


int main()
{
	int counter = 0;
	int len = 0;
	char str[255] = {};
	cout << ("Vvedite stroky: ");
	cin >> str;
	len = strlen(str);
	for (int i = 0; i < len; i++)
	{
		if (str[i] == '0')
		{
			++counter;
		}
	}
	cout << counter;
}
