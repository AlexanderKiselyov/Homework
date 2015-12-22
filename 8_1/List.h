#pragma once
#include <fstream> 
#include <string>

using namespace std;

struct ListElement;
struct List;

List* createList();
void addElementByValue(List *list, int value);
bool compare(List* list1, ListElement *listElement1, List *list2, ListElement *listElement2);
int getListSize(List *list);
ListElement* first(List *list);
int getValue(List* list, ListElement *listElement);
ListElement* getNext(ListElement *listElement);
void fileToList(ifstream &file, List *list);
void printList(List *list);
List* divideList(List *list, int startPosition, int finishPosition);
void deleteList(List *list);
bool hasNext(List* list, ListElement* listElement);
