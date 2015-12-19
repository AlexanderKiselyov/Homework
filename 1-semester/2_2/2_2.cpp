#include <iostream>

using namespace std;

void power()
{
	int number = 0;
	int counter = 0;
	int currentNumber = 0;
	cout << "The number was: ";
	cin >> number;
	cout << "The power was: ";
	cin >> counter;
	if (counter == 0)
	{
		cout << "The number has become: " << "1" << endl;
	}
	else
	{
		currentNumber = number;
		for (int i = 1; i < counter; i++)
		{
			number = number * currentNumber;
		}
		cout << "The number has become: " << number << endl;
	}
}
	
void fastPower()
{
	int counter = 0;
	int number = 0;
	int currentCounter = 0;
	int currentNumber = 1;
	cout << "The number was: ";
	cin >> number;
	cout << "The power was: ";
	cin >> currentCounter;
	if (currentCounter == 0)
	{
		cout << "The number has become: " << "1" << endl;
	}
	else
	{
		while (currentCounter > 0)
		{
			if ((currentCounter % 2) == 0)
			{
				currentCounter = currentCounter / 2;
				number = number * number;
			}
			else
			{
				currentCounter--;
				currentNumber = currentNumber * number;
			}
		}
		cout << "The number has become: " << currentNumber;
	}
}

int main()
{
	power();

	fastPower();

	return 0;
}
