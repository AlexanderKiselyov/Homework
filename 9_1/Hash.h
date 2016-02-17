#pragma once
#include <iostream>
#include <string>

using namespace std;

int const amount = 100;

struct Hash
{
	Hash *array[amount];
	int count = 0;
	int arrayCount[amount] = {1};
	string value;
	Hash *head;
	Hash *next;
};

void add(Hash *hash, string const &element);
void push(Hash *&elem, string element);
void show(Hash *hash);
int hashFunction(string element);
void Delete(Hash *hash);
