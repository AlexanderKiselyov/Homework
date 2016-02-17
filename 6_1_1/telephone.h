#pragma once
#include <string>

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
	std::string nameAndSurname;
	std::string telephone;
};
