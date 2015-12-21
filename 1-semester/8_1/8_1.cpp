// Тесты:
// Тест находится в файле input.txt.
// Чтобы изменить реализацию с указателей на массив, нужно заменить несколько строчек
// в ListArray.h, ListArray.cpp, Source.cpp и List.h (эти изменения отмечены знаком "-->").
// Всего 7 строк надо поменять.

#include "List.h"
#include "ListArray.h"
#include <iostream>
#include <fstream>

using namespace std;

int main()
{
	MyList list = createListArray(); // --> MyList list = createList(); 
	ifstream input("input.txt");
	if (!input)
	{
		cout << "The file doesn't exist." << endl;
		return 1;
	}
	fileToList(input, list);
	input.close();
	list = sort(list);
	printList(list);
	deleteList(list);
	return 0;
}
