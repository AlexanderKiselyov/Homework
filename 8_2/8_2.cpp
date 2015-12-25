// Тесты:
// 1. Завел числа в таком порядке:
// 11 7 14 3 9 1 5 8 10 0 2 4 6. Получил дерево значений в возрастающем порядке:
// 0 1 2 3 4 5 6 7 8 9 10 11 14 и наоборот в убывающем. Удалял вершины (4 варианта удаления):
// 1. (две дочерние вершины пусты): просто занудение вершины, например, удаляем 14.
// 2. (левая дочерняя вершина не пуста, правая пуста): переносим эту левую вершину выше на 1 уровень.
// 3. (правая дочерняя вершина не пуста, левая пуста): аналогично с 2 вариантом.
// 4. (обе вершины не пусты): переносим самую наименьшую (самую левую) дочернюю вершину из правых
// относительно рассматриваемой вершины вершин на место удаляемой.
// Далее можно проверить, есть ли значение в дереве. Для этого производим сравнения и выводим результат:
// если есть сопадение или его нет. Например: в исходном дереве вершина 7 будет, а вершина 12 - не будет
// выводиться.

#include "Tree.h"
#include <iostream>

using namespace std;

int main()
{
	int element = 0;
	int command = -1;
	Node *MyTree = nullptr;
	while (command != 0)
	{
		cout << "Write command: ";
		cin >> command;
		switch (command)
		{
		case 0:
		{
			cout << "Ending of the programm." << endl;
			break;
		}
		case 1:
		{
			cout << "Write element: ";
			cin >> element;
			add(element, MyTree);
			continue;
		}
		case 2:
		{
			cout << "Write element: ";
			cin >> element;
			deleteElement(MyTree, element);
			continue;
		}
		case 3:
		{
			cout << "Write element: ";
			cin >> element;
			IfInSet(element, MyTree);
			continue;
		}
		case 4:
		{
			int variant = 0;
			cout << "How do you want to see the elements?(1-in ascending order,2-in descending order)";
			cin >> variant;
			if (variant == 1)
			{
				Show(MyTree, 1);
			}
			else
			{
				if (variant == 2)
				{
					Show(MyTree, 2);
				}
				else
				{
					cout << "Unknown variant.";
				}
			}
			cout << endl;
			continue;
		}
		default:
		{
			cout << "Unknown command." << endl;
			continue;
		}
		}
	}
	deleteTree(MyTree);
	return 0;
}
