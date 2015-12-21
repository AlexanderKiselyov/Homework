#pragma once

struct Stack
{
	int value;
	Stack *next;
	Stack *head = nullptr;
	Stack *tail = nullptr;
	void push(int value); // adds elements to the stack
	void pop(); // deletes the top elements from the array
};
