#include "Counter.h"
#include <iostream>

void Stack::push(int value) // adds elements to the stack
{
	Stack *addEl = new Stack;
	next = addEl->head;
	addEl->value = value;
	if (head != NULL)
	{
		tail->next = addEl;
		tail = addEl;
	}
	else
	{
		head = tail = addEl;
	}
}

void Stack::pop() // deletes the top elements from the array
{
	int count = 0;
	Stack *temp = head;
	while (temp != tail)
	{
		temp = temp->next;
		count++;
	}
	delete temp;
	temp = head;
	for (int i = 1; i < count;i++)
	{
		temp = temp->next;
	}
	tail = temp;
}
