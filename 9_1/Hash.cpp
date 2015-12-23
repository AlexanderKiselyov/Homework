#include "Hash.h"
#include <iostream>
#include <string>

void add(Hash *hash, string const &element)
{
	Hash *&head = hash->array[hashFunction(element)];
	push(head, element);
}

void push(Hash *&elem, string element)
{
	int flag = 0;
	Hash *&currentEl = elem;
	Hash *newElement = elem;
	while (newElement != nullptr)
	{
		if (newElement->value == element)
		{
			newElement->count = ++newElement->arrayCount[hashFunction(element)];
			flag = 1;
		}
		newElement = newElement->next;
	}
	newElement = new Hash;
	if ((currentEl == nullptr) && (flag == 0))
	{
		//newElement = elem;
		newElement->value = element;
		newElement->count = ++newElement->arrayCount[hashFunction(element)];
		newElement->next = nullptr;
		currentEl = newElement;
	}
	else
	{
		if (flag == 0)
		{
			//newElement = elem;
			newElement->value = element;
			newElement->count = ++newElement->arrayCount[hashFunction(element)];
			newElement->next = nullptr;
			currentEl->next = newElement;
		}
	}
}

void show(Hash *hash)
{
	cout << "The words and their counts: " << endl;
	for (int i = 0; i < amount; i++)
	{
		Hash *temp = hash->array[i];
		while (temp != nullptr)
		{
			cout << temp->value << " " << temp->count << " " << endl;
			temp = temp->next;
		}
	}
}

int hashFunction(string element)
{
	int symb = 0;
	for (int i = 0; i < element.length(); i++)
	{
		symb += element[i];
	}
	return symb % amount;
}

void Delete(Hash *hash)
{
	for (int i = 0; i < amount; i++)
	{
		Hash *temp = hash->array[i];
		while (temp != nullptr)
		{
			Hash *del = nullptr;
			del = temp->next;
			delete temp;
			temp = del;
		}
	}
}
