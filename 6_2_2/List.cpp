#include "List.h"

void add(List *list, char x) // adds elements to the array
{
	if (list->head == nullptr)
	{
		ListElement *newElement = new ListElement;
		newElement->value = x;
		list->tail = newElement;
		list->head = newElement;
	}
	else
	{
		ListElement *newElement = new ListElement;
		ListElement *element = list->tail;
		newElement->value = x;
		if (newElement->value < list->head->value)
		{
			newElement->next = list->head;
			list->head->prev = newElement;
			list->head = newElement;
		}
		else
		{
			if (newElement->value >= list->tail->value)
			{
				list->tail->next = newElement;
				newElement->prev = list->tail;
				list->tail = newElement;
			}
			else
			{
				while (newElement->value < element->value)
				{
					element = element->prev;
				}
				ListElement *temp = element->next;
				element->next = newElement;
				newElement->prev = element;
				temp->prev = newElement;
				newElement->next = temp;
			}
		}
	}
}

void show(int counter, List *list) // shows the current array
{
	if (counter == 0)
	{
		std::cout << "The array is empty.";
	}
	else
	{
		ListElement *temp = list->head;
		while (temp != list->tail)
		{
			std::cout << temp->value << " ";
			temp = temp->next;
		}
		std::cout << temp->value << " ";
	}
	std::cout << std::endl;
}

int deleteElement(char deleteElement, int counter, List *list) // deletes the pointed element
{
	if (counter == 0)
	{
		std::cout << "The array is empty." << std::endl;
		return 0;
	}
	else
	{
		if (counter == 1)
		{
			if (list->head->value == deleteElement)
			{
				delete list->head;
				list->head = nullptr;
				return 1;
			}
			else
			{
				std::cout << "There is no this value here." << std::endl;
				return 0;
			}
		}
		else
		{
			if ((deleteElement < list->head->value) || (deleteElement > list->tail->value))
			{
				std::cout << "There is no this value here." << std::endl;
				return 0;
			}
			else
			{
				ListElement *temp = list->head;
				if (deleteElement == list->head->value)
				{
					list->head = list->head->next;
					delete list->head->prev;
					return 1;
				}
				else
				{
					if (deleteElement == list->tail->value)
					{
						list->tail = list->tail->prev;
						delete list->tail->next;
						return 1;
					}
					else
					{
						while (deleteElement > temp->value)
						{
							temp = temp->next;
						}
						if (temp->value == deleteElement)
						{
							ListElement *temp2 = temp;
							ListElement *temp1 = temp->next;
							temp->prev->next = temp1;
							temp1->prev = temp2->prev;
							delete temp2;
							return 1;
						}
						else
						{
							std::cout << "There is no this value here." << std::endl;
							return 0;
						}
					}
				}
			}
		}
	}
}

void del(List *list, int counter) // deletes the array after work
{
	ListElement *temp = list->head;
	if (counter == 0)
	{
		return;
	}
	else
	{
		while (temp != list->tail)
		{
			ListElement *temp1 = temp->next;
			delete temp;
			temp = temp1;
		}
		delete temp;
	}
}
