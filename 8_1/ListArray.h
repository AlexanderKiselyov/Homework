#pragma once
#include <iostream>
#include <fstream>

using namespace std;

struct ListArray;
ListArray* createListArray(); // creates list
void addElementByValue(ListArray* list, int value); // adds elements
void fileToList(ifstream &input, ListArray* list); // writes file to the list
bool compare(ListArray* list1, int pointer1, ListArray* list2, int pointer2); // compares two list elements
int getListSize(ListArray* list); // returns list size
int getValue(ListArray* list, int pointer); // returns value
ListArray* divideList(ListArray* list, int startPosition, int finishPosition); // writes part of the list from startPosition to finishPosition
// and to a new list, then returns new list
int getNext(int pointer);
void deleteList(ListArray *list);
bool hasNext(ListArray* list, int pointer);
void printList(ListArray* list);
typedef ListArray* MyList; // --> typedef List* MyList;
MyList sort(MyList list);
