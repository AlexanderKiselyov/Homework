#include "Decimal.h"
#include <iostream>

void translation1(int firstNumber, int massFirst[])
{
	for (int i = (sizeof(int) * 8) - 1; i >= 0; i--)
	{
		int one = 1 << i; // вспомогательная единица
		bool bit1 = one & firstNumber;
		bool bit11 = bit1;
		std::cout << bit11;
		massFirst[((sizeof(int) * 8) - 1) - i] = bit11;
	}
}

void translation2(int secondNumber, int massSecond[])
{
	for (int i = (sizeof(int) * 8) - 1; i >= 0; i--)
	{
		int one = 1 << i; // вспомогательная единица
		bool bit2 = one & secondNumber;
		bool bit22 = bit2;
		std::cout << bit22;
		massSecond[((sizeof(int) * 8) - 1) - i] = bit22;
	}
}
