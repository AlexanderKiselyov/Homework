// Из введенной последовательности: a b e g k (уже отсортирована), получена последовательность: a b h r путем выполнения команд:
// 2(g) , 2(k), 2(e), 1(h), 1(r).


#include "List.h"
#include <iostream>
#include <string>

using namespace std;

int main()
{
	List *list = new List;
	list->head = nullptr;
	list->tail = list->head;
	int counter = 0;
	char element; // the element you want to add
	string command = "1";
	char deletedElement; // the element you want to delete
	while (command != "0")
	{
		cout << "Write a command: ";
		cin >> command;
		if (command == "0")
		{
			cout << "Ending of the programm..." << endl;
			break;
		}
		if (command == "1")
		{
			cout << "Write number that you want to add: ";
			cin >> element;
			add(list, element);
			counter++;
			continue;
		}
		if (command == "2")
		{
			cout << "Write number that you want to delete: ";
			cin >> deletedElement;
			if (deleteElement(deletedElement, counter, list) == 1)
			{
				counter--;
			}
			continue;
		}
		if (command == "3")
		{
			show(counter, list);
			continue;
		}
		if ((command != "1") || (command != "2") || (command != "3"))
		{
			cout << "Unknown command.";
		}
		cout << endl;
	}
	del(list, counter);
	return 0;
}

