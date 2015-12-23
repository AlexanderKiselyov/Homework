// Тесты:
// 1. Для матрицы смежности:
// 0 1 1 1
// 1 0 1 1
// 1 1 0 1
// 1 1 1 0
// получил ответ: 3.
// 2. Для матрицы смежности:
// 0 10 0 11
// 10 0 9 5
// 0 9 0 8
// 11 5 8 0
// получил ответ: 23.
// 3. Для матрицы из файла input.txt:
// получил ответ: 21.

#include <iostream>
#include <fstream>

using namespace std;

int main()
{
	int vertex1;
	int vertex2;
	int u; // visited vertex
	int v; // visited vertex
	int i; // counter
	int j; // counter
	int number = 0;
	int ne = 1;
	int visited[10] = { 0 };
	int min = 0;
	int mincost = 0;
	int cost[10][10];
	int path[100] = { 0 };
	int path_index = 0;
	ifstream input("input.txt");
	if (!input)
	{
		cout << "The file doesn't exist." << endl;
		return 1;
	}
	input >> number;
	for (i = 1; i <= number; i++)
	{
		for (j = 1; j <= number; j++)
		{
			input >> cost[i][j];
			if (cost[i][j] == 0)
			{
				cost[i][j] = 999;
			}
		}
	}
	visited[1] = 1;
	while (ne < number)
	{
		for (i = 1, min = 999; i <= number; i++) // min - maximal weight of the edge
		{
			for (j = 1; j <= number; j++)
			{
				if (cost[i][j] < min)
				{
					if (visited[i] != 0)
					{
						min = cost[i][j];
						vertex1 = u = i;
						vertex2 = v = j;
					}
				}
			}
		}
		if (visited[u] == 0 || visited[v] == 0)
		{
			path[path_index] = vertex2;
			path_index++;
			ne++;
			mincost += min;
			visited[vertex2] = 1;

		}
		cost[vertex1][vertex2] = cost[vertex2][vertex1] = 999;
	}
	cout << 1 << " --> ";
	for (int i = 0; i < (number - 1); i++)
	{
		cout << path[i];
		if (i < (number - 2))
		{
			cout << " --> ";
		}
	}
	cout << "\nThe minimal way is: " << mincost << endl;
	return 0;
}
