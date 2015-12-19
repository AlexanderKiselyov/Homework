// Вводил такие данные:
// counter = 8; a[255]={5,6,0,2,1,7,4,7}. Программа выдала результат: 0 1 2 4 5 6 7 7.
// Если вводить больше чисел, чем counter, то программа все равно сортирует counter первых чисел.
// Если ввести меньше чисел, чем counter, то программа не заработает, пока не будут введены оставшиеся числа.
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

void qSort(int a[], int l, int r)
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

int main()
{
	int a[255] = {};
	int counter = 0; //количество элементов в массиве
	cout << "Write number of elements: ";
	cin >> counter;
	cout << "Write array: ";
	for (int i = 0; i < counter; i++)
	{
		cin >> a[i];
	}
	qSort(a, 0, counter - 1);
	cout << "The array has become: ";
	for (int i = 0; i < counter; i++)
	{
		cout << a[i] << " ";
	}
	return 0;
}
