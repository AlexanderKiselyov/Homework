// Для n=10 и k=10 получил строку massN: 1 7 4 0 9 4 8 8 2 4, а строку massK: 5 5 1 7 1 1 5 2 7 6. qSort отсортировал массив massN до: 0 1 2 4 4 4 7 8 8 9. Получил последовательность команд: No No Yes Yes Yes Yes No Yes Yes No.
#include <iostream>
#include <stdlib.h>

using namespace std;

void qSort(int massN[5000], int l, int r)
{
	int x = massN[l + (r - l) / 2];
	int i = l;
	int j = r;
	while (i <= j)
	{
		while (massN[i] < x)
		{
			i++;
		}
		while (massN[j] > x)
		{
			j--;
		}
		if (i <= j)
		{
			swap(massN[i], massN[j]);
			i++;
			j--;
		}
	}
	if (i < r)
	{
		qSort(massN, i, r);
	}
	if (l < j)
	{
		qSort(massN, l, j);
	}
}

int binarySearch(int massN[], int massK, int l, int r)
{
	int middle = 0;
	while (1)
	{
		middle = (l + r) / 2;
		if (massK < massN[middle])
		{
			r = middle - 1;
		}
		else if (massK > massN[middle])
		{
			l = middle + 1;
		}
		else
		{
			//cout << "Yes" << " ";
			return middle;
		}
		if (l > r)
		{
			//cout << "No" << " ";
			return -1;
		}
	}
}

int main()
{
	int n = 0;
	int k = 0;
	int massN[5000] = {}; // массив длины n с числами от 0 до 10^9
	int massK = 0; // k чисел от 0 до 10^9
	cout << "Write number of elements n: ";
	cin >> n;
	cout << "Write number of elements k: ";
	cin >> k;
	for (int i = 0; i < n; i++)
	{
		massN[i] = rand() % 10;
		//cout << massN[i] << " ";
	}
	//cout << endl;
	qSort(massN, 0, n - 1);
	/*for (int i = 0; i < n; i++)
	{
		cout << massN[i] << " ";
	}
	cout << endl;*/
	for (int i = 0; i < k; i++)
	{
		massK = rand() % 10;
		//cout << massK << " ";
		binarySearch(massN, massK, 0, n - 1);
	}
	return 0;
}
