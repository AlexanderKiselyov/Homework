#include <iostream>
#include <stdlib.h>

using namespace std;

int const number = 20;

int main()
{
	int mass[255] = {};
	for (int i = 0; i < number; i++)
	{
		mass[i] = rand() % 10;
	}
	for (int i = 0; i < number; i++)
	{
		cout << mass[i] << " ";
	}
	cout << endl;
	swap(mass[0], mass[number / 2 - 1]);
	int firstNumber = mass[number / 2 - 1];
	int i = 0;
	int j = number - 1;
	while (i <= j)
	{
		while (mass[i] < firstNumber)
		{
			i++;
		}
		while (mass[j] > firstNumber)
		{
			j--;
		}
		if (i <= j)
		{
			swap(mass[i], mass[j]);
			i++;
			j--;
		}
	}
	for (int i = 0; i < number; i++)
	{
		cout << mass[i] << " ";
	}
	return 0;
}
