// Тесты:
// 1. Ввел данные:
// 5 6
// 1 5 6
// 1 4 7
// 1 2 8
// 1 3 3
// 4 5 5
// 2 3 9
// 2
// 1 3.
// Получил на выходе: Столица: 1. Ее города: 5 4. Столица: 3. Ее города: 2.
// 2. Ввел данные:
// 3 3
// 1 2 5
// 1 3 3
// 2 3 8
// 2
// 1 3.
// Получил на выходе: Столица: 1. Ее города: 2. Столица: 3. Ее города: .
// 3. Ввел данные из файла input.txt.
// Получил на выходе: Столица: 2. Ее города: 9 3 1. Столица: 5. Ее города: 4. Столица: 7. Ее города: 6 8 10.

#include "road.h"
#include <iostream>
#include <fstream>

using namespace std;

const int maxDist = 999; // maximal distance between two cities

int main()
{
	int min = maxDist;
	int city1 = 0;
	int city2 = 0;
	int length[number][number];
	for (int i = 0; i < number; i++)
	{
		for (int j = 0; j < number; j++)
		{
			length[i][j] = 0;
		}
	}
	int currPos[number]; // current pointer to each country
	for (int i = 0; i < number; i++)
	{
		currPos[i] = 2;
	}
	int k = 0;
	int n = 0;
	int m = 0;
	int i1 = 0; // the intermidiate value
	int j1 = 0; // the intermediate value
	int g1 = 0; // the intermediate value
	int country[number][number];
	for (int i = 0; i < number; i++)
	{
		for (int j = 0; j < number; j++)
		{
			country[i][j] = 0;
		}
	}
	ifstream input("input.txt");
	if (!input)
	{
		cout << "The file doesn't exist." << endl;
		return 1;
	}
	input >> n >> m;
	for (int i = 1; i <= m; i++)
	{
		input >> city1 >> city2;
		input >> length[city1][city2];
		length[city2][city1] = length[city1][city2];
	}
	input >> k;
	for (int j = 1; j <= k; j++)
	{
		input >> country[j][1];
	}
	input.close();
	int i = 1;
	for (int d = 1; d <= n*n; d++)
	{
		for (int j = 1; j <= n; j++)
		{
			for (int g = 1; g <= n; g++)
			{
				if (isUsed(n, g, k, country) == true)
				{
					if ((length[g][country[i][j]] < min) && (length[g][country[i][j]] != 0))
					{
						min = length[g][country[i][j]];
						g1 = g;
						i1 = i;
						j1 = j;
					}
				}
			}
		}
		if ((g1 != 0) && (min == length[g1][country[i1][j1]]))
		{
			country[i1][currPos[i1]] = g1;
			currPos[i1]++;
		}
		i++;
		if (i >= (k + 1))
		{
			i = 1;
		}
		min = maxDist;
	}
	for (int f = 1; f <= k; f++)
	{
		cout << f << ". The capital is: " << country[f][1] << ". It's cities: ";
		for (int i = 2; i <= n; i++)
		{
			if (country[f][i] != 0)
			{
				cout << country[f][i] << " ";
			}
		}
		cout << endl;
	}
	return 0;
}
