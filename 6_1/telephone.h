#pragma once
#include <string>

using namespace std;

struct ListElement
{
	ListElement *next;
};

struct List
{
	ListElement *head;
};

struct PhoneBookRecord
{
	string nameAndSurname;
	string telephone;
};
