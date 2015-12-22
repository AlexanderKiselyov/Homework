#pragma once

struct Node
{
	Node *left;
	Node *right;
	int value;
};

void add(int x, Node *&MyTree);
void deleteElement(Node *&tree, int element);
void IfInSet(int element, Node *&tree);
void Show(Node *&tree, int variant);
void deleteTree(Node *&Tree);
