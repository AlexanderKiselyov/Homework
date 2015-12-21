#pragma once
#include <iostream>

using namespace std;

struct Node
{
	string value;
	Node *left;
	Node *right;
};

void add(Node *&MyTree, string element); // adds elements to the tree
void Show(Node *&tree); // shows all the string
void translation(Node *&tree); // translates string symbols to integer symbols
string count(string operation, string first_number, string second_number); // makes operations
void deleteTree(Node *&Tree); // deletes tree after work
