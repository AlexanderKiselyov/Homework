// Тесты:
// 1. 125 --> Yes (1 case).
// 2. 58484.15747 --> Yes (3 case).
// 3. 51874E187 --> Yes (3 case).
// 4. 744716.E --> No (7 case).
// 5. 3254.E43443 --> Yes (8 case).
// 6. 54354546546.E+345465464 --> Yes (5 case).
// 7. 3546546g --> No (2 case).
// 8. 435654.t34654 --> No (4 case).
// 9. 235446546.45465E+454g4354 --> No (6 case).
// 10. 5435464.45589821E543534+3544443u --> No (9 case).

#include <iostream>
#include <string>

using namespace std;

int main()
{
	int state = 0;
	int i = 0; //current position of symbol
	string str;
	cout << "Write string of symbols: ";
	cin >> str;
	switch (state)
	{
	case 0:
	{
		while (((str[i] == '0') || (str[i] == '1') || (str[i] == '2') || (str[i] == '3') ||
			(str[i] == '4') || (str[i] == '5') || (str[i] == '6') || (str[i] == '7') ||
			(str[i] == '8') || (str[i] == '9')) && (i < str.length()))
		{
			i++;
		}
		if (i == str.length())
		{
			cout << "The string is a real number. (1)" << endl;
			break;
		}
		if (str[i] == '.')
		{
			i++;
			state = 1;
		}
		else
		{
			if (str[i] == 'E')
			{
				i++;
				state = 2;
			}
			else
			{
				cout << "The string isn't a real number. (2)" << endl;
				break;
			}
		}
	}
	case 1:
	{
		while (((str[i] == '0') || (str[i] == '1') || (str[i] == '2') || (str[i] == '3') ||
			(str[i] == '4') || (str[i] == '5') || (str[i] == '6') || (str[i] == '7') ||
			(str[i] == '8') || (str[i] == '9')) && (i < str.length()))
		{
			i++;
		}
		if (str[i] == 'E')
		{
			i++;
			state = 2;
		}
		else
		{
			if (i == str.length())
			{
				cout << "The string is a real number. (3)" << endl;
				break;
			}
			else
			{
				cout << "The string isn't a real number. (4)" << endl;
				break;
			}
		}
	}
	case 2:
	{
		if ((str[i] == '+') || (str[i] == '-'))
		{
			i++;
			while (((str[i] == '0') || (str[i] == '1') || (str[i] == '2') || (str[i] == '3') ||
				(str[i] == '4') || (str[i] == '5') || (str[i] == '6') || (str[i] == '7') ||
				(str[i] == '8') || (str[i] == '9')) && (i < str.length()))
			{
				i++;
			}
			if (i == str.length())
			{
				cout << "The string is a real number. (5)" << endl;
				break;
			}
			else
			{
				cout << "The string isn't a real number. (6)" << endl;
				break;
			}
		}
		if (i == str.length())
		{
			cout << "The string isn't a real number. (7)" << endl;
			break;
		}
		else
		{
			while (((str[i] == '0') || (str[i] == '1') || (str[i] == '2') || (str[i] == '3') ||
				(str[i] == '4') || (str[i] == '5') || (str[i] == '6') || (str[i] == '7') ||
				(str[i] == '8') || (str[i] == '9')) && (i < str.length()))
			{
				i++;
			}
			if (i == str.length())
			{
				cout << "The string is a real number. (8)" << endl;
				break;
			}
			else
			{
				cout << "The string isn't a real number. (9)" << endl;
				break;
			}
		}
	}
	}
	return 0;
}
