#include "Tree.h"
#include <iostream>

using namespace std;

void add(int x, Node *&MyTree)
{
	if (nullptr == MyTree)
	{
		MyTree = new Node;
		MyTree->value = x;
		MyTree->left = MyTree->right = nullptr;
	}
	else
	{
		if (x < MyTree->value)
		{
			if (MyTree->left != nullptr)
			{
				add(x, MyTree->left);
			}
			else
			{
				MyTree->left = new Node;
				MyTree->left->left = MyTree->left->right = nullptr;
				MyTree->left->value = x;
			}
		}
		else
		{
			if (x > MyTree->value)
			{
				if (MyTree->right != nullptr)
				{
					add(x, MyTree->right);
				}
				else
				{
					MyTree->right = new Node;
					MyTree->right->left = MyTree->right->right = nullptr;
					MyTree->right->value = x;
				}
			}
			else
			{
				cout << "The element has been added earlier." << endl;
			}
		}
	}
}

void deleteElement(Node *&tree, int element)
{
	if (tree == nullptr)
	{
		cout << "The element doesn't exist." << endl;
	}
	else
	{
		if (element == tree->value)
		{
			if ((tree->left != nullptr) && (tree->right != nullptr))
			{
				Node *temp = tree->right;
				Node *temp2 = temp;
				if ((temp->left == nullptr) && (temp->right == nullptr))
				{
					tree->value = temp->value;
					tree->right = nullptr;
				}
				else
				{
					if (temp->left == nullptr)
					{
						tree->value = temp->value;
						while (temp->right != nullptr)
						{
							temp2 = temp;
							temp = temp->right;
							temp2->value = temp->value;
						}
						temp2->right = nullptr;
					}
					else
					{
						while (temp->left != nullptr)
						{
							temp2 = temp;
							temp = temp->left;
						}
						tree->value = temp->value;
						temp2->left = nullptr;
					}
				}
				cout << "The element has been deleted." << endl;
			}
			else
			{
				if ((tree->left != nullptr) && (tree->right == nullptr))
				{
					tree = tree->left;
					cout << "The element has been deleted." << endl;
				}
				else
				{
					if ((tree->left == nullptr) && (tree->right != nullptr))
					{
						tree = tree->right;
						cout << "The element has been deleted." << endl;
					}
					else
					{
						tree = nullptr;
						cout << "The element has been deleted." << endl;
					}
				}
			}
		}
		else
		{
			if (element < tree->value)
			{
				if (tree->left != nullptr)
				{
					deleteElement(tree->left, element);
				}
				else
				{
					cout << "The element doesn't exist." << endl;
				}
			}
			else
			{
				if (tree->right != nullptr)
				{
					deleteElement(tree->right, element);
				}
				else
				{
					cout << "The element doesn't exist." << endl;
				}
			}
		}
	}
}

void IfInSet(int element, Node *&tree)
{
	if (tree != nullptr)
	{
		if (element == tree->value)
		{
			cout << "The element exists." << endl;
		}
		if (element < tree->value)
		{
			if (tree->left != nullptr)
			{
				IfInSet(element, tree->left);
			}
			else
			{
				cout << "The element doesn't exist." << endl;
			}
		}
		if (element > tree->value)
		{
			if (tree->right != nullptr)
			{
				IfInSet(element, tree->right);
			}
			else
			{
				cout << "The element doesn't exist." << endl;
			}
		}
	}
}

void Show(Node *&tree, int variant)
{
	if (variant == 1)
	{
		if (tree != nullptr)
		{
			Show(tree->left, variant);
			cout << tree->value << " ";
			Show(tree->right, variant);
		}
	}
	if (variant == 2)
	{
		if (tree != nullptr)
		{
			Show(tree->right, variant);
			cout << tree->value << " ";
			Show(tree->left, variant);
		}
	}
}

void deleteTree(Node *&Tree)
{
	if (Tree != nullptr)
	{
		deleteTree(Tree->left);
		deleteTree(Tree->right);
		delete Tree;
		Tree = nullptr;
	}

}
