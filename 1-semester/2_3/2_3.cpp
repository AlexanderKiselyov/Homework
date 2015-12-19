#include <iostream>

using namespace std;

const int number = 5; // число цифр в последовательности
const int counter = 10; // количество чисел от 0 до некоторого n в последовательности

int main()
{
	int mass[number] = {}; 
	int newMass[counter] = {}; // упорядоченный по возрастанию массив mass
	int numberOfNumbers[counter] = {}; // массив для запоминания количества цифр от 0 до некоторого n в последовательности
	cout << "Write array: ";
	for (int i = 0; i < number; i++)
	{
		cin >> mass[i];
		numberOfNumbers[mass[i]]++;
	}
	int k = 0;
	for (int i = 0; i < counter; i++)
	{
		for (int j = 0; j < numberOfNumbers[i]; j++)
		{
			newMass[j+k] = i;
		}
		k += numberOfNumbers[i];
	}
	for (int i = 0; i < number; i++)
	{
			cout << newMass[i] << " ";
	}
	return 0;
}
