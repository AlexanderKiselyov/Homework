using System;
using System.Collections.Generic;

namespace Stack
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack stack = new Stack();
			stack.Push(10);
			stack.Push(7);
			stack.Push(2);
			Console.WriteLine(stack.Pop());
			Console.WriteLine(stack.Pop());
			Console.WriteLine(stack.Pop());
		}
	}

	class Stack
	{
		private	List<int> list = new List<int>();

		public void Push(int number) // adds elements to the stack
		{
			list.Add(number);
		}

		public int Pop() // takes elements off the stack and shows them
		{
			if (list.Count == 0)
			{
				return 0;
			}
			int result = list[list.Count - 1];
			list.RemoveAt(list.Count - 1);
			return result;
		}
	}
}