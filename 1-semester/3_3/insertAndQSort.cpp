#include "insertAndQSort.h"
#include <iostream>
#include <algorithm>

using namespace std;

void insert(int a[], int i, int j) // сортировка вставкой
{
	for (int p = i; p < j + 1; p++)
	{
		for (int k = p; k > 0; k--)
		{
			if (a[k] < a[k - 1])
			{
				swap(a[k], a[k - 1]);
			}
			else break;
		}
	}
}

void qSort(int a[], int l, int r) // сортировка QSort
{
	int x = a[l + (r - l) / 2];
	if (r > 0)
	{
		int x1 = a[0];
		x = max(x, x1);
	}
	int i = l;
	int j = r;
	if (r - l < 10)
	{
		insert(a, i, j);
	}
	else
	{
		while (i < j)
		{
			while (a[i] < x)
			{
				i++;
			}
			while (a[j] > x)
			{
				j--;
			}
			if (i <= j)
			{
				swap(a[i], a[j]);
				i++;
				j--;
			}
		}
		if (i < r)
		{
			qSort(a, i, r);
		}
		if (l < j)
		{
			qSort(a, l, j);
		}
	}
}
