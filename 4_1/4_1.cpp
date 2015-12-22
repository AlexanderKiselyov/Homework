// В дополнении к "хорошим" тестам написал такие:
// 1. 8 и -7. Вывел: 000...0001000 и 111...111001. Сумма: 000...0001. В десятичном виде выглядят как: 8 и -7.
// 2. -15 и -10. Вывел: 111...1110001 и 111...1110110. Сумма: 0111...11100111. В десятичном виде выглядят как: -15 и -10.

#include <iostream>

using namespace std;

int main()
{
	int firstNumber = 0;
	int secondNumber = 0;
	setlocale(LC_ALL, "RU");
	int massFirst[sizeof(int) * 8] = {};
	int massSecond[sizeof(int) * 8] = {};
	cout << "Введите первое число: ";
	cin >> firstNumber;
	cout << "Двоичное представление первого числа: ";
	for (int i = (sizeof(int) * 8) - 1; i >= 0; i--)
	{
		int one = 1 << i; // вспомогательная единица
		bool bit1 = one & firstNumber;
		bool bit11 = bit1;
		cout << bit11;
		massFirst[((sizeof(int) * 8) - 1) - i] = bit11;
	}
	cout << endl << "Введите второе число: ";
	cin >> secondNumber;
	cout << "Двоичное представление второго числа: ";
	for (int i = (sizeof(int) * 8) - 1; i >= 0; i--)
	{
		int one = 1 << i; // вспомогательная единица
		bool bit2 = one & secondNumber;
		bool bit22 = bit2;
		cout << bit22;
		massSecond[((sizeof(int) * 8) - 1) - i] = bit22;
	}
	cout << endl;
	int sumOfNumbers[sizeof(int) * 8] = {}; // каждая двоичная цифра суммы двух заданных чисел
	int additional[sizeof(int) * 8] = { 0 }; // дополнительный код, состоящий из 0 и 1. Если равен 1, то к соответствующему sumOfNumbers добавляется 1.
	for (int i = (sizeof(int) * 8 - 1); i > 0; i--)
	{
		if ((massFirst[i] == 1) && (massSecond[i] == 1))
		{
			sumOfNumbers[i] = additional[i];
			additional[i - 1] = 1;
		}
		else
		{
			sumOfNumbers[i] = massFirst[i] + massSecond[i] + additional[i];
			if (sumOfNumbers[i] == 2)
			{
				sumOfNumbers[i] = 0;
				additional[i - 1] = 1;
			}
		}
	}
	cout << "Сумма двоичных записей чисел равна:   ";
	for (int i = 0; i <= (sizeof(int) * 8 - 1); i++)
	{
		cout << sumOfNumbers[i];
	}
	cout << endl;
	int decimalFirstNumber = 0; // представление первого двоичного числа в десятичной системе
	int decimalSecondNumber = 0; // представление второго двоичного числа в десятичной системе
	int currentDegree = 1; // текущая степень двойки
	cout << "В десятичном виде двоичные числа выглядят как: ";
	for (int i = (sizeof(int) * 8 - 1); i >= 0; i--)
	{
		decimalFirstNumber += massFirst[i] * currentDegree;
		decimalSecondNumber += massSecond[i] * currentDegree;
		currentDegree *= 2;
	}
	cout << decimalFirstNumber << " и " << decimalSecondNumber << endl;
	return 0;
}
