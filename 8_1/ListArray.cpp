#include "ListArray.h"
#include <iostream>
#include <vector>
#include <fstream>

using namespace std;

struct ListArray
{
	int first = 0;
	int last = 0;
	int size = 0;
	vector<int> key;
};

ListArray* createListArray()
{
	return new ListArray();
}

void addElementByValue(ListArray* list, int value)
{
	list->key.push_back(value);
	list->last++;
	list->size++;
}

void fileToList(ifstream &input, ListArray* list)
{
	while (!input.eof())
	{
		int value = 0;
		input >> value;
		addElementByValue(list, value);
	}
	input.close();
}

bool compare(ListArray* list1, int pointer1, ListArray* list2, int pointer2)
{
	return (list1->key[pointer1] > list2->key[pointer2]);
}

int getListSize(ListArray* list)
{
	return list->size;
}

int first(ListArray *list)
{
	return 0;
}

int getValue(ListArray* list, int pointer)
{
	return list->key[pointer];
}

ListArray* divideList(ListArray* list, int startPosition, int finishPosition)
{
	ListArray* newList = createListArray();
	int temp = 0;
	while (temp < list->size)
	{
		if (temp >= startPosition && temp <= finishPosition)
		{
			addElementByValue(newList, list->key[temp]);
		}
		temp++;
	}
	return newList;
}

int getNext(int pointer)
{
	return pointer + 1;
}

void deleteList(ListArray *list)
{
	delete list;
}

bool hasNext(ListArray* list, int pointer)
{
	return (pointer < list->size);
}

void printList(ListArray* list)
{
	cout << "Sorted elements: " << endl;
	for (int i = 0; i < list->size; ++i)
	{
		cout << list->key[i] << " ";
	}
	cout << endl;
}

typedef int ListElementType; // --> typedef ListElement* ListElementType;


typedef ListArray* MyList; // --> typedef List* MyList;



MyList merge(MyList leftList, MyList rightList)
{
	MyList list = createListArray(); // --> MyList list = createList();
	ListElementType leftTemp = first(leftList);
	ListElementType rightTemp = first(rightList);
	while (hasNext(leftList, leftTemp) && hasNext(rightList, rightTemp))
	{
		bool comparationResult = compare(leftList, leftTemp, rightList, rightTemp);
		if (!comparationResult)
		{
			addElementByValue(list, getValue(leftList, leftTemp));
			leftTemp = getNext(leftTemp);
		}
		else
		{
			addElementByValue(list, getValue(rightList, rightTemp));
			rightTemp = getNext(rightTemp);
		}
	}
	if (!hasNext(leftList, leftTemp))
	{
		while (hasNext(rightList, rightTemp))
		{
			addElementByValue(list, getValue(rightList, rightTemp));
			rightTemp = getNext(rightTemp);
		}
	}
	else if (!hasNext(rightList, rightTemp))
	{
		while (hasNext(leftList, leftTemp))
		{
			addElementByValue(list, getValue(leftList, leftTemp));
			leftTemp = getNext(leftTemp);
		}
	}
	deleteList(leftList);
	deleteList(rightList);
	return list;
}

MyList sort(MyList list)
{
	if (getListSize(list) <= 1)
	{
		return list;
	}
	MyList leftList = createListArray(); // --> MyList leftList = createList();
	leftList = divideList(list, 0, (getListSize(list) - 1) / 2);
	MyList rightList = createListArray(); // --> MyList rightList = createList();
	rightList = divideList(list, (getListSize(list) - 1) / 2 + 1, getListSize(list) - 1);
	leftList = sort(leftList);
	rightList = sort(rightList);
	list = merge(leftList, rightList);
	return list;
}
