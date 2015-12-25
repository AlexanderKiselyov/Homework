#pragma once

struct ListElement
{
	int value;
	ListElement *next;
	ListElement *tail;
	ListElement *head;
	void add(int i); // adds warrior to the array and circles the array
	void DeleteAndShow(int m, int n); // deletes every m-warrior and after some operations shows the last warrior
};
