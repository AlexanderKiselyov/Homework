#include <iostream>

using namespace std;

int main()
{
	int counter = 0;
	int massiv[28] = {0};
	for (int i = 0; i < 10; i++)
	{
		for (int j = 0; j < 10; j++)
		{
			for (int k = 0; k < 10; k++)
			{
				massiv[i + j + k] = massiv[i + j + k] + 1;
			}
		}
	}
	for (int i = 0; i < 28; i++)
	{
		counter = counter + massiv[i] * massiv[i];
	}
	cout << "Kolitchestvo schastlivich biletov ravno: " << counter;
	return 0;
}
