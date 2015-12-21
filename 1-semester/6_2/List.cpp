#include "List.h"

void List::Add(char x) // adds elements to the array
{
	static int Count = 0;
	List *temp = new List;
	Next = temp->Head;
	temp->val = x;
	if (Head != NULL)
	{
		Tail->Next = temp;
		Tail = temp;
	}
	else
	{
		Head = Tail = temp;
	}
	Count++;
	size = Count;
	Tail->Next = Head;
}

void List::Check() //checkes if the array is ordered
{
	for (int i = 0; i < size; i++)
	{
		List *temp = Head;
		while (temp != Tail)
		{
			while (temp->val > temp->Next->val)
			{
				char current;
				current = temp->val;
				temp->val = temp->Next->val;
				temp->Next->val = current;
			}
			temp = temp->Next;
		}
	}
}

void List::Show() // shows the current array
{
	//List *temp = Head;
	if (size == 0)
	{
		cout << "The array is empty.";
	}
	else
	{
		List *temp = Head;
		while (temp != Tail->Next)
		{
			cout << temp->val << " ";
			temp = temp->Next;
		}
	}
	cout << endl;
}

void List::DeleteElement(char deleteElement) // deletes the pointed element
{
	int counter = 0;
	List *temp = Head;
	while (temp != Tail->Next)
	{
		if (temp->val == deleteElement)
		{
			size--;
			if ((temp == Head) || (temp == Tail))
			{
				if (temp == Head)
				{
					Head = temp->Next;
					List *temp1 = Head;
					temp1 = temp->Next;
					delete temp;
					temp->Next = temp1;
				}
				if (temp == Tail)
				{
					temp = Head;
					for (int i = 0; i < counter - 1; i++)
					{
						temp = temp->Next;
					}
					Tail = temp;
					delete temp->Next;
				}
			}
			else
			{
				temp = Head;
				for (int i = 0; i < counter - 1; i++)
				{
					temp = temp->Next;
				}
				List *temp1 = Head;
				temp1 = temp->Next->Next;
				delete temp->Next;
				temp->Next = temp1;
			}
		}
		counter++;
		temp = temp->Next;
	}
}

void List::Del() // deletes the array after work
{
	List *temp = new List;
	int count = 0;
	while (temp != Tail)
	{
		temp = Head;
		Head = Head->Next;
		delete temp;
	}
}
