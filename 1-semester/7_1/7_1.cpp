// Тесты:
// 1. Во входном файле хранились имена и телефоны:
// Alexander 12345
// Peter 485
// Dmitrij 174
// Vasilij 15811
// Gennadij 15.
// После сортировки по имени прога выдала результат:
// Alexander 12345
// Dmitrij 174
// Gennadij 15.
// Peter 485
// Vasilij 15811.
// После сортировки по номеру прога показала:
// Gennadij 15
// Dmitrij 174
// Peter 485
// Alexander 12345
// Vasilij 15811.
// 2. Если в файле одно имя и один телефон, то и после сортировки по имени,
// и после сортировки по номеру выводится это имя и номер.

#include <iostream>
#include <fstream>
#include "Sort.h"

using namespace std;

int main()
{
	List* book = nullptr;
	ifstream input("input.txt");
	if (!input)
	{
		cout << "The file doesn't exist." << endl;
		return 1;
	}
	while (!input.eof())
	{
		string name;
		int number = 0;
		input >> name >> number;
		push(book, name, number);
	}
	input.close();
	int command = -1;
	while (command != 0)
	{
		cout << "\nThe operations with the phonebook:" << endl;
		cout << "1. Sort by number." << endl;
		cout << "2. Sort by name." << endl;
		cout << "3. Show list." << endl;
		cout << "0. Exit." << endl << endl;
		cout << "Write the operation: ";
		cin >> command;
		if ((command != 1) && (command != 2) && (command != 3) && (command != 0))
		{
			cout << "Unknown command." << endl;
			continue;
		}
		else
		{
			if (command == 1)
			{
				MergeSort(&book, 2);
				continue;
			}
			if (command == 2)
			{
				MergeSort(&book, 1);
				continue;
			}
			if (command == 3)
			{
				cout << endl;
				printList(book);
				continue;
			}
		}
	}
	deleteList(book);
	return 0;
}
