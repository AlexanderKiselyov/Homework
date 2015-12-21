#include "brackets.h"
#include <iostream>

void Stack::push(char value) // pushes an open bracket into the stack
{
	Stack *list = new Stack;
	next = list->head;
	list->value = value;
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

void Stack::pop(int count) // deletes the open bracket from the stack
{
	Stack *list = head;
	for (int i = 0; i < count - 2; i++)
	{
		list = list->next;
	}
	tail->next = list;
	tail = list;
}

void Stack::Del() // deletes the stack after work
{
	Stack *temp = new Stack;
	while (temp != tail)
	{
		temp = head;
		head = head->next;
		delete temp;
	}
}
