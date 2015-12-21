#include "Tree.h"
#include <iostream>
#include <math.h>
#include <string>

using namespace std;

void add(Node *&tree, string x)
{
	if (tree == nullptr)
	{
		tree = new Node;
		tree->value = x;
		tree->left = tree->right = nullptr;
	}
	else
	{
		Node *temp = tree;
		Node *temp2 = temp;
		while ((temp->left != nullptr) && ((temp->left->value == "+") ||
			(temp->left->value == "-") || (temp->left->value == "*") ||
			(temp->left->value == "/")))
		{
			temp = temp->left;
		}
		if (temp->left == nullptr)
		{
			add(temp->left, x);
		}
		else
		{
			if ((temp->left->value == "0") || (temp->left->value == "1") ||
				(temp->left->value == "2") || (temp->left->value == "3") ||
				(temp->left->value == "4") || (temp->left->value == "5") ||
				(temp->left->value == "6") || (temp->left->value == "7") ||
				(temp->left->value == "8") || (temp->left->value == "9"))
			{
				if ((x == "+") || (x == "-") || (x == "*") || (x == "/"))
				{
					Node *temp3 = temp2;
					while (temp2->right == nullptr)
					{
						temp3 = temp2;
						temp2 = temp2->left;
					}
					add(temp3->right, x);
				}
				else
				{
					if (temp->right != nullptr)
					{
						Node *temp3 = temp2;
						while (temp2->right == nullptr)
						{
							temp3 = temp2;
							temp2 = temp2->left;
						}
						add(temp3->right, x);
					}
					else
					{
						add(temp->right, x);
					}
				}
			}
		}
	}
}

void Show(Node *&tree)
{
	if (tree != nullptr)
	{
		Show(tree->left);
		cout << tree->value << " ";
		Show(tree->right);
	}
}

void translation(Node *&tree)
{
	Node *temp = tree;
	while (((temp->left->value == "+") || (temp->left->value == "-") ||
		(temp->left->value == "*") || (temp->left->value == "/")) && (tree != nullptr))
	{
		temp = temp->left;
	}
	temp->value = count(temp->value, temp->left->value, temp->right->value);
	temp->left = temp->right = nullptr;
}

string count(string operation, string first_number, string second_number)
{
	int firstNumber = 0;
	int secondNumber = 0;
	int result = 0;
	int digit = 0;
	for (int i = first_number.length(); i > 0; i--)
	{
		digit = first_number[first_number.length() - i] - 48;
		firstNumber = firstNumber + pow(10, i - 1) * digit;
	}
	for (int j = second_number.length(); j > 0; j--)
	{
		digit = second_number[second_number.length() - j] - 48;
		secondNumber = secondNumber + pow(10, j - 1) * digit;
	}
	if (operation == "+")
	{
		result = firstNumber + secondNumber;
		int resultNew = result;
		int count = 1;
		while (resultNew >= 10)
		{
			resultNew /= 10;
			count++;
		}
		resultNew = result;
		char digitChr;
		string resultStr;
		for (int k = count; k > 0; k--)
		{
			resultNew = result;
			resultNew %= 10;
			digitChr = resultNew + 48;
			resultStr += digitChr;
			result = (result - resultNew) / 10;
		}
		return resultStr;
	}
	if (operation == "-")
	{
		result = firstNumber - secondNumber;
		int resultNew = result;
		int count = 1;
		while (resultNew >= 10)
		{
			resultNew /= 10;
			count++;
		}
		resultNew = result;
		char digitChr;
		string resultStr;
		for (int k = count; k > 0; k--)
		{
			resultNew = result;
			resultNew = resultNew % 10;
			digitChr = (resultNew + 48);
			resultStr += digitChr;
			result = (result - resultNew) / 10;
		}
		return resultStr;
	}
	if (operation == "*")
	{
		result = firstNumber * secondNumber;
		int resultNew = result;
		int count = 1;
		while (resultNew >= 10)
		{
			resultNew /= 10;
			count++;
		}
		resultNew = result;
		char digitChr;
		string resultStr;
		for (int k = count; k > 0; k--)
		{
			resultNew = result;
			resultNew %= 10;
			digitChr = resultNew + 48;
			resultStr += digitChr;
			result = (result - resultNew) / 10;
		}
		return resultStr;
	}
	if (operation == "/")
	{
		result = firstNumber / secondNumber;
		int resultNew = result;
		int count = 1;
		while (resultNew >= 10)
		{
			resultNew /= 10;
			count++;
		}
		resultNew = result;
		char digitChr;
		string resultStr;
		for (int k = count; k > 0; k--)
		{
			resultNew = result;
			resultNew %= 10;
			digitChr = resultNew + 48;
			resultStr += digitChr;
			result = (result - resultNew) / 10;
		}
		return resultStr;
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
