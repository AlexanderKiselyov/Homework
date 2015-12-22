// Из введенной последовательности: a b e g k (уже отсортирована), получена последовательность: a b h r путем выполнения команд:
// 2(g) , 2(k), 2(e), 1(h), 1(r).


#include "List.h"
#include <iostream>
#include <string>

using namespace std;

int main()
{
	List list;
	list.Head = NULL;
	char element; // the element you want to add
	string command = "1";
	char deleteElement; // the element you want to delete
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
			list.Add(element);
			list.Check();
			continue;
		}
		if (command == "2")
		{
			cout << "Write number that you want to delete: ";
			cin >> deleteElement;
			list.DeleteElement(deleteElement);
			continue;
		}
		if (command == "3")
		{
			list.Show();
			continue;
		}
		if ((command != "1") || (command != "2") || (command != "3"))
		{
			cout << "Unknown command.";
		}
		cout << endl;
	}
	list.Del();
	return 0;
}

