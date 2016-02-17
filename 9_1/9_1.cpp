// Тесты:
// Из входного файла input.txt (в приложениях) получил (первое - последовательность символов,
// второе - количество вхождений):
// 15 1
// werghrthtr 4
// werghrthtrwerghrthtr 1
// 78 1
// hfewioyiktrgr 1
// erbrt 2
// 123 2
// ergregwfd 1
// dvrtegrt 2
// regtrhtrhj 3

#include "Hash.h"
#include <iostream>
#include <fstream>

using namespace std;

int main()
{
	Hash *hash = new Hash;
	for (int i = 0; i < amount; i++)
	{
		hash->array[i] = nullptr;
	}
	string element;
	ifstream input("input.txt");
	if (!input)
	{
		cout << "The file doesn't exists." << endl;
		return 1;
	}
	while (!input.eof())
	{
		input >> element;
		int i = element.length();
		if ((element[i - 1] == '.') || (element[i - 1] == ',') ||
			(element[i - 1] == '?') || (element[i - 1] == '!') ||
			(element[i - 1] == ':') || (element[i - 1] == '(') ||
			(element[i - 1] == ')') || (element[i - 1] == '{') ||
			(element[i - 1] == '}') || (element[i - 1] == '[') ||
			(element[i - 1] == ']') || (element[i - 1] == ';'))
			// Not all specail symbols are included, but these are the most used.
		{
			string array;
			for (int j = 0; j < i - 1; j++)
			{
				array += element[j];
			}
			element = array;
		}
		if ((element[0] == '.') || (element[0] == ',') ||
			(element[0] == '?') || (element[0] == '!') ||
			(element[0] == ':') || (element[0] == '(') ||
			(element[0] == ')') || (element[0] == '{') ||
			(element[0] == '}') || (element[0] == '[') ||
			(element[0] == ']') || (element[0] == ';'))
			// Not all specail symbols are included, but these are the most used.
		{
			string array;
			for (int j = 1; j < i; j++)
			{
				array += element[j];
			}
			element = array;
		}
		add(hash, element);
	}
	input.close();
	show(hash);
	Delete(hash);
	return 0;
}
