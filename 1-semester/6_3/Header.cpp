#include "Header.h"
#include <iostream>

using namespace std;

void ListElement::add(int i) // adds warrior to the array and circles the array
{
	ListElement *list = new ListElement;
	list->next = head;
	list->value = i;
	if (head != NULL)
	{
		tail->next = list;
		tail = list;
	}
	else
	{
		head = tail = list;
	}
}

void ListElement::DeleteAndShow(int m, int n) // deletes every m-warrior and after some operations shows the last warrior
{
	int count = n;
	ListElement *list = tail;
	while (count != 1)
	{
		count--;
		for (int i = 1; i < m; i++)
		{
			list = list->next;
		}
		if (list->next == head)
		{
			ListElement *temp1 = nullptr;
			temp1 = list->next->next;
			delete list->next;
			list->next = temp1;
			head = list->next;
		}
		else
		{
			ListElement *temp1 = nullptr;
			temp1 = list->next->next;
			delete list->next;
			list->next = temp1;
		}
	}
	ListElement *temp = head;
	std::cout << "The last warrior is: " << temp->value << ".";
	delete temp;
}
