// Тесты:
// 1. Ввел формулу: (1+1)*2=. Получил на выход: 11+2*;
// 2. Ввел формулу: (1+3)/2+(8-6)*3=. Получил на выход: 13+2/86-3*+;
// 3. Ввел формулу: (1+2)*4+3=. Получил на выход: 12+4*3+;

#include "translation.h"
#include <iostream>

using namespace std;

bool isNumber(char symbol);
bool isBracket(char symbol);
bool isStronger(char symbol, char taken);

int main()
{
	Stack *operationsStack = createStack();
	cout << "Enter the infix-formula with symbol '=' at the end: ";
	char symbol = ' ';
	scanf("%c", &symbol);
	while (symbol != '=')
	{
		if (isNumber(symbol))
		{
			printf("%c", symbol);
		}
		else
			if (isEmpty(operationsStack))
			{
				push(operationsStack, symbol);
			}
		else if (isBracket(symbol))
		{
			if (symbol == '(')
			{
				push(operationsStack, symbol);
			}
			if (symbol == ')')
			{
				char taken = pop(operationsStack);
				while (taken != '(')
				{
					printf("%c", taken);
					taken = pop(operationsStack);
				}
			}
		}
		else
		{
			char taken = pop(operationsStack);
			if ((taken == '(') || (isStronger(symbol, taken)))
			{
				push(operationsStack, taken);
				push(operationsStack, symbol);
			}
			else
			{
				if ((isEmpty(operationsStack)) && (isStronger(taken, symbol)))
				{
					printf("%c", taken);
				}
				while ((!isEmpty(operationsStack)) && (taken != '('))
				{
					printf("%c", taken);
					taken = pop(operationsStack);
				}
				if (taken == '(')
				{
					push(operationsStack, taken);
				}
				push(operationsStack, symbol);
			}
		}
		scanf ("%c",&symbol);
	}
	printStack(operationsStack);
	return 0;
}

bool isNumber(char symbol)
{
	return ((symbol - '0' >= 0) && (symbol - '0' <= 9));
}

bool isBracket(char symbol)
{
	return ((symbol == '(') || (symbol == ')'));
}

bool isStronger(char symbol, char taken)
{
	if ((symbol == '*') || (symbol == '/'))
		return true;
	else if (((symbol == '+') || (symbol == '-')) && ((taken == '+') || (taken == '-')))
		return true;
	else
		return false;
}
