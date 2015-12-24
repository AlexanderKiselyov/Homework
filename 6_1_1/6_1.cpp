#include "telephone.h"
#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{
	string nameSurname; // name and surname of the required person in the book
	string telephoneFind; // the telephone of the required person in the book
	string command = "1";
	string nameAndSurname[100]; // name and surname of the new person in the book
	string telephone[100]; // telephone of the new person in the book
	PhoneBookRecord phoneBook[100];
	int currentCounter = 0; // current number of names in the book
	ifstream input("input.txt");
	ofstream output("output.txt");
	if (!input)
	{
		cout << "The file is not found." << endl;
		return 1;
	}
	while (!input.eof())
	{
		input >> phoneBook[currentCounter].nameAndSurname >> phoneBook[currentCounter].telephone;
		currentCounter++;
	}
	input.close();
	while (command != "0")
	{
		cout << "Write a command: ";
		cin >> command;
		if (command == "0")
		{
			cout << "Ending of the programm..." << endl;
			break;
		}
		if (command == "1")
		{
			cout << "Write name, surname and telephone number: ";
			cin >> phoneBook[currentCounter].nameAndSurname >> phoneBook[currentCounter].telephone;
			currentCounter++;
			continue;
		}
		if (command == "2")
		{
			cout << "Write name and surname: ";
			cin >> nameSurname;
			for (int i = 0; i < currentCounter; i++)
			{
				if (phoneBook[i].nameAndSurname == nameSurname)
				{
					cout << "His(her) telephone is: " << phoneBook[i].telephone << endl;
				}
			}
			continue;
		}
		if (command == "3")
		{
			cout << "Write telephone: ";
			cin >> telephoneFind;
			for (int i = 0; i < currentCounter; i++)
			{
				if (phoneBook[i].telephone == telephoneFind)
				{
					cout << "His(her) name and surname is: " << phoneBook[i].nameAndSurname << endl;
				}
			}
			continue;
		}
		if (command == "4")
		{
			fstream output("output.txt");
			for (int i = 0; i < currentCounter; i++)
			{
				output << phoneBook[i].nameAndSurname << " " << phoneBook[i].telephone << endl;
			}
			continue;
		}
		if ((command != "1") || (command != "2") || (command != "3") || (command != "4"))
		{
			cout << "Unknown command.";
		}
		cout << endl;
	}
	for (int i = 0; i < currentCounter; i++)
	{
		output << phoneBook[i].nameAndSurname << " " << phoneBook[i].telephone << endl;
	}
	output.close();
	return 0;
}
