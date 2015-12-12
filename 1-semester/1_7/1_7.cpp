#include <iostream>

using namespace std;

int main()
{
	char str[255] = {};
	int counter = 0;
	cout << "Vvedite stroky: ";
	cin >> str;
	for (int i = 0; i < strlen(str); i++)
	{
		if (counter >= 0)
		{
			if (str[i] == '(')
			{
				counter++;
			}
			if (str[i] == ')')
			{
				counter--;
			}
		}
		else
		{
			cout << "Balans skobok narushen";
			break;
		}
	}
	if (counter < 0)
	{
		cout << "Balans skobok narushen";
	}
	if (counter == 0)
	{
		cout << "Balans skobok ne narushen";
	}
	if (counter > 0)
	{
		cout << "Balans skobok narushen";
	}
	return 0;
}
