// Тесты:
// 1. Вводил n=10, m=2. Выводит: 5.
// 2. Вводил n=9, m=5. Выводит: 8.
// 3. Вводил n=4, m=1. Выводит: 4.

#include <iostream>
#include "Header.h"

using namespace std;

int main()
{
	int n = 0;
	int m = 0;
	ListElement List;
	List.head = NULL;
	cout << "Write number of warriors and the position of each killed warrior: ";
	cin >> n >> m;
	for (int i = 1; i <= n; i++)
	{
		List.add(i);
	}
	List.DeleteAndShow(m, n);
	cout << endl;
	return 0;
}
