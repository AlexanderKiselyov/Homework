#include "Sort.h"
#include <iostream>
#include <string>

using namespace std;

void printList(List *book)
{
	int i = 1;
	while (book != NULL)
	{
		cout << i << ". Name: " << book->name << ", number: " << book->phone << "." << endl;
		i++;
		book = book->next;
	}
}

void push(List*& book, string name, int number)
{
	List *newElement = new List;
	newElement->phone = number;
	newElement->name = name;
	newElement->next = book;
	book = newElement;
}

List* SortedMerge(List* first, List* last, int check)
{
	List* result = NULL;
	if (first == NULL)
	{
		return last;
	}
	else
	{
		if (last == NULL)
		{
			return first;
		}
	}
	if (check == 1)
	{
		if (first->name <= last->name)
		{
			result = first;
			result->next = SortedMerge(first->next, last, 1);
		}
		else
		{
			result = last;
			result->next = SortedMerge(first, last->next, 1);
		}
	}
	else
	{
		if (first->phone <= last->phone)
		{
			result = first;
			result->next = SortedMerge(first->next, last, 2);
		}
		else
		{
			result = last;
			result->next = SortedMerge(first, last->next, 2);
		}
	}
	return result;
}

void FrontBackSplit(List* book, List** front, List** back)
{
	List* first;
	List* second;
	if (book == NULL || book->next == NULL)
	{
		*front = book;
		*back = NULL;
	}
	else
	{
		first = book;
		second = book->next;
		while (second != NULL)
		{
			second = second->next;
			if (second != NULL)
			{
				first = first->next;
				second = second->next;
			}
		}
		*front = book;
		*back = first->next;
		first->next = NULL;
	}
}



void MergeSort(List** mind, int variant)
{
	List* head = *mind;
	List* a;
	List* b;
	if ((head == NULL) || (head->next == NULL))
	{
		return;
	}
	FrontBackSplit(head, &a, &b);
	MergeSort(&a, variant);
	MergeSort(&b, variant);
	*mind = SortedMerge(a, b, variant);
}

void deleteList(List *book)
{
	while (book != NULL)
	{
		List *temp = book->next;
		delete book;
		book = temp;
	}
}
