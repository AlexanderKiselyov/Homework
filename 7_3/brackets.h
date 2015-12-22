#pragma once

struct Stack
{
	char value;
	Stack *next;
	Stack *head;
	Stack *tail;
	void push(char value); // pushes an open bracket into the stack
	void pop(int count); // deletes the open bracket from the stack
	void Del(); // deletes the stack after work
};
