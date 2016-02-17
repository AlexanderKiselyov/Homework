// Тесты (все взяты из файла input.txt):
// 1. Ввел строку tyj. Программа вывела: 19.
// 2. Ввел строку 1234. Программа вывела: 113.
// 3. Ввел строку string. Программа вывела: нет такой строки.

#include "KMP_algorithm.h"
#include <iostream>
#include <fstream>

using namespace std;

const int length = 512; // maximal length of string

int main()
{
	const int n = 10;
	char s[length];
	ifstream input("input.txt");
	if (!input)
	{
		cout << "The file doesn't exist." << endl;
		return 1;
	}
	while (!input.eof())
	{
		input.getline(s,512);
	}
	input.close();
	char q[256];
	for (int i = 0; i < strlen(s); i++)
	{
		cout << s[i];
	}
	cout << endl << endl;
	cout << "Write the string that you want to find:" << endl;
	cin.getline(q, 256);
	int a, mas[n] = { 0 };
	a = algorithmOfKMP(s, q);
	if (a == -1)
	{
		cout << endl << "There is no string in the basic text.\n";
	}
	else
	{
		cout << endl << "The string starts with the index " << a << " in the text." << endl;
	}
	return 0;
}
