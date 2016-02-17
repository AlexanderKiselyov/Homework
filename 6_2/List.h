#pragma once
#include <iostream>

using namespace std;

struct List
{
	char val;
	int size = 0;
	List *Head;
	List *Tail;
	List *Next;
	void Add(char x); // adds elements to the array
	void Check(); //checkes if the array is ordered
	void Show(); // shows the current array
	void DeleteElement(char deleteElement); // deletes the pointed element
	void Del(); // deletes the array after work
};
