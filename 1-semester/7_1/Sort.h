#pragma once
#include <string>

using namespace std;

struct List
{
	int phone;
	string name;
	List* next;
};

void printList(List *book);

void push(List*& book, std::string name, int number);

List* SortedMerge(List* first, List* last, int check);

void FrontBackSplit(List* book, List** front, List** back);

void MergeSort(List** mind, int variant);

void deleteList(List *book);
