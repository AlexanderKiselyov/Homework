// Вводил скобки из примеров, данных в задании. Выводит ответы "нет" и "да" соответственно.
// В тестах: (({)}) выводит "нет", ()()() выводит "да".

#include "brackets.h"
#include <iostream>
#include <fstream>

using namespace std;

const int k = 255; // maximal number of brackets

int main()
{
	char bracket[k];
	int number = 0;
	int flag = 0;
	int count = 0;
	Stack list;
	list.head = NULL;
	cout << "Write number of brackets: ";
	cin >> number;
	cout << "Write brackets: ";
	for (int i = 0; i < number; i++)
	{
		cin >> bracket[i];
	}
	for (int i = 0; i < number; i++)
	{
		if ((bracket[i] == '(') || (bracket[i] == '[') || (bracket[i] == '{'))
		{
			list.push(bracket[i]);
			count++;
		}
		else
		{
			if (bracket[i] == ')')
			{
				if (list.tail->value == '(')
				{
					list.pop(count);
					count--;
				}
				else
				{
					cout << "NO" << endl;
					flag = 1;
					break;
				}
			}
			if (bracket[i] == ']')
			{
				if (list.tail->value == '[')
				{
					list.pop(count);
					count--;
				}
				else
				{
					cout << "NO" << endl;
					flag = 1;
					break;
				}
			}
			if (bracket[i] == '}')
			{
				if (list.tail->value == '{')
				{
					list.pop(count);
					count--;
				}
				else
				{
					cout << "NO" << endl;
					flag = 1;
					break;
				}
			}
		}
	}
	if ((flag == 0) && (count == 0))
	{
		cout << "YES" << endl;
	}
	else
	{
		if (flag == 0)
		{
			cout << "NO" << endl;
		}
	}
	list.Del();
	return 0;
}
