#include <iostream>

using namespace std;

int main()
{
	char s[255];
	char s1[255];
	int counter = 0;
	int num = 0;

	cout << "Enter the string s: ";
	cin >> s;
	cout << "Enter the string s1: ";
	cin >> s1;

	for (int i = 0; i < strlen(s); i++)
	{
		if (s[i] == s1[0])
		{
			for (int j = 0; i < strlen(s1) && (i+j) < strlen(s); j++)
			{
				if (s[i + j] == s[j])
				{
					counter++;
				}
				if (counter == strlen(s1))
				{
					num++;
					counter = 0;
				}
			}
			counter = 0;
		}
	}
	cout << "The number of occurrences is: ";
	cout << num;
	return 0;
}
