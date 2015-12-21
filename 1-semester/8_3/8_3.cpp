// Тесты:
// см. в приложениях в input.txt. Получается: 8.
// В проге подразумевается, что входная последовательность корректна,
// и прога умеет пользоваться только 4 операциями над числами.
// Также можно вывести все последовательность по порядку из дерева (только без скобок).
// Для этого надо раскомментировать 3 строки в main.

#include "Tree.h"
#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{
	string element;
	string result;
	Node *tree = nullptr;
	ifstream input("input.txt");
	if (!input)
	{
		cout << "The file doesn't exist." << endl;
		return 1;
	}
	cout << "The expression:" << endl;
	while (!input.eof())
	{
		input >> element;
		cout << element << " ";
		if ((element != "(") && (element != ")"))
		{
			add(tree, element);
		}
	}
	input.close();
	//cout << endl;
	//Show(tree);
	//cout << endl;
	while ((tree->value == "+") || (tree->value == "-") || (tree->value == "*") ||
		(tree->value == "/"))
	{
		translation(tree);
	}
	cout << "= ";
	result = tree->value;
	cout << result << endl;
	deleteTree(tree);
	return 0;
}
