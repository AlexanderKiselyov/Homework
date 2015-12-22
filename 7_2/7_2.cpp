// Тесты: 
// 1. Ввел последовательность: 9 6 - 1 2 + *. Получил: 9.
// 2. Ввел последовательность: 4 5 * 7 1 - +. Получил: 26.
// 3. Ввел последовательность: 4 9 * 8 2 / /. Получил: 9.

#include "Counter.h"
#include <iostream>

using namespace std;

int main()
{
	int elementFirst = 0;
	int elementSecond = 0;
	char element;
	int count = 0;
	std::cout << "Write number of operations and operands: ";
	cin >> count;
	std::cout << "Write array of elements: ";
	Stack stackNew;
	stackNew.head = NULL;
	for (int i = 0; i < count; i++)
	{
		cin >> element;
		if ((element != '+') && (element != '-') && (element != '*') && (element != '/'))
		{
			stackNew.push(element - 48);
		}
		if (element == '+')
		{
			elementFirst = stackNew.tail->value;
			stackNew.pop();
			elementSecond = stackNew.tail->value;
			stackNew.pop();
			stackNew.push(elementFirst + elementSecond);
		}
		if (element == '-')
		{
			elementFirst = stackNew.tail->value;
			stackNew.pop();
			elementSecond = stackNew.tail->value;
			stackNew.pop();
			stackNew.push(elementSecond - elementFirst);
		}
		if (element == '*')
		{
			elementFirst = stackNew.tail->value;
			stackNew.pop();
			elementSecond = stackNew.tail->value;
			stackNew.pop();
			stackNew.push(elementFirst * elementSecond);
		}
		if (element == '/')
		{
			elementFirst = stackNew.tail->value;
			stackNew.pop();
			elementSecond = stackNew.tail->value;
			stackNew.pop();
			stackNew.push(elementSecond / elementFirst);
		}
	}
	std::cout << "The result is: " << stackNew.tail->value << endl;
	delete stackNew.tail;
	return 0;
}
