#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{
	int aComment = 0; // 'a' is a changing element in the table
	char element;
	int mass[5][3]; // The first column - status, the second - where to go if the symbol is '/',
	// the last - where to go if the symbol is '*'.
	mass[0][0] = mass[1][1] = mass[0][2] = mass[2][1] = mass[4][2] =
		mass[4][1] = mass[3][2] = 0;
	mass[1][0] = mass[0][1] = 1;
	mass[2][0] = mass[1][2] = 2;
	mass[3][0] = mass[2][2] = 3;
	mass[4][0] = mass[3][1] = 4;
	ifstream input("input.txt");
	if (!input)
	{
		cout << "The file does't exist." << endl;
		return 1;
	}
	string comment;
	cout << "All comments:" << endl;
	while (!input.eof())
	{
		input >> element;
		if ((element == '/') && (aComment == 0))
		{
			aComment = mass[0][1];
			comment = '/';
			continue;
		}
		if ((element == '*') && (aComment == 1))
		{
			aComment = mass[1][2];
			comment += '*';
			continue;
		}
		if (((aComment == mass[1][2]) && (element != '*')) || (input.eof()))
		{
			comment += element;
			continue;
		}
		if ((element == '*') && (aComment == 2))
		{
			comment += '*';
			aComment = mass[2][2];
			continue;
		}
		if ((element == '/') && (aComment == 3))
		{
			cout << comment << '/' << endl;
			aComment = mass[0][0];
			continue;
		}
	}
	input.close();
	return 0;
}
