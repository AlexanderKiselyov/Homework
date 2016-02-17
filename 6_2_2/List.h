#pragma once
#include <iostream>

struct ListElement
{
	char value;
	ListElement *next;
	ListElement *prev;
};

struct List
{
	ListElement *head;
	ListElement *tail;
};

void add(List *list, char x); // adds elements to the array
void show(int counter, List *list); // shows the current array
int deleteElement(char deleteElement, int counter, List *list); // deletes the pointed element
void del(List *list, int counter); // deletes the array after work
