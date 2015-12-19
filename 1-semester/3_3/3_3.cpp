// Провел тесты:
// 1. Со значением counter = 10 и строкой: 5 2 6 8 9 1 5 5 2 6, получил в ответе: 3.
// 2. Со значением counter = 5 и строкой: 7 7 7 7 7, получил в ответе: 5.
// 3. Со значением counter = 5 и строкой: 5 4 3 2 1, получил в ответе: 1.

#include "insertAndQSort.h"
#include <iostream>
#include <fstream>

using namespace std;

int main()
{
	ifstream input("input.txt");
	if (!input)
	{
		printf("file not found\n");
		return 1;
	}
	int a[255] = {};
	int counter = 0; //количество элементов в массиве
	int max = 0; // максимальное количество одинаковых элементов в последователньости
	int currentMax = 0; // текущее количество элементов одного вида
	input >> counter;
	for (int i = 0; i < counter; i++)
	{
		input >> a[i];
	}
	input.close();
	qSort(a, 0, counter - 1);
	int i = 0;
	int j = 0;
	while ((i < counter) && (j < counter)) // подсчет максимального количества одинаковых элементов в последователньости
	{
		while (a[i] == a[j])
		{
			currentMax++;
			i++;
		}
		j = i;
		if (currentMax > max)
		{
			max = currentMax;
		}
		currentMax = 0;
	}
	cout << "Maximal number of the same elements: " << max << endl;
	return 0;
}
