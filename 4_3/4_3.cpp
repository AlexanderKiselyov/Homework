// Тесты:
// 1. При отсутствии файла "input.txt" пишет "file not found";
// 2. При печати в файле строк:
// пекрекрер
// 54676587
//				 - табуляции
//         - пробелы
// уакупекрекр
// - пустая строка
// упкуп укпке
// пишет: 4.
#include <iostream>
#include <fstream>
#include <string.h>

using namespace std;

int main()
{
	char *str = new char[1024];
	int counter = 0;
	int count = 0;
	ifstream input("input.txt");
	if (!input)
	{
		printf("file not found\n");
		return 1;
	}
	while (!input.eof())
	{
		input.getline(str, 1024, '\n');
		int len = strlen (str);
		for (int i = 0; i < len; i++)
		{
			if ((str[i] == ' ') || (str[i] == '\t'))
			{
				count++;
			}
		}
		if (((count < len) || (count == 0)) && (!len == 0))
		{
			counter++;
		}
		count = 0;
		len = 0;
	}
	delete str;
	input.close();
	cout << "Number of unempty strings: " << counter << '\n';
	return 0;
}
