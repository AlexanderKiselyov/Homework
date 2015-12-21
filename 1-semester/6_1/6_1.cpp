#include "telephone.h"
#include <iostream>
#include <fstream>
#include <string>

using namespace std;

const int counter = 10; // number of people and telephones if the file exists

int main()
{
	string nameSurname; // name and surname of the required person in the book
	string Telephone; // the telephone of the required person in the book
	string command = "1";
	string nameAndSurname[100]; // name and surname of the new person in the book
	string telephone[100]; // telephone of the new person in the book
	PhoneBookRecord phoneBook[100];
	int currentCounter = counter; // current number of names in the book
	ifstream input("input.txt");
	ofstream output("output.txt");
	if (!input)
	{
		cout << "The file is not found." << endl;
		currentCounter = 0;
	}
	else
	{
		for (int i = 0; i < currentCounter; i++)
		{
			input >> phoneBook[i].nameAndSurname >> phoneBook[i].telephone;
		}
	}
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
			cin >> Telephone;
			for (int i = 0; i < currentCounter; i++)
			{
				if (phoneBook[i].telephone == Telephone)
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
	input.close();
	return 0;
}
